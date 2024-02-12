using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinca
{
    public partial class FormMenu : Form
    {
        private int borderSize;

        public FormMenu()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendeMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);




        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            mostrarSubMenu(subPanelAdministracion);
            //abrirFormulariosHijos(new FormAdministrador());
        }
        private void buttonGestionGanadera_Click(object sender, EventArgs e)
        {
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
            //abrirFormulariosHijos(new FormZonasPastoreo());
        }
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subPanelClientes);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }






        private void personalizarDiseño()
        {
            subPanelAdministracion.Visible = false;
            subPanelGestionGanadera.Visible = false;
            subPanelInventario.Visible = false;
            subPanelVenta.Visible = false;
            subPanelZonasPastoreo.Visible = false;
            subPanelClientes.Visible = false;
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
            if (subPanelClientes.Visible == true)
            {
                subPanelClientes.Visible = false;
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

        private void buttonHerrAgrGan_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormHerramientasAgricolasGanaderas());
        }

        private void buttonIndPers_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormIndumentariaDelPersonal());
        }

        private void buttonGestionCliente(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGestionClientes());
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
            abrirFormulariosHijos(new FormGanadoBovino());
        }

        private void buttonRegistroOrdeño_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormRegistroOrdeño());
        }
    }
}
