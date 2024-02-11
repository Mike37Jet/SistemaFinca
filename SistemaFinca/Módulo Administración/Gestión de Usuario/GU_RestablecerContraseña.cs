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
    public partial class FormGU_RestablecerContraseña : Form
    {
        public FormGU_RestablecerContraseña()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La contraseña se ha actualizado exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
