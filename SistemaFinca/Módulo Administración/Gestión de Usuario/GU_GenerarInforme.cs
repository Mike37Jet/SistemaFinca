using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinca
{
    public partial class FormGU_GenerarInforme : Form
    {
        public FormGU_GenerarInforme()
        {
            InitializeComponent();
            getSesiones();
        }

        private void getSesiones()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT usuario, fechainicio, fechafin FROM sesiones";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return;
                        }

                        while (reader.Read())
                        {
                            String usuario = reader.GetString(0);
                            String fechainicio = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                            String fechafin = reader.GetDateTime(2).ToString("dd/MM/yyyy");
                            ListViewItem item = new ListViewItem(usuario);
                            item.SubItems.Add(fechainicio);
                            item.SubItems.Add(fechafin);
                            listUsuarios.Items.Add(item);
                        }
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            if (textBoxInforme.Text != "")
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Esta vacío el informe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Imprimir(Object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);


            e.Graphics.DrawString(textBoxInforme.Text, font, Brushes.Black, new RectangleF(0, 100, 2000, 200));



        }

        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
