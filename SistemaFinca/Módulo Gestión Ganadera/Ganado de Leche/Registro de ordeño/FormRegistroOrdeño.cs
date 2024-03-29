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
    public partial class FormRegistroOrdeño : Form
    {
        private ToolTip toolTip = new ToolTip();
        private float rotationAngleX = 0;
        private float rotationAngleY = 0;
        public FormRegistroOrdeño()
        {
            InitializeComponent();
            // Configura el PictureBox para mostrar el GIF (ajusta la ruta según sea necesario)
            //pictureGIF.Image = System.Drawing.Image.FromFile("C:\\Users\\migue\\Desktop\\Iconos\\Finca\\vaca.gif");
            //pictureGIF.SizeMode = PictureBoxSizeMode.StretchImage;
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
            abrirFormulariosHijos(new FormRO_Registrar());
        }



        private void buttonRegistrar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(buttonRegistrar, "Registrar ordeño");
        }
    }
}
