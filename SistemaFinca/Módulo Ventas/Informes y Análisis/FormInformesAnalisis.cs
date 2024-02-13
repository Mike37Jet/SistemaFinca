using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaFinca
{
    public partial class FormInformesAnalisis : Form
    {
        public FormInformesAnalisis()
        {
            InitializeComponent();
        }
        private Form formularioActivo = null;

        private void abrirFormulariosHijos(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(formularioHijo);
            panelFormularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void InicializarGraficoLineas(Chart chart)
        {
            Series series = new Series("Ganancias Mensuales");
            series.ChartType = SeriesChartType.FastLine;
            series.Palette = ChartColorPalette.Excel;

            series.Points.AddXY("Enero", 522);
            series.Points.AddXY("Febrero", 221);
            series.Points.AddXY("Marzo", 150);
            series.Points.AddXY("Abril", 205);
            series.Points.AddXY("Mayo", 133);
            series.Points.AddXY("Junio", 205);
            series.Points.AddXY("Julio", 128);
            series.Points.AddXY("Agosto", 260);
            series.Points.AddXY("Septiembre", 177);
            series.Points.AddXY("Octubre", 212);
            series.Points.AddXY("Noviembre", 191);
            series.Points.AddXY("Diciembre", 149);


            ChartArea chartArea = new ChartArea();
            Legend legend = new Legend();

            chartArea.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea);

            chart.Dock = DockStyle.Fill;
            chart.Name = "chartBarras";
            chart.TabIndex = 0;
            chart.Text = "Barras";
            chart.Series.Add(series);

            legend.Name = "Legend1";
            legend.Docking = Docking.Bottom;
            chart.Legends.Add(legend);

            chartArea.BackColor = SystemColors.Control;
            chart.BackColor = SystemColors.Control;
            legend.BackColor = SystemColors.Control;

            series.IsValueShownAsLabel = true;

            //chart.Size = new Size(367, 261);

            // Asegurarse de que el gráfico esté en la parte superior
            chart.BringToFront();


        }


        private void buttonRegistrar_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo = null;
            }
            else
            {
                this.Close();
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
