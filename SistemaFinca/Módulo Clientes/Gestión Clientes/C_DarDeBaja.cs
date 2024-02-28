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

namespace SistemaFinca
{
    public partial class FormC_DarDeBaja : Form
    {
        public FormC_DarDeBaja()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (!FormGU_Registrar.CedulaEsValida(txtNumeroC.Text))
            {
                MessageBox.Show("El número de cédula no es válido", "vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String commString = $"SELECT cedulacliente FROM cliente WHERE cedulacliente = '{txtNumeroC.Text}'";
                        NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                        NpgsqlDataReader reader = comm.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("El número de cédula no se encuentra registrado", "Datos no registrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro que desea actualizar los datos del cliente?", "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    connection.Open();

                    String commString = $"UPDATE cliente SET estado = 'A'" +
                        $" WHERE cedulacliente = '{txtNumeroC}'";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("El cliente se ha dado de baja exitosamente.", "Cambio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormC_DarDeBaja_Load(object sender, EventArgs e)
        {

        }
    }
}
