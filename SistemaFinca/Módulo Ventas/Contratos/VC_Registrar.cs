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
    public partial class FormVC_Registrar : Form
    {
        private String cedulaCliente = "";

        public FormVC_Registrar()
        {
            InitializeComponent();
            panelRegistrarContrato.Visible = false;
            txtFechaEmision.ReadOnly = true;
            txtFechaInicio.ReadOnly = true;
            txtFechaFinalizacion.ReadOnly = true;
        }

        private void vaciarCampos()
        {
            this.cedulaCliente = "";
            txtCedula.Text = "";
            txtCantidadLeche.Text = "";
            txtFechaEmision.Text = "";
            txtFechaFinalizacion.Text = "";
            txtFechaInicio.Text = "";
            labelTelefono.Text = "";
            labelNombres.Text = "";
            labelApellidos.Text = "";
            labelCorreo.Text = "";
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
                    String commExisteString = $"SELECT cedulacliente, nombres, apellidos, telefono, correo, estado FROM cliente WHERE cedulacliente = '{txtCedula.Text}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Cliente no registrado", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        if (reader.GetChar(5) == 'I')
                        {
                            MessageBox.Show("El cliente está dado de baja", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        this.cedulaCliente = reader.GetString(0);
                        labelNombres.Text = reader.GetString(1);
                        labelApellidos.Text = reader.GetString(2);
                        labelTelefono.Text = reader.GetString(3);
                        labelCorreo.Text = reader.GetString(4);
                        DateTime fechaActual = DateTime.Now;
                        DateTime soloFecha = fechaActual.Date;
                        txtFechaEmision.Text = soloFecha.ToString("dd/MM/yyyy");


                        panelRegistrarContrato.Visible = true;
                        txtCedula.Text = "";
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

            if (DateTime.TryParseExact(fechaInicioStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaInicio) &&
                DateTime.TryParseExact(fechaFinStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaFin))
            {
                return fechaFin > fechaInicio;
            }
            return false;
        }

        public static bool fechaEsIgual(string fechaInicioStr, string fechaFinStr)
        {
            DateTime fechaInicio, fechaFin;

            if (DateTime.TryParseExact(fechaInicioStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaInicio) &&
                DateTime.TryParseExact(fechaFinStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaFin))
            {
                return fechaFin == fechaInicio;
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

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (this.cedulaCliente == "")
            {
                MessageBox.Show("Número de cédula de identidad no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!fechaEsPosterior(txtFechaEmision.Text, txtFechaInicio.Text) && !fechaEsIgual(txtFechaEmision.Text, txtFechaInicio.Text))
            {
                MessageBox.Show("La fecha de inicio debe ser igual o posterior a la fecha de emisión", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!fechaEsPosterior(txtFechaInicio.Text, txtFechaFinalizacion.Text) )
            {
                MessageBox.Show("La fecha de finalización debe ser posterior a la fecha de inicio", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!cantidadEsValida(txtCantidadLeche.Text))
            {
                MessageBox.Show("Cantidad de leche no válida", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString = $"SELECT * FROM contrato WHERE cedulacliente = '{this.cedulaCliente}' AND " +
                        $"(pagado = false OR (cantidadleche != cantidadretirada AND pagado = true))";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("El cliente ya tiene asociado un contrato", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    String commString = $"INSERT INTO contrato(cedulacliente, cantidadleche, fechainicio, fechafin, fechaemision) " +
                        $"VALUES({this.cedulaCliente}, {txtCantidadLeche.Text}, '{txtFechaInicio.Text}', " +
                        $"'{txtFechaFinalizacion.Text}','{txtFechaEmision.Text}')";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Contrato registrado satisfactoriamente", "Contrato registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panelRegistrarContrato.Visible = false;
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

        private void dateTimeInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimeInicio.Value.Date;
            txtFechaInicio.Text = fechaSeleccionada.ToString("dd/MM/yyyy");
        }

        private void dateTimeFinalizacion_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimeFinalizacion.Value.Date;
            txtFechaFinalizacion.Text = fechaSeleccionada.ToString("dd/MM/yyyy");
          
        }
    }
}
