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
    public partial class FormVR_Eliminar : Form
    {
        private String idcontrato = "";
        private String idretiro = "";

        public FormVR_Eliminar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.idretiro == "")
            {
                MessageBox.Show("Seleccione un retiro", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show($"{this.idcontrato}, {this.idretiro}", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    String commString2 = $"UPDATE contrato SET cantidadretirada = cantidadretirada - (SELECT cantidadleche " +
                        $"FROM retiro WHERE idretiro = {this.idretiro}) WHERE idcontrato = {this.idcontrato}";
                    NpgsqlCommand comm2 = new NpgsqlCommand(commString2, connection);
                    int resultado = comm2.ExecuteNonQuery();

                    String commString = $"DELETE FROM retiro WHERE idretiro = {this.idretiro}";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado2 = comm.ExecuteNonQuery();
                    if (resultado > 0 && resultado2 > 0)
                    {
                        MessageBox.Show("Retiro eliminado exitosamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.idretiro = "";
                        lstRetiros.Items.Clear();
                        getRetiros();
                        return;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!FormGU_Registrar.CedulaEsValida(txtCedula.Text))
            {
                MessageBox.Show("Número de cédula de identidad no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            getRetiros();
        }

        private void getRetiros()
        {
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
                    String commString = $"SELECT idcontrato FROM contrato WHERE cedulacliente = '{txtCedula.Text}'" +
                        $" AND pagado = false OR (cantidadleche != cantidadretirada AND pagado = true)";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No existe un contrato asociado al cliente", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        this.idcontrato = reader.GetInt32(0).ToString();
                    }
                    String commString2 = $"SELECT cantidadleche, fechaemision, pagado, idretiro FROM retiro WHERE idcontrato = {this.idcontrato}";
                    NpgsqlCommand comm2 = new NpgsqlCommand(commString2, connection);
                    using (NpgsqlDataReader reader = comm2.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No existen retiros", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            item.SubItems.Add(reader.GetInt32(3).ToString());
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

        private void lstRetiros_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lstRetiros.SelectedItems.Count > 0)
            {
                this.idretiro = lstRetiros.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
