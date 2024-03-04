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
            panelContrato.Visible = false;
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
                    String nombres, apellidos, cedulacliente, direccion;
                    String commExisteString = $"SELECT nombres, apellidos, cedulacliente, direccion FROM cliente WHERE cedulacliente = '{txtCedula.Text}'";
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
                        cedulacliente = reader.GetString(2);
                        direccion = reader.GetString(3);
                    }
                    String commString = $"SELECT fechaemision, fechainicio, fechafin, cantidadleche, cantidadretirada FROM contrato WHERE cedulacliente = '{txtCedula.Text}'" +
                        $" AND pagado = false OR (cantidadleche != cantidadretirada AND pagado = true)";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No existe un contrato asociado al cliente", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        labelNombres.Text = nombres;
                        labelNombres1.Text = nombres;
                        labelApellidos.Text = apellidos;
                        labelApellidos1.Text = apellidos;
                        labelCedula.Text = cedulacliente;
                        labelDireccionDomiciliaria.Text = direccion;
                        labelFechaEmision.Text = reader.GetDateTime(0).ToString();
                        labelFechaInicio.Text = reader.GetDateTime(1).ToString();
                        labelFechaFinalizacion.Text = reader.GetDateTime(2).ToString();
                        labelCantidadLeche.Text = reader.GetInt32(3).ToString() + " Litros";
                        txtCantidadRetirada.Text = reader.GetInt32(4).ToString();
                        panelContrato.Visible = true;
                        txtCedula.Text = ""; 
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

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
