using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinca.Módulo_Clientes.Gestión_Clientes
{
    public partial class SubFormGB_Actualizar : Form
    {
        public SubFormGB_Actualizar()
        {
            InitializeComponent();
        }


        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los datos del bovino se han actualizado exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
