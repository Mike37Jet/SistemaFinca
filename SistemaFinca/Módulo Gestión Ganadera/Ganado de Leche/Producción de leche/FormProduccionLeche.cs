using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows;

using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaFinca
{
    public partial class FormProduccionLeche : Form
    {
        private ToolTip toolTip = new ToolTip();
        private List<int> datosBarras;

        public FormProduccionLeche()
        {
            InitializeComponent();

        }

        private void InicializarGraficoDona(Chart chart)
        {
            Series series = new Series("Producción diaria");
            series.ChartType = SeriesChartType.Doughnut;
            series.Palette = ChartColorPalette.BrightPastel;

            series.Points.AddXY("Lunes", 10);
            series.Points.AddXY("Martes", 20);
            series.Points.AddXY("Miércoles", 15);
            series.Points.AddXY("Jueves", 25);
            series.Points.AddXY("Viernes", 15);
            series.Points.AddXY("Sábado", 25);
            series.Points.AddXY("Domingo", 15);


            ChartArea chartArea = new ChartArea();
            Legend legend = new Legend();

            chartArea.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea);

            chart.Dock = DockStyle.Bottom;
            chart.Name = "chart1";
            chart.TabIndex = 0;
            chart.Text = "chart1";
            chart.Series.Add(series);

            legend.Name = "Legend1";
            legend.Docking = Docking.Bottom;
            chart.Legends.Add(legend);

            chartArea.BackColor = SystemColors.Control;
            chart.BackColor = SystemColors.Control;
            legend.BackColor = SystemColors.Control;

            series.IsValueShownAsLabel = true;

            //chart.Size = new Size(288, 261);

            // Asegurarse de que el gráfico esté en la parte superior
           // chart.BringToFront();


        }

        private void InicializarGraficoBarras(Chart chart)
        {
            Series series = new Series("Producción mensual");
            series.ChartType = SeriesChartType.Bar;
            series.Palette = ChartColorPalette.BrightPastel;

            series.Points.AddXY("Enero", 10);
            series.Points.AddXY("Febrero", 22);
            series.Points.AddXY("Marzo", 15);
            series.Points.AddXY("Abril", 25);
            series.Points.AddXY("Mayo", 13);
            series.Points.AddXY("Junio", 25);
            series.Points.AddXY("Julio", 18);
            series.Points.AddXY("Agosto", 20);
            series.Points.AddXY("Septiembre", 17);
            series.Points.AddXY("Octubre", 22);
            series.Points.AddXY("Noviembre", 11);
            series.Points.AddXY("Diciembre", 19);


            ChartArea chartArea = new ChartArea();
            Legend legend = new Legend();

            chartArea.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea);

            chart.Dock = DockStyle.Bottom;
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
            //chart.BringToFront();


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

        private void buttonRegistrar_Click_1(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormPL_Registrar());
        }



        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormPL_Emitir());
        }






        private void buttonRegistrar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(buttonRegistrar, "Registrar cantidad de leche");
        }

        private void buttonInforme_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(buttonInforme, "Emitir Informe");
        }
    }
}
