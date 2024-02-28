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
using ToolTip = System.Windows.Forms.ToolTip;

namespace SistemaFinca
{
    public partial class FormGestionUsuario : Form
    {
        private ToolTip toolTip1 = new ToolTip();
        public FormGestionUsuario()
        {
            InitializeComponent();
            getUsuarios();
        }

        private void getUsuarios()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT cedulausuario, nombres, apellidos, telefono, correo, rol, " +
                        $"usuario FROM usuario";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String cedula = reader.GetString(0);
                            String nombres = reader.GetString(1);
                            String apellidos = reader.GetString(2);
                            String telefono = reader.GetString(3);
                            String correo = reader.GetString(4);
                            String rol = reader.GetChar(5) == 'A' ? "Administrador" : "Jornalero";
                            String usuario = reader.GetString(6);
                            ListViewItem item = new ListViewItem(cedula);
                            item.SubItems.Add(nombres);
                            item.SubItems.Add(apellidos);
                            item.SubItems.Add(telefono);
                            item.SubItems.Add(correo);
                            item.SubItems.Add(rol);
                            item.SubItems.Add(usuario);
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
            abrirFormulariosHijos(new FormGU_Registrar());
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGU_Actualizar());
        }

        private void buttonGenerarInforme_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGU_GenerarInforme());
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGU_Eliminar());
        }

        private void buttonRegistrar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonRegistrar, "Registrar usuario");
        }

        private void buttonEliminar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonEliminar, "Eliminar usuario");
        }

        private void buttonActualizar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonActualizar, "Actualizar usuario");
        }

        private void buttonInforme_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonInforme, "Generar informe");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGU_Consultar());
        }

        private void buttonBuscar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonBuscar, "Consultar usuario");
        }
    }
}
