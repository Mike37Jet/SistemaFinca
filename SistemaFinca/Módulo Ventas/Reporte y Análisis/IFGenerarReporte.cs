using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinca
{
    public partial class FormIFGenerarInforme : Form
    {
        public FormIFGenerarInforme()
        {
            InitializeComponent();
            personalizarDiseño();
            cmbMes.SelectedIndex = 0;
        }

        private void personalizarDiseño()
        {
            panelReporte.Visible = false;
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (!fechaEsValida(txtAnio.Text))
            {
                MessageBox.Show("Año no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT nombres, apellidos, monto, cantidadleche, fechaemision FROM nota_venta N JOIN cliente C ON " +
                        $"(N.cedulacliente = C.cedulacliente) WHERE EXTRACT(YEAR FROM fechaemision) = {txtAnio.Text} AND " +
                        $"EXTRACT(MONTH FROM fechaemision) = {ObtenerNumeroMes(cmbMes.Text)}";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No existen datos en la fecha seleccionada", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        lstNotasVenta.Rows.Clear();
                        while (reader.Read())
                        {
                            String nombres = reader.GetString(0);
                            String apellidos = reader.GetString(1);
                            String monto = reader.GetDecimal(2).ToString();
                            String cantidad = reader.GetInt32(3).ToString();
                            String fecha = reader.GetDateTime(4).ToString();
                            lstNotasVenta.Rows.Add(nombres, apellidos, monto, cantidad, fecha);
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
            //SELECT * FROM nota_venta WHERE EXTRACT(YEAR FROM fechainicio) = 2024 AND EXTRACT(MONTH FROM fechainicio) = 5
            panelReporte.Visible = true;
            MessageBox.Show("Reporte mensual de ventas generado exitosamente", "Consulta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool fechaEsValida(string fecha)
        {
            Regex regex = new Regex(@"^20\d{2}$");
            return regex.IsMatch(fecha);
        }

        private int ObtenerNumeroMes(string nombreMes)
        {
            switch (nombreMes)
            {
                case "Enero":
                    return 1;
                case "Febrero":
                    return 2;
                case "Marzo":
                    return 3;
                case "Abril":
                    return 4;
                case "Mayo":
                    return 5;
                case "Junio":
                    return 6;
                case "Julio":
                    return 7;
                case "Agosto":
                    return 8;
                case "Septiembre":
                    return 9;
                case "Octubre":
                    return 10;
                case "Noviembre":
                    return 11;
                case "Diciembre":
                    return 12;
                default:
                    return 0;
            }
        }

    }
}
