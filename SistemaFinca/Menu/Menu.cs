using SistemaFinca.Módulo_Zonas_de_Pastoreo.Fumigación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinca
{
    public partial class FormMenu : Form
    {
        private int borderSize;
        private char rol;
        private String usuario;
        private String fechainicio;

        public FormMenu(char rol, String usuario, String fechainicio)
        {
            InitializeComponent();
            personalizarDiseño();
            this.rol = rol;
            this.usuario = usuario;
            this.fechainicio = fechainicio;
            labelRol.Text = rol == 'A' ? "Administrador" : "Jornalero";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendeMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            insertarSesion();
            Application.Exit();
        }

        private void insertarSesion()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"INSERT INTO sesiones(usuario, fechainicio, fechafin) VALUES('{this.usuario}', '{this.fechainicio}', now()::timestamp(0))";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    comm.ExecuteNonQuery();
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

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState = FormWindowState.Normal;
        }

        private void panelEncabezado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendeMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void FormMenu_Resize(object sender, EventArgs e)
        {
            AjusteDeFormulario();
        }

        private void AjusteDeFormulario()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 8);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
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

        private void buttonAdministracion_Click(object sender, EventArgs e)
        {
            if (rol == 'A') {
                mostrarSubMenu(subPanelAdministracion);
                //abrirFormulariosHijos(new FormAdministrador());
            }
            else {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonGestionGanadera_Click(object sender, EventArgs e)
        {
            subPanelGestionGanadera.Size = new Size(279, 62);
            mostrarSubMenu(subPanelGestionGanadera);
            //abrirFormulariosHijos(new FormGestionGanadera());
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subPanelVenta);
            //abrirFormulariosHijos(new FormVentas());
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subPanelInventario);

        }

        private void buttonZonasPastoreo_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subPanelZonasPastoreo);

        }
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
            abrirFormulariosHijos(new FormGestionClientes());
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            insertarSesion();
            Application.Exit();
        }

        private void personalizarDiseño()
        {
            subPanelAdministracion.Visible = false;
            subPanelGestionGanadera.Visible = false;
            subPanelInventario.Visible = false;
            subPanelVenta.Visible = false;
            subPanelZonasPastoreo.Visible = false;
            subPanelGanadoLechero.Visible = false;
            subPanelGanadoCarne.Visible = false;

        }

        private void ocultarSubMenu()
        {
            if (subPanelAdministracion.Visible == true)
            {
                subPanelAdministracion.Visible = false;
            }
            if (subPanelGestionGanadera.Visible == true)
            {
                subPanelGestionGanadera.Visible = false;

                subPanelGanadoLechero.Visible = false;
                subPanelGanadoCarne.Visible = false;
            }
            if (subPanelInventario.Visible == true)
            {
                subPanelInventario.Visible = false;
            }
            if (subPanelVenta.Visible == true)
            {
                subPanelVenta.Visible = false;
            }
            if (subPanelZonasPastoreo.Visible == true)
            {
                subPanelZonasPastoreo.Visible = false;
            }

        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void mostrarSubMenu2(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu2();
                subMenu.Visible = true;

            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void ocultarSubMenu2()
        {
            if (subPanelGanadoLechero.Visible == true)
            {
                subPanelGanadoLechero.Visible = false;
            }
            if (subPanelGanadoCarne.Visible == true)
            {
                subPanelGanadoCarne.Visible = false;
            }

        }

        private void buttonHerrAgrGan_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormHerramientasAgricolasGanaderas());
        }

        private void buttonIndPers_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormIndumentariaDelPersonal());
        }


        private void buttonMedBov_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormMedicamentosBovinos());
        }

        private void buttonAliBov_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormAlimentariaBovina());
        }

        private void buttonGestionUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGestionUsuario());
        }

        private void buttonGanadoBovino_Click(object sender, EventArgs e)
        {
            if (subPanelGanadoLechero.Visible != false)
            {
                subPanelGestionGanadera.Size = new Size(279, 62);
            }
            else
            {
                subPanelGestionGanadera.Size = new Size(279, 122);
            }

            abrirFormulariosHijos(new FormGanadoLechero());
            mostrarSubMenu2(subPanelGanadoLechero);
        }

        private void buttonGanadoCarne_Click(object sender, EventArgs e)
        {
            if (subPanelGanadoCarne.Visible != false)
            {
                subPanelGestionGanadera.Size = new Size(279, 62);
            }
            else
            {
                subPanelGestionGanadera.Size = new Size(279, 92);
            }
            abrirFormulariosHijos(new FormGanadoDeCarne());
            mostrarSubMenu2(subPanelGanadoCarne);
        }

        private void buttonNotaVentas_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormVentas());
        }

        private void buttonInformeAnalisis_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormReportesAnalisis());
        }

        private void buttonAlertas_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormRecordAlert());
        }

        private void buttonGestionPagos_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormBuscar());
        }

        private void buttonGesZonPast_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGZP_Registrar());
        }

        private void buttonGestionArriendo_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGestArriAreas());
        }

        private void buttonSeguimientoActividad_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new GDZP_Fumigación());
        }

        private void buttonProcesoFaenamiento_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormProcesoFaenamiento());
        }

        private void buttonProduccionDeLeche_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormProduccionLeche());
        }

        private void buttonRegistroDeOrdeño_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormRegistroOrdeño());
        }

        private void buttonParametrosSistema_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormParametrosSistema());
        }

        private void buttonContratos_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormContratos());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
