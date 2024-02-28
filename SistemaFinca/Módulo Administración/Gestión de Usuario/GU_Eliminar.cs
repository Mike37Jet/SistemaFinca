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
    public partial class FormGU_Eliminar : Form
    {
        public FormGU_Eliminar()
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
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString = $"SELECT usuario FROM usuario WHERE cedulausuario = '{txtNumeroC.Text}'";
                    String nombreUsuario;
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("El número de cédula no se encuentra registrado", "Datos no registrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        nombreUsuario = reader.GetString(0);
                    }

                    DialogResult dialogResult = MessageBox.Show("Esta seguro que desea eliminar al usuario " + nombreUsuario + "?", "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                    String commString = $"DELETE FROM usuario WHERE cedulausuario = '{txtNumeroC.Text}'";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("El usuario se ha eliminado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormGU_Eliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
