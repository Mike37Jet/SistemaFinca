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
using System.Windows.Forms.DataVisualization.Charting;
using ToolTip = System.Windows.Forms.ToolTip;

namespace SistemaFinca
{
    public partial class FormParametrosSistema : Form
    {

        public FormParametrosSistema()
        {
            InitializeComponent();
            getParametros();

        }

        private void getParametros()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT valorparametro FROM parametro ORDER BY idparametro";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        reader.Read();
                        txtPrecioLeche.Text = reader.GetFloat(0).ToString();
                        reader.Read();
                        txtCapacidadMaxima.Text = reader.GetFloat(0).ToString();
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

        private Form formularioActivo = null;


        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }
            else
            {
                this.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string pattern = @"^\d{1,2}(\,\d{1,2})?$";
            string pattern2 = @"^[1-9]\d{3}$";
            if (txtPrecioLeche.Text == "" || !Regex.IsMatch(txtPrecioLeche.Text, pattern))
            {
                MessageBox.Show("Precio no válido", "Actualización Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCapacidadMaxima.Text == "" || !Regex.IsMatch(txtCapacidadMaxima.Text, pattern2))
            {
                MessageBox.Show("Nuevo valor no válido", "Actualización Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"UPDATE parametro SET valorparametro = {txtPrecioLeche.Text.Replace(',', '.')} WHERE idparametro = 1";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();

                    String commString2 = $"UPDATE parametro SET valorparametro = {txtCapacidadMaxima.Text} WHERE idparametro = 2";
                    NpgsqlCommand comm2 = new NpgsqlCommand(commString2, connection);
                    int resultado2 = comm2.ExecuteNonQuery();
                    if (resultado > 0 && resultado2 > 0)
                    {
                        MessageBox.Show("Parámetros actualizados exitosamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
