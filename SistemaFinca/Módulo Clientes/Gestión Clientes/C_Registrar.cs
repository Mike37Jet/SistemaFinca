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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaFinca
{
    public partial class FormC_Registrar : Form
    {
        public FormC_Registrar()
        {
            InitializeComponent();
        }

        Form formularioActivo = null;


        private void button2_Click(object sender, EventArgs e)
        {

            if (!FormGU_Registrar.CedulaEsValida(textCedula.Text))
            {
                MessageBox.Show("El número de cédula de identidad no es válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textNombres.Text.Length > 60 || !FormGU_Registrar.NombresApellidosSonValidos(textNombres.Text))
            {
                MessageBox.Show("Nombres ingresados no válidos", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textApellidos.Text.Length > 60 || !FormGU_Registrar.NombresApellidosSonValidos(textApellidos.Text))
            {
                MessageBox.Show("Apellidos ingresados no válidos", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (textTelefono.Text.Length > 11 || !FormGU_Registrar.TelefonoEsValido(textTelefono.Text) || textTelefono.Text.Length < 7)
            {
                MessageBox.Show("Teléfono ingresado no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (textDireccion.Text.Length > 100 || textDireccion.Text.Length < 10 || !DireccionValida(textDireccion.Text))
            {
                MessageBox.Show("Dirección domiciliaria no válida", "vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (!FormGU_Registrar.CorreoEsValido(txtCorreo.Text))
            {
                MessageBox.Show("Correo electrónico ingresado no válido", "vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //MessageBox.Show("El cliente se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString = $"SELECT * FROM cliente WHERE cedulacliente = '{textCedula.Text}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("El número de cédula de identidad ya se encuentra registrado", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }


                    String commString = $"INSERT INTO cliente VALUES('{textCedula.Text}', '{textNombres.Text}', " +
                        $"'{textApellidos.Text}', '{textTelefono.Text}', '{txtCorreo.Text}', '{textDireccion.Text}', 'A')";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("El cliente se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttoContrato_Click_1(object sender, EventArgs e)
        {
            FormVContratos contratos = new FormVContratos();
            contratos.TopLevel = false;
            contratos.FormBorderStyle = FormBorderStyle.None;
            contratos.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(contratos);
            panelHijo.Tag = contratos;
            contratos.BringToFront();

            contratos.Show();

        }
        public static bool DireccionValida(string direccion)
        {
            Regex regex = new Regex(@"^[A-Za-z0-9ÁÉÍÓÚÑáéíóúñ.\-\s]{10,100}$");
            return regex.IsMatch(direccion);
        }
        private void vaciarCampos()
        {
            textCedula.Text = "";
            textNombres.Text = "";
            textApellidos.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
