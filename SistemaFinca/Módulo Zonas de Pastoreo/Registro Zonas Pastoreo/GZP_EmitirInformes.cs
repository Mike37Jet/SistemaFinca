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
using SistemaFinca.Módulo_Clientes.Gestión_Clientes;

namespace SistemaFinca
{
    public partial class FormGZP_EmitirInformes : Form
    {
        public FormGZP_EmitirInformes()
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
            panelActualizarCliente.Controls.Add(formularioHijo);
            panelActualizarCliente.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }





        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void imprimir(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            if(radioMensual.Checked || radioAnual.Checked || radioResumenHistorico.Checked)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Por favor elija una opción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

  

        private void Imprimir(Object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            if(radioMensual.Checked)
            {
                e.Graphics.DrawString("Informe de Fumigacción y Riego", font, Brushes.Black, new RectangleF(0, 10, 400, 30));
               
            }
            else if (radioAnual.Checked)
            {
                e.Graphics.DrawString("Informe de Arrendamiento", font, Brushes.Black, new RectangleF(0, 10, 400,30));
           
            }
            else if (radioResumenHistorico.Checked) 
            {
                e.Graphics.DrawString("Informe de cantidad de pasto consumido", font, Brushes.Black, new RectangleF(0, 10, 500, 30));
              
            }
            
            
        }

   
    }
}
