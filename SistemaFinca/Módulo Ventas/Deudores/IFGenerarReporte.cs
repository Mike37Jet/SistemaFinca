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
            if (!fechaEsValida(txtAnio.Text))
            {
                MessageBox.Show("Año no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //SELECT * FROM contrato WHERE EXTRACT(YEAR FROM fechainicio) = 2024 AND EXTRACT(MONTH FROM fechainicio) = 5
            panelReporte.Visible = true;
            MessageBox.Show("Reporte mensual de ventas generado exitosamente", "Consulta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool fechaEsValida(string fecha)
        {
            Regex regex = new Regex(@"^20\d{2}$");
            return regex.IsMatch(fecha);
        }
    }
}
