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
    public partial class SubFormActualizar : Form
    {
        
        public SubFormActualizar()
        {
            InitializeComponent();
      
            
        }


        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El cliente se ha actualizado exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
