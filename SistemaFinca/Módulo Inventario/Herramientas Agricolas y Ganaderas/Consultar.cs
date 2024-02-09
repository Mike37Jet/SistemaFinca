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
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La herramienta se ha consultado exitosamente.", "Consulta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
