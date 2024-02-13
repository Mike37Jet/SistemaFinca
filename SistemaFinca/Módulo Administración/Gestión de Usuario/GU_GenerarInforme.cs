using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinca
{
    public partial class FormGU_GenerarInforme : Form
    {
        public FormGU_GenerarInforme()
        {
            InitializeComponent();
        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            if (textBoxInforme.Text != "")
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Esta vacío el informe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Imprimir(Object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);

            
                e.Graphics.DrawString(textBoxInforme.Text, font, Brushes.Black, new RectangleF(0, 100, 2000, 200));



        }
    }
}
