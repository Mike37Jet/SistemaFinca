using Npgsql;
using StackExchange.Redis;
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
using System.Windows.Forms.DataVisualization.Charting;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Drawing.Imaging;
using DinkToPdf;


namespace SistemaFinca
{
    public partial class SubFormVConsultar : Form
    {
        private String idnota = "";
        private String idcliente = "";
        public SubFormVConsultar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        internal void llenarDatos(string cantidad, string vTotal, string fecha, string idnota)
        {
            labelCantidad.Text = cantidad;
            labelVTotal.Text = vTotal;
            labelFechaEmision.Text = fecha;
            labelIdNota.Text = idnota;
            labelIdNota1.Text = idnota;
            throw new NotImplementedException();
        }

        internal void llenarDatos1(string nombres, string apellidos, string telefono, string correo, string direccion)
        {
            labelNombre.Text = nombres + " " + apellidos;
            labelTelefono.Text = telefono;
            labelEmail.Text = correo;
            labelDireccion.Text = direccion;
            throw new NotImplementedException();
        }
    }

}
