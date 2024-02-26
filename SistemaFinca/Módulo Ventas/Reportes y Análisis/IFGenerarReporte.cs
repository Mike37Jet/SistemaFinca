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
    public partial class FormIFGenerarInforme : Form
    {
        public FormIFGenerarInforme()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void personalizarDiseño()
        {
            panelReporte.Visible = false;

        }
    

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            panelReporte.Visible = true;
            MessageBox.Show("Reporte mensual de ventas generado exitosamente", "Consulta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
