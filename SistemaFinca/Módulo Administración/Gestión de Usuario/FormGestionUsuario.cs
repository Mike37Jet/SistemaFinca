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
        private String usuario;
        public FormGestionUsuario(string usuario)
        {
            InitializeComponent();
            getUsuarios();
            getUsuariosInactivos();
            this.usuario = usuario;
        }

        private void getUsuariosInactivos()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT cedulausuario, usuario, correo, rol " +
                        $" FROM usuario WHERE estado = 'I'";
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
                            String usuario = reader.GetString(1);
                            String correo = reader.GetString(2);
                            String rol = reader.GetChar(3) == 'A' ? "Administrador" : "Jornalero";
                            ListViewItem item = new ListViewItem(cedula);
                            item.SubItems.Add(usuario);
                            item.SubItems.Add(correo);
                            item.SubItems.Add(rol);
                            lstUsuariosInactivos.Items.Add(item);
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

        private void getUsuarios()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT cedulausuario, usuario, correo, rol " +
                        $" FROM usuario WHERE estado = 'A'";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String cedula = reader.GetString(0);
                            String usuario = reader.GetString(1);
                            String correo = reader.GetString(2);
                            String rol = reader.GetChar(3) == 'A' ? "Administrador" : "Jornalero";
                            ListViewItem item = new ListViewItem(cedula);
                            item.SubItems.Add(usuario);
                            item.SubItems.Add(correo);
                            item.SubItems.Add(rol);
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
            listUsuarios.Items.Clear();
            lstUsuariosInactivos.Items.Clear();
            getUsuarios();
            getUsuariosInactivos();
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
            abrirFormulariosHijos(new FormGU_Actualizar(this.usuario));
        }

        private void buttonGenerarInforme_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGU_GenerarInforme());
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGU_Eliminar());
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGU_Consultar());
        }

      


        private void buttonRegistrar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(buttonRegistrar, "Registrar usuario");
        }

        private void buttonBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(buttonBuscar, "Consultar usuario");
        }

        private void buttonEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(buttonEliminar, "Eliminar usuario");
        }

        private void buttonActualizar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(buttonActualizar, "Actualizar usuario");
        }

        private void buttonInforme_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(buttonInforme, "Generar informe");
        }
    }
}
