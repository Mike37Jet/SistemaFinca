﻿using System;
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
    public partial class FormMB_Eliminar : Form
    {
        public FormMB_Eliminar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El medicamento se ha eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
