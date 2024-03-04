using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinca
{
    public partial class FormVC_Consultar : Form
    {
        public FormVC_Consultar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!FormGU_Registrar.CedulaEsValida(txtCedula.Text))
            {
                MessageBox.Show("Número de cédula de identidad no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String nombres, apellidos, telefono, correo;
                    String commExisteString = $"SELECT nombres, apellidos, telefono, correo FROM cliente WHERE cedulacliente = '{txtCedula.Text}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Cliente no registrado", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        nombres = reader.GetString(0);
                        apellidos = reader.GetString(1);
                        telefono = reader.GetString(2);
                        correo = reader.GetString(3);
                    }
                    String commString = $"SELECT fechaemision, fechainicio, fechafin, cantidadleche, cantidadretirada FROM contrato WHERE cedulacliente = '{txtCedula.Text}'" +
                        $" AND pagado = false;";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No existe un contrato asociado al cliente", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        txtNombres.Text = nombres;
                        txtApellidos.Text = apellidos;
                        txtCorreo.Text = correo;
                        txtTelefono.Text = telefono;
                        txtFechaEmision.Text = reader.GetDateTime(0).ToString();
                        txtFechaInicio.Text = reader.GetDateTime(1).ToString();
                        txtFechaFinalizacion.Text = reader.GetDateTime(2).ToString();
                        txtCantidadLeche.Text = reader.GetInt32(3).ToString();
                        txtCantidadRetirada.Text = reader.GetInt32(4).ToString();
                    }
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
