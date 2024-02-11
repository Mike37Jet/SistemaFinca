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
    public partial class FormGestionUsuario : Form
    {
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
    }
}
