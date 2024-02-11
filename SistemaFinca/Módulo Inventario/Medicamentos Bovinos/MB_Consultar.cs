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
    public partial class FormMB_Consultar : Form
    {
        public FormMB_Consultar()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El medicamento se ha consultado exitosamente.", "Consulta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
