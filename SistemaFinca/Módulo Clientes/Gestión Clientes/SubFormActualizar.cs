using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SistemaFinca.Módulo_Clientes.Gestión_Clientes
{
    public partial class SubFormActualizar : Form
    {
        private String numeroCedula;
        public SubFormActualizar(string numeroCedula)
        {
            InitializeComponent();
            this.numeroCedula = numeroCedula;
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    char estado;
                    connection.Open();
                    String commExisteString = $"SELECT nombres, apellidos, telefono, direccion" +
                        $" FROM cliente WHERE cedulacliente = '{this.numeroCedula}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        reader.Read();
                        txtNombre.Text = $"{reader.GetString(0)}";
                        txtApellido.Text = $"{reader.GetString(1)}";
                        txtTele.Text = $"{reader.GetString(2)}";
                        txtDireccion.Text = $"{reader.GetString(3)}";
                        
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


        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 60 || !FormGU_Registrar.NombresApellidosSonValidos(txtNombre.Text))
            {
                MessageBox.Show("Nombres ingresados no válidos", "vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellido.Text.Length > 60 || !FormGU_Registrar.NombresApellidosSonValidos(txtApellido.Text))
            {
                MessageBox.Show("Apellidos ingresados no válidos", "vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTele.Text.Length > 11 || !FormGU_Registrar.TelefonoEsValido(txtTele.Text) || txtTele.Text.Length < 7)
            {
                MessageBox.Show("Teléfono ingresado no válido", "vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDireccion.Text.Length > 100 || FormC_Registrar.DireccionValida(txtDireccion.Text))
            {
                MessageBox.Show("direccion no válida", "vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro que desea actualizar los datos del usuario?", "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    connection.Open();
                    
                    String commString = $"UPDATE cliente SET nombres = '{txtNombre.Text}', " +
                        $"apellidos = '{txtApellido.Text}', telefono = '{txtTele.Text}', direccion = '{txtDireccion.Text}' " +
                        $" WHERE cedulacliente = '{this.numeroCedula}'";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Los datos del Cliente se actualizaron exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
