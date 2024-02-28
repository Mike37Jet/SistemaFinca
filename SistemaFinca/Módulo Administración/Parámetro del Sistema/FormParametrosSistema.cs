using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace SistemaFinca
{
    public partial class FormParametrosSistema : Form
    {
        
        private double precioActualDeLeche = new double();
        private int cantidadMaxDeLeche = new int();

        public FormParametrosSistema()
        {
            InitializeComponent();
            labelPrecioActual.Text = precioActualDeLeche.ToString() + " $";
            labelCantidadMaxLeche.Text = cantidadMaxDeLeche.ToString() + " Litros";


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






        private void buttonActualizarPrecioLeche_Click(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]+(\.[0-9]{1,2})?$";
            if (textNuevoPrecioLeche.Text == "")
            {
                MessageBox.Show("Atributo vacío. Por favor, ingrese un valor.", "Actualización Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(textNuevoPrecioLeche.Text, pattern))
            {
                MessageBox.Show("Atributo no numérico o no cumple con la estructura. Por favor, ingrese un valor válido.", "Actualización Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {        
                labelPrecioActual.Text = textNuevoPrecioLeche.Text + " $";
                precioActualDeLeche = double.Parse(textNuevoPrecioLeche.Text);
            }

        }


        private void buttonActualizaCantidadMax_Click(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]+$";
            if (textNuevaCapacidadMaxLeche.Text == "")
            {
                MessageBox.Show("Atributo vacío. Por favor, ingrese un valor.", "Actualización Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(textNuevaCapacidadMaxLeche.Text, pattern))
            {
                MessageBox.Show("Atributo no numérico o no cumple con la estructura. Por favor, ingrese un valor válido.", "Actualización Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                labelCantidadMaxLeche.Text = textNuevaCapacidadMaxLeche.Text + " Litros";
                cantidadMaxDeLeche = int.Parse(textNuevaCapacidadMaxLeche.Text);
            }
        }
    }
}
