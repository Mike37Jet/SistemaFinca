﻿using System;
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
    public partial class FormHerramientasAgricolasGanaderas : Form
    {
        private ToolTip toolTip = new ToolTip();
        public FormHerramientasAgricolasGanaderas()
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
            abrirFormulariosHijos(new FormHAG_Registrar());
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormHAG_Actualizar());
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormHAG_Consultar());
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormHAG_Eliminar());
        }

        private void buttonRegistrar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(buttonRegistrar, "Registrar herramienta");
        }

        private void buttonActualizar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(buttonActualizar, "Actualizar herramienta");
        }

        private void buttonBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(buttonBuscar, "Consultar herramienta");
        }

        private void buttonEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(buttonEliminar, "Eliminar herramienta");
        }
    }
}
