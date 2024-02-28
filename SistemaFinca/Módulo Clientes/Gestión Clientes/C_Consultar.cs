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
                        if (estado == 'A')
                        {
                            MessageBox.Show("El cliente no se encuentra dado de baja", "No se pueda dar de alta al cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        DialogResult dialogResult = MessageBox.Show("Esta seguro que desea dar de alta al cliente?", "Confirmación", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                        String commString2 = $"UPDATE cliente SET estado = 'A'" +
                                $" WHERE cedulacliente = '{txtNumeroC.Text}'";
                        NpgsqlCommand comm2 = new NpgsqlCommand(commString2, connection);
                        int resultado = comm2.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("El cliente se ha dado de alta exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!FormGU_Registrar.CedulaEsValida(txtNumeroC.Text))
            {
                MessageBox.Show("El número de cédula no es válido", "vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString = $"SELECT nombres, apellidos, telefono, direccion " +
                        $"FROM cliente WHERE cedulacliente = '{txtNumeroC.Text}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("El número de cédula no se encuentra registrado", "Datos no registrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        labelNombre.Text = $"Nombres: {reader.GetString(0)}";
                        labelApellido.Text = $"Apellidos: {reader.GetString(1)}";
                        labeltele.Text = $"Teléfono: {reader.GetString(2)}";
                        labelDireccion.Text = $"Dirección domiciliaria: {reader.GetString(3)}";
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
