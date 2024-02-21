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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaFinca
{
    public partial class FormC_Registrar : Form
    {
        public FormC_Registrar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            Regex regex2 = new Regex(pattern);

            if (textCedula.Text.Length != 10)
            {
                MessageBox.Show("Cédula inválida", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (textNombres.Text.Length >= 30 || textNombres.Text == null)
            {
                MessageBox.Show("Nombres inválidos", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textApellidos.Text.Length >= 30 || textNombres.Text == null)
            {
                MessageBox.Show("Apellidos inválidos", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textTelefono.Text.Length != 10 )
            {
                MessageBox.Show("Número de teléfono inválido", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textDireccionDom.Text.Length >= 50 || textNombres.Text == null)
            {
                MessageBox.Show("Dirección inválida", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!regex.IsMatch(textEmail.Text))
            {

                MessageBox.Show("Correo Electrónico inválido", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textCantidaLeche.Text == null)
            {

                MessageBox.Show("Cantidad de Leche incorrecta", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("El cliente se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
