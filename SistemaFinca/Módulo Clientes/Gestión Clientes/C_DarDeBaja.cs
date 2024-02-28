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
                        String commString = $"SELECT estado FROM cliente WHERE cedulacliente = '{txtNumeroC.Text}'";
                        NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                        NpgsqlDataReader reader = comm.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("El número de cédula no se encuentra registrado", "Datos no registrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        char estado = reader.GetChar(0);
                        reader.Close();
                        if (estado == 'I')
                        {
                            MessageBox.Show("El cliente ya se encuentra dado de baja", "No se pueda dar de baja al cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        DialogResult dialogResult = MessageBox.Show("Está seguro que desea dar de baja al cliente?", "Confirmación", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                        String commString2 = $"UPDATE cliente SET estado = 'I'" +
                                $" WHERE cedulacliente = '{txtNumeroC.Text}'";
                        NpgsqlCommand comm2 = new NpgsqlCommand(commString2, connection);
                        int resultado = comm2.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("El cliente se ha dado de baja exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
