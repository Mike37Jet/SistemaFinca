using System;
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
    public partial class FormC_DarDeAlta : Form
    {
        public FormC_DarDeAlta()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El cliente se ha dado de alta exitosamente.", "Cambio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    
    }
}
