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
    public partial class FormAB_Consultar : Form
    {
        public FormAB_Consultar()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El alimento se ha consultado exitosamente.", "Consulta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
