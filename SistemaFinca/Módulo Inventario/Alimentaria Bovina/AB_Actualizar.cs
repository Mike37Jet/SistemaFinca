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
    public partial class FormAB_Actualizar : Form
    {
        public FormAB_Actualizar()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El alimento se ha actualizado exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
