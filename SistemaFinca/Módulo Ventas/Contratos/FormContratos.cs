using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinca
{
    public partial class FormContratos : Form
    {
        private char rol;
        private ToolTip toolTip = new ToolTip();
        public FormContratos(char rol)
        {
            InitializeComponent();
            getContratos();
            this.rol = rol;
        }

        private void getContratos()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT cedulacliente, cantidadleche, cantidadretirada, fechainicio, fechafin FROM contrato";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return;
                        }

                        while (reader.Read())
                        {
                            String cedula = reader.GetString(0);
                            String cantidad = reader.GetInt32(1).ToString();
                            String cantidadRetirada = reader.GetInt32(2).ToString();
                            String fechainicio = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                            String fechafin = reader.GetDateTime(4).ToString("dd/MM/yyyy");
                            ListViewItem item = new ListViewItem(cedula);
                            item.SubItems.Add(cantidad);
                            item.SubItems.Add(cantidadRetirada);
                            item.SubItems.Add(fechainicio);
                            item.SubItems.Add(fechafin);
                            lstContratos.Items.Add(item);
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
            panelFormularioHijo.Controls.Add(formularioHijo);
            panelFormularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }


        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            lstContratos.Items.Clear();
            getContratos();
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



        private void panelFormularioHijo_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (this.rol != 'A')
            {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            abrirFormulariosHijos(new FormVC_Registrar());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormVC_Consultar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.rol != 'A')
            {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            abrirFormulariosHijos(new FormVC_Eliminar());
        }

        private void btnGenerar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(btnGenerar, "Registrar contrato");
        }

        private void btnConsultar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(btnConsultar, "Consultar contrato");
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(btnEliminar, "Eliminar contrato");
        }
    }
}
