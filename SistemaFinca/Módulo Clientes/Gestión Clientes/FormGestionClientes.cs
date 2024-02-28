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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using ToolTip = System.Windows.Forms.ToolTip;


namespace SistemaFinca
{
    public partial class FormGestionClientes : Form
    {
        private ToolTip toolTip = new ToolTip();

        public FormGestionClientes()
        {
            InitializeComponent();
            getClientes();
        }

        private void getClientes()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT cedulacliente, nombres, apellidos, telefono, direccion, correo " +
                        $"FROM cliente";
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
                            String nombres = reader.GetString(1);
                            String apellidos = reader.GetString(2);
                            String telefono = reader.GetString(3);
                            String direccion = reader.GetString(4);
                            String correo = reader.GetString(5);
                            ListViewItem item = new ListViewItem(cedula);
                            item.SubItems.Add(nombres);
                            item.SubItems.Add(apellidos);
                            item.SubItems.Add(telefono);
                            item.SubItems.Add(direccion);
                            item.SubItems.Add(correo);
                            listClientes.Items.Add(item);
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

        private void buttonRegistrar_Click_1(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormC_Registrar());
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormC_Actualizar());
        }

        private void buttonDarDeBaja_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormC_DarDeBaja());
        }

        private void buttonDarDeAlta_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormC_DarDeAlta());
        }



        private void buttonRegistrar_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(buttonRegistrar, "Registrar cliente");
        }

        private void buttonDarDeBaja_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(buttonDarDeBaja, "Dar de baja al cliente");
        }

        private void buttonDarDeAlta_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(buttonDarDeAlta, "Dar de alta al cliente");
        }

        private void buttonActualizar_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(buttonActualizar, "Actualizar cliente");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormC_Consultar());
        }
    }
}
