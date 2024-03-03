using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinca
{
    public partial class FormC_Consultar : Form
    {
        public FormC_Consultar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!FormGU_Registrar.CedulaEsValida(txtNumeroC.Text))
            {
                MessageBox.Show("El número de cédula de identidad no es válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString = $"SELECT nombres, apellidos, telefono, direccion, correo " +
                        $"FROM cliente WHERE cedulacliente = '{txtNumeroC.Text}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("El número de cédula de identidad no se encuentra registrado", "Datos no registrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        labelNombre.Text = $"Nombres: {reader.GetString(0)}";
                        labelApellido.Text = $"Apellidos: {reader.GetString(1)}";
                        labeltele.Text = $"Teléfono: {reader.GetString(2)}";
                        labelDireccion.Text = $"Dirección domiciliaria: {reader.GetString(3)}";
                        labelCorreo.Text = $"Correo electrónico: {reader.GetString(4)}";
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
