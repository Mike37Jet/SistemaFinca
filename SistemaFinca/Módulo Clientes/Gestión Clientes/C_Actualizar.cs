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
using SistemaFinca.Módulo_Clientes.Gestión_Clientes;

namespace SistemaFinca
{
    public partial class FormC_Actualizar : Form
    {
        public FormC_Actualizar()
        {
            InitializeComponent();
        }
        private Form formularioActivo = null;
        private void abrirFormulariosHijos(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelActualizarCliente.Controls.Add(formularioHijo);
            panelActualizarCliente.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void button1_Click_1(object sender, EventArgs e)
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
                        else
                        {
                            abrirFormulariosHijos(new SubFormActualizar(txtNumeroC.Text));
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
}
