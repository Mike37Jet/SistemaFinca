using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFinca.Módulo_Clientes.Gestión_Clientes;

namespace SistemaFinca
{
    public partial class FormGB_Consultar : Form
    {
        public FormGB_Consultar()
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
      

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new SubFormGB_Consultar());
        }
    }
}
