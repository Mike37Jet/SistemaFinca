using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace SistemaFinca
{
    public partial class FormGestionUsuario : Form
    {
        private ToolTip toolTip1 = new ToolTip();
        public FormGestionUsuario()
        {
            InitializeComponent();
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

        private void buttonRestablecerContraseña_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormGU_RestablecerContraseña());
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

        private void buttonRestablecerContraseña_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonRestablecerContraseña, "Restablecer contraseña");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
