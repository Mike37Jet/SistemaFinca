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
                        labelPrecioActual.Text = reader.GetFloat(0).ToString();
                        reader.Read();
                        labelCantidadMaxLeche.Text = reader.GetFloat(0).ToString();
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


        private void buttonActualizarPrecioLeche_Click(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]+(\,[0-9]{1,2})?$";
            if (textNuevoPrecioLeche.Text == "")
            {
                MessageBox.Show("Atributo vacío. Por favor, ingrese un valor.", "Actualización Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(textNuevoPrecioLeche.Text, pattern))
            {
                MessageBox.Show("Atributo no numérico o no cumple con la estructura. Por favor, ingrese un valor válido.", "Actualización Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String commString = $"UPDATE parametro SET valorparametro = {textNuevoPrecioLeche.Text.Replace(',', '.')} WHERE idparametro = 1";
                        NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                        int resultado = comm.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            getParametros();
                            MessageBox.Show("Precio actualizado exitosamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        textNuevoPrecioLeche.Text = "";
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


        private void buttonActualizaCantidadMax_Click(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]+$";
            if (textNuevaCapacidadMaxLeche.Text == "")
            {
                MessageBox.Show("Atributo vacío. Por favor, ingrese un valor.", "Actualización Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(textNuevaCapacidadMaxLeche.Text, pattern))
            {
                MessageBox.Show("Atributo no numérico o no cumple con la estructura. Por favor, ingrese un valor válido.", "Actualización Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String commString = $"UPDATE parametro SET valorparametro = {textNuevaCapacidadMaxLeche.Text} WHERE idparametro = 2";
                        NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                        int resultado = comm.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            getParametros();
                            MessageBox.Show("Capacidad del tanque frío actualizada correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                        }
                        textNuevaCapacidadMaxLeche.Text = "";
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
