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
    public partial class FormPL_Registrar : Form
    {
        public FormPL_Registrar()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cantidad de leche se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
