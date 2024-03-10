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
    public partial class FormVC_Eliminar : Form
    {
        private int idcontrato = 0;
        public FormVC_Eliminar()
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
                    String commString = $"SELECT fechaemision, fechainicio, fechafin, cantidadleche, cantidadretirada, idcontrato FROM contrato WHERE cedulacliente = '{txtCedula.Text}'" +
                        $" AND (pagado = false OR (cantidadleche != cantidadretirada AND pagado = true))";
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
                        txtFechaEmision.Text = reader.GetDateTime(0).ToString("dd/MM/yyyy");
                        txtFechaInicio.Text = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                        txtFechaFinalizacion.Text = reader.GetDateTime(2).ToString("dd/MM/yyyy");
                        txtCantidadLeche.Text = reader.GetInt32(3).ToString();
                        txtCantidadRetirada.Text = reader.GetInt32(4).ToString();
                        idcontrato = reader.GetInt32(5);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.idcontrato == 0)
            {
                MessageBox.Show("Ingrese el nùmero de cèdula de un cliente", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar este contrato?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"DELETE FROM contrato WHERE idcontrato = {this.idcontrato}";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Contrato eliminado exitosamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.idcontrato = 0;
                        vaciarCampos();
                        return;
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

        private void vaciarCampos()
        {
            txtCedula.Text = "";
            txtCantidadLeche.Text = "";
            txtFechaEmision.Text = "";
            txtFechaFinalizacion.Text = "";
            txtFechaInicio.Text = "";
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtCantidadRetirada.Text = "";
        }
    }
}
