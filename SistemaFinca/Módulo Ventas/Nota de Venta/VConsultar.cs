using Npgsql;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Drawing.Imaging;
using DinkToPdf;
using Microsoft.Identity.Client.NativeInterop;


namespace SistemaFinca
{
    public partial class FormVConsultar : Form
    {
        private String idnota = "";
        private String idcliente = "";
        private SubFormVConsultar formSubVConsultas = new SubFormVConsultar();
        public FormVConsultar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            panelSubHijo.Controls.Add(formularioHijo);
            panelSubHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!FormGU_Registrar.CedulaEsValida(txtCedula.Text))
            {
                MessageBox.Show("Número de cédula de identidad no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString = $"SELECT cedulacliente FROM cliente WHERE cedulacliente = '{txtCedula.Text}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Cliente no registrado", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    String commNotas = $"SELECT cantidadleche, monto, fechaemision, idnota FROM nota_venta WHERE cedulacliente = '{txtCedula.Text}'";
                    NpgsqlCommand comm = new NpgsqlCommand(commNotas, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No existen notas de venta", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        lstNotasVenta.Rows.Clear();
                        while (reader.Read())
                        {
                            string cantidad = reader.GetInt32(0).ToString();
                            string monto = reader.GetDecimal(1).ToString();
                            string fecha = reader.GetDateTime(2).ToString();
                            string idnota = reader.GetInt32(3).ToString();

                            lstNotasVenta.Rows.Add(cantidad, monto, fecha, idnota);
                            lstNotasVenta.ClearSelection();
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

        private void lstNotasVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                lstNotasVenta.ClearSelection();
                lstNotasVenta.Rows[e.RowIndex].Selected = true;

                this.idnota = lstNotasVenta.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            if (this.idnota == "")
            {
                MessageBox.Show("Seleccione una nota de venta, para visualizar", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();

                    String commString2 = $"SELECT cantidadleche, monto, fechaemision, idnota FROM nota_venta WHERE cedulacliente = '{txtCedula.Text}'";
                    NpgsqlCommand comm2 = new NpgsqlCommand(commString2, connection);
                    int resultado = comm2.ExecuteNonQuery();

                    using (NpgsqlDataReader reader = comm2.ExecuteReader())
                    while (reader.Read())
                    {
                           string cantidad = reader.GetInt32(0).ToString();
                           string VTotal = reader.GetDecimal(1).ToString();
                           string fecha = reader.GetDateTime(2).ToString();
                           string idnota = reader.GetInt32(3).ToString();
                           formSubVConsultas.llenarDatos(cantidad,VTotal,fecha,idnota);
                    }

                    String commString = $"SELECT nombres, apellidos, telefono, correo, direccion FROM cliente WHERE cedulacliente = (SELECT cedulacliente FROM nota_venta WHERE idnota = {this.idnota})";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado2 = comm.ExecuteNonQuery();

                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    while (reader.Read())
                    {
                        string nombres = reader.GetString(0).ToString();
                        string apellidos = reader.GetString(1).ToString();
                        string telefono = reader.GetString(2).ToString();
                        string correo = reader.GetString(3).ToString();
                        string direccion = reader.GetString(4).ToString();
                        formSubVConsultas.llenarDatos1(nombres, apellidos, telefono, correo, direccion);
                           

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


            abrirFormulariosHijos(formSubVConsultas);
        
        }

    }

}
