using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Net.Mime.MediaTypeNames;

namespace SistemaFinca
{
    public partial class FormGU_Registrar : Form
    {

        public FormGU_Registrar()
        {
            InitializeComponent();
            radioJor.Checked = true;
            ocultarEjemplos();
        }

        private void ocultarEjemplos()
        {
            labelEjApellidos.Visible = false;
            labelEjCedula.Visible = false;
            labelEjContraseña.Visible = false;
            labelEjEmail.Visible = false;
            labelEjNombres.Visible = false;
            labelEjTelefono.Visible = false;
            labelEjUsuario.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CedulaEsValida(txtNumeroC.Text))
            {
                MessageBox.Show("El número de cédula no es válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelEjCedula.Visible = true;
                return;
            }
            else
            {
                labelEjCedula.Visible = false;
            }

            if (txtNombres.Text.Length > 60 || !NombresApellidosSonValidos(txtNombres.Text))
            {
                MessageBox.Show("Nombres ingresados no válidos", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelEjNombres.Visible=true;
                return;

            }
            else
            {
                labelEjNombres.Visible = false;
            }
            if (txtApellidos.Text.Length > 60 || !NombresApellidosSonValidos(txtApellidos.Text))
            {
                MessageBox.Show("Apellidos ingresados no válidos", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelEjApellidos.Visible=true;
                return;
            }
            else
            {
                labelEjApellidos.Visible = false;
            }
            if (txtTelefono.Text.Length > 11 || txtTelefono.Text.Length < 7 || !TelefonoEsValido(txtTelefono.Text))
            {
                MessageBox.Show("Teléfono ingresado no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelEjTelefono.Visible=true;
                return;
            }
            else
            {
                labelEjTelefono.Visible = false;
            }
          
            if (txtNombreU.Text.Length > 15 || txtNombreU.Text.Length < 5 || !UsuarioEsValido(txtNombreU.Text))
            {
                MessageBox.Show("Nombre usuario ingresado no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelEjUsuario.Visible=true;
                return;
            }
            else
            {
                labelEjUsuario.Visible = false;
            }
            if (txtContrasena.Text.Length > 20 || txtContrasena.Text.Length < 8 || !ContrasenaEsValida(txtContrasena.Text))
            {
                MessageBox.Show("Contraseña ingresada no válida", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelEjContraseña.Visible=true;
                return;
            }
            else
            {
                labelEjContraseña.Visible = false;
            }
            if (txtCorreo.Text.Length > 320 || !CorreoEsValido(txtCorreo.Text))
            {
                MessageBox.Show("Correo electrónico ingresado no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelEjEmail.Visible = true;
                return;
            }
            else
            {
                labelEjEmail.Visible = false;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString = $"SELECT * FROM usuario WHERE cedulausuario = '{txtNumeroC.Text}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("El número de cédula ya se encuentra registrado", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
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

                    char rol = radioAd.Checked ? 'A' : 'U';
                    String commString = $"INSERT INTO usuario VALUES('{txtNumeroC.Text}', '{txtNombres.Text}', " +
                        $"'{txtApellidos.Text}', '{txtTelefono.Text}', '{txtCorreo.Text}', '{txtNombreU.Text}', '{txtContrasena.Text}', '{rol}', 'A')";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vaciarCampos();
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
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtContrasena.Text = "";
            txtCorreo.Text = "";
            txtNombreU.Text = "";
            txtNumeroC.Text = "";
            txtTelefono.Text = "";
        }

        public static bool UsuarioEsValido(string usuario)
        {
            Regex regex = new Regex("^[a-zA-Z]{5,15}$");
            return regex.IsMatch(usuario);
        }

        public static bool ContrasenaEsValida(string contrasena)
        {
            Regex regex = new Regex("^[a-zA-Z0-9!@#$%&_\\-.:;]{8,20}$");
            return regex.IsMatch(contrasena);
        }

        public static bool NombresApellidosSonValidos(string nombre)
        {
            Regex regex = new Regex("^[A-ZÁÉÍÓÚÑ][a-záéíóúñ]+(?: [A-ZÁÉÍÓÚÑ][a-záéíóúñ]+)?$");
            return regex.IsMatch(nombre);
        }

        public static bool CorreoEsValido(string correo)
        {
            Regex regex = new Regex("^(?=[a-zA-Z0-9._-]{1,64}@([a-zA-Z]+[a-zA-Z0-9]*\\.)+[a-zA-Z]{1,}[a-zA-Z0-9]*$)[a-zA-Z0-9._-]{1,64}@([a-zA-Z]+[a-zA-Z0-9]*\\.)+[a-zA-Z]{1,}[a-zA-Z0-9]*$");
            return regex.IsMatch(correo);
        }

        public static bool TelefonoEsValido(string telefono)
        {
            return Regex.IsMatch(telefono, "^[0-9]{7,11}$");
        }

        public static bool CedulaEsValida(string cedula)
        {
            // Verificar longitud
            if (cedula.Length != 10)
            {
                return false;
            }

            if (!Regex.IsMatch(cedula, "^[0-9]{10}$"))
            {
                return false;
            }

            string inicioCedula = cedula.Substring(0, 2);
            if (!Regex.IsMatch(inicioCedula, "^(0[1-9]|1[0-9]|2[0-4]|30)$"))
            {
                return false;
            }

            // Lista de pesos
            int[] pesos = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int suma = 0;

            // Recorrer dígitos (excepto el último)
            for (int i = 0; i < 9; i++)
            {
                int digito = int.Parse(cedula[i].ToString());
                int producto = digito * pesos[i];
                suma += producto < 10 ? producto : producto - 9;
            }

            // Obtener dígito verificador calculado
            int digitoVerificadorCalculado = 10 - (suma % 10);
            digitoVerificadorCalculado = digitoVerificadorCalculado == 10 ? 0 : digitoVerificadorCalculado;

            // Comparar con dígito verificador de la cédula
            int digitoVerificadorCedula = int.Parse(cedula[9].ToString());
            return digitoVerificadorCalculado == digitoVerificadorCedula;
        }
    }
}
