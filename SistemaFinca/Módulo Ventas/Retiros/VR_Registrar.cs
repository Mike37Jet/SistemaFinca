using Microsoft.Identity.Client.NativeInterop;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinca
{
    public partial class FormVR_Registrar : Form
    {
        private String idcontrato = "";
        private Boolean contratoEstado;

        public FormVR_Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.idcontrato == "")
            {
                MessageBox.Show("Número de cédula de identidad no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!cantidadEsValida(txtCantidadRetiro.Text) || Int32.Parse(txtCantidadRetiro.Text) > (Int32.Parse(txtCantidadLeche.Text) - Int32.Parse(txtCantidadRetirada.Text)))
            {
                MessageBox.Show("Cantidad de leche no válida", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = this.contratoEstado ? $"INSERT INTO retiro(idcontrato, cantidadleche, fechaemision, pagado) VALUES(" +
                        $"{this.idcontrato}, {txtCantidadRetiro.Text}, current_date, true)" : $"INSERT INTO retiro(idcontrato, cantidadleche, fechaemision) VALUES(" +
                        $"{this.idcontrato}, {txtCantidadRetiro.Text}, current_date)";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();
                    if (resultado <= 0)
                    {
                        return;
                    }
                    String commString2 = $"UPDATE contrato SET cantidadretirada = cantidadretirada + {txtCantidadRetiro.Text} " +
                        $"WHERE idcontrato = {this.idcontrato}";
                    NpgsqlCommand comm2 = new NpgsqlCommand(commString2, connection);
                    int resultado2 = comm2.ExecuteNonQuery();

                    if (contratoEstado)
                    {
                        String commSpecialString = $"INSERT INTO nota_venta_retiros(idnota, idretiro) VALUES(" +
                            $"(SELECT idnota FROM nota_venta WHERE idcontrato = {this.idcontrato} ORDER BY idnota DESC LIMIT 1), (SELECT idretiro FROM retiro ORDER BY idretiro DESC LIMIT 1))";
                        NpgsqlCommand commSpecial = new NpgsqlCommand(commSpecialString, connection);
                        commSpecial.ExecuteNonQuery();
                    }
                    if (resultado2 > 0)
                    {
                        MessageBox.Show("Retiro registrado exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vaciarCampos();
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

        private void vaciarCampos()
        {
            this.idcontrato = "";
            txtCedula.Text = "";
            txtCantidadLeche.Text = "";
            txtCantidadRetirada.Text = "";
            txtCantidadRetiro.Text = "";
            txtFechaEmision.Text = "";
            txtFechaFinalizacion.Text = "";
            txtFechaInicio.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!FormGU_Registrar.CedulaEsValida(txtCedula.Text))
            {
                MessageBox.Show("Número de cédula de identidad no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString = $"SELECT * FROM cliente WHERE cedulacliente = '{txtCedula.Text}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Cliente no registrado", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                    }
                    String commString = $"SELECT fechaemision, fechainicio, fechafin, cantidadleche, cantidadretirada, idcontrato, pagado FROM contrato WHERE cedulacliente = '{txtCedula.Text}'" +
                        $" AND (pagado = false OR (cantidadleche != cantidadretirada AND pagado = true))";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No existe un contrato asociado al cliente", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        txtFechaEmision.Text = reader.GetDateTime(0).ToString("dd/MM/yyyy");
                        txtFechaInicio.Text = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                        txtFechaFinalizacion.Text = reader.GetDateTime(2).ToString("dd/MM/yyyy");
                        txtCantidadLeche.Text = reader.GetInt32(3).ToString();
                        txtCantidadRetirada.Text = reader.GetInt32(4).ToString();
                        this.idcontrato = reader.GetInt32(5).ToString();
                        this.contratoEstado = reader.GetBoolean(6);
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

        public static bool fechaEsValida(string fecha)
        {
            Regex regex = new Regex(@"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{2}$");
            return regex.IsMatch(fecha);
        }

        public static bool cantidadEsValida(string cantidad)
        {
            Regex regex = new Regex(@"^[1-9]\d{0,3}$");
            return regex.IsMatch(cantidad);
        }

        public static bool fechaEsPosterior(string fechaInicioStr, string fechaFinStr)
        {
            DateTime fechaInicio, fechaFin;

            if (DateTime.TryParseExact(fechaInicioStr, "dd/MM/yy", null, System.Globalization.DateTimeStyles.None, out fechaInicio) &&
                DateTime.TryParseExact(fechaFinStr, "dd/MM/yy", null, System.Globalization.DateTimeStyles.None, out fechaFin))
            {
                return fechaFin > fechaInicio;
            }
            return false;
        }

        public static string ConvertirFecha(string fechaOriginalStr)
        {
            DateTime fechaOriginal;

            if (DateTime.TryParseExact(fechaOriginalStr, "dd/MM/yy", null, System.Globalization.DateTimeStyles.None, out fechaOriginal))
            {
                return fechaOriginal.ToString("yyyy-MM-dd");
            }
            return fechaOriginalStr;
        }
    }
}
