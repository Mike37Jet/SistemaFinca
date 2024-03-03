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
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaFinca.Módulo_Clientes.Gestión_Clientes
{
    public partial class SubFormGUActualizar : Form
    {
        private String numeroCedula;
        private String usuario;
        public SubFormGUActualizar(string numeroCedula, String usuario)
        {
            InitializeComponent();
            this.numeroCedula = numeroCedula;
            this.usuario = usuario;
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    char estado;
                    connection.Open();
                    String commExisteString = $"SELECT usuario, telefono, correo, contrasena, estado" +
                        $" FROM usuario WHERE cedulausuario = '{numeroCedula}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        reader.Read();
                        txtContrasena.Text = $"{reader.GetString(3)}";
                        txtCorreo.Text = $"{reader.GetString(2)}";
                        txtNombreU.Text = $"{reader.GetString(0)}";
                        txtTele.Text = $"{reader.GetString(1)}";
                        estado = reader.GetChar(4);
                    }
                    if (estado == 'A')
                    {
                        radioA.Checked = true;
                    }
                    else
                    {
                        radioD.Checked = true;
                    }
                    if (this.usuario == txtNombreU.Text)
                    {
                        radioA.Enabled = false;
                        radioD.Enabled = false;
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
            if (txtNombreU.Text.Length > 15 || txtNombreU.Text.Length < 5 || !FormGU_Registrar.UsuarioEsValido(txtNombreU.Text))
            {
                MessageBox.Show("Nombre de usuario no es válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtContrasena.Text.Length > 20 || txtContrasena.Text.Length < 8 || !FormGU_Registrar.ContrasenaEsValida(txtContrasena.Text))
            {
                MessageBox.Show("Contraseña nueva no es válida", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreo.Text.Length > 320 || !FormGU_Registrar.CorreoEsValido(txtCorreo.Text))
            {
                MessageBox.Show("Correo electrónico ingresado no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTele.Text.Length > 11 || txtTele.Text.Length < 7 || !FormGU_Registrar.TelefonoEsValido(txtTele.Text))
            {
                MessageBox.Show("Teléfono ingresado no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString2 = $"SELECT * FROM usuario WHERE usuario = '{txtNombreU.Text}'";
                    NpgsqlCommand commExiste2 = new NpgsqlCommand(commExisteString2, connection);
                    using (NpgsqlDataReader reader = commExiste2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("El nombre de usuario ya está registrado", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    DialogResult dialogResult = MessageBox.Show("Está seguro que desea actualizar los datos del usuario?", "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    char estado = radioA.Checked ? 'A' : 'I';
                    String commString = $"UPDATE usuario SET contrasena = '{txtContrasena.Text}', " +
                        $"correo = '{txtCorreo.Text}', usuario = '{txtNombreU.Text}', telefono = '{txtTele.Text}', " +
                        $"estado = '{estado}'  WHERE cedulausuario = '{this.numeroCedula}'";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Los datos del usuario se actualizaron exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SubFormGUActualizar_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioD.Checked)
            {
                radioD.Checked = false;
                radioA.Checked = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioA.Checked)
            {
                radioA.Checked = false;
                radioD.Checked = true;
            }
        }
    }
}
