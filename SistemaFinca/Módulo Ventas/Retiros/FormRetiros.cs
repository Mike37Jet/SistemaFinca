﻿using Npgsql;
using System;
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
    public partial class FormRetiros : Form
    {
        public FormRetiros()
        {
            InitializeComponent();
            lstRetiros.Items.Clear();
            getRetiros();
        }

        private void getRetiros()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT cantidadleche, fechaemision, pagado FROM retiro";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return;
                        }
                        while (reader.Read())
                        {
                            String cantidad = reader.GetInt32(0).ToString();
                            String fecha = reader.GetDateTime(1).ToString();
                            String estado = reader.GetBoolean(2) ? "Pagado" : "No pagado";
                            ListViewItem item = new ListViewItem(cantidad);
                            item.SubItems.Add(fecha);
                            item.SubItems.Add(estado);
                            lstRetiros.Items.Add(item);
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
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


        private void panelFormularioHijo_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            lstRetiros.Items.Clear();
            getRetiros();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormVR_Registrar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormVR_Eliminar());
        }
    }
}
