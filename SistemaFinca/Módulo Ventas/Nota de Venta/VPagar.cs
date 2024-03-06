using Npgsql;
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
using static System.Net.Mime.MediaTypeNames;

namespace SistemaFinca
{
    public partial class FormVNotaDeVenta : Form
    {
        private String cedulacliente, idcontrato;
        private decimal monto;
        private int cantidadLeche;

        public FormVNotaDeVenta(string cedulacliente, string idcontrato)
        {
            InitializeComponent();
            this.cedulacliente = cedulacliente;
            this.idcontrato = idcontrato;
            this.monto = 0;
            this.cantidadLeche = 0;
            getDatosCliente();
        }

        private void getDatosCliente()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString = $"SELECT nombres, apellidos, correo, telefono " +
                        $"FROM cliente WHERE cedulacliente = '{this.cedulacliente}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        reader.Read();
                        txtNombres.Text = reader.GetString(0);
                        txtApellidos.Text = reader.GetString(1);
                        txtCorreo.Text = reader.GetString(2);
                        txtTelefono.Text = reader.GetString(3);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void radRetiros_CheckedChanged(object sender, EventArgs e)
        {
            if (radRetiros.Checked)
            {
                getRetiros();
                radContrato.Checked = false;
            }
        }

        private bool getRetiros()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT cantidadleche FROM retiro WHERE idcontrato = {this.idcontrato}" +
                        $" AND pagado = false";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No existen retiros", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        this.cantidadLeche = 0;
                        this.monto = 0;
                        while (reader.Read())
                        {
                            cantidadLeche += reader.GetInt32(0);
                        }
                    }
                    String commStringPrecio = $"SELECT valorparametro FROM parametro WHERE idparametro = 1";
                    NpgsqlCommand comm2 = new NpgsqlCommand(commStringPrecio, connection);
                    txtPrecioLitro.Text = comm2.ExecuteScalar().ToString();
                    txtCantidadLeche.Text = cantidadLeche.ToString();
                    monto = cantidadLeche * Decimal.Parse(txtPrecioLitro.Text);
                    txtTotal.Text = monto.ToString();
                    mostrarDescripcion();
                    return true;
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
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

        private void mostrarDescripcion()
        {
            labelPrecioLitro.Visible = true;
            labelCantidadLeche.Visible = true;
            labelTotal.Visible = true;
            txtTotal.Visible = true;
            txtCantidadLeche.Visible = true;
            txtPrecioLitro.Visible = true;
            btnRegistrar.Visible = true;
            labelFechaEmision.Visible = true;
            txtFechaEmision.Visible = true;
        }

        private void radContrato_CheckedChanged(object sender, EventArgs e)
        {
            if (radContrato.Checked)
            {
                getContrato();
                radRetiros.Checked = false;
            }
        }

        private void getContrato()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commString = $"SELECT cantidadleche FROM contrato WHERE idcontrato = {this.idcontrato}";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    this.cantidadLeche = Convert.ToInt32(comm.ExecuteScalar());
                    String commStringPrecio = $"SELECT valorparametro FROM parametro WHERE idparametro = 1";
                    NpgsqlCommand comm2 = new NpgsqlCommand(commStringPrecio, connection);
                    txtPrecioLitro.Text = comm2.ExecuteScalar().ToString();

                    String commString2 = $"SELECT cantidadleche FROM retiro WHERE idcontrato = {this.idcontrato}" +
                        $" AND pagado = true";
                    NpgsqlCommand comm3 = new NpgsqlCommand(commString2, connection);
                    using (NpgsqlDataReader reader = comm3.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cantidadLeche -= reader.GetInt32(0);
                            }
                        }
                    }

                    txtCantidadLeche.Text = cantidadLeche.ToString();
                    monto = cantidadLeche * Decimal.Parse(txtPrecioLitro.Text);
                    txtTotal.Text = monto.ToString();
                    mostrarDescripcion();
                    return;
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

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (!FormVC_Registrar.fechaEsValida(txtFechaEmision.Text))
            {
                MessageBox.Show("Fecha de emisión no válida", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    MessageBox.Show($"{this.idcontrato}", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Open();
                    String commString = $"INSERT INTO nota_venta(idcontrato, cedulacliente, monto, cantidadleche, fechaemision) " +
                        $"VALUES({this.idcontrato}, '{this.cedulacliente}', {this.monto.ToString().Replace(',', '.')}, {this.cantidadLeche}, '{FormVC_Registrar.ConvertirFecha(txtFechaEmision.Text)}')";
                    NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                    int resultado = comm.ExecuteNonQuery();
                    String commString2 = $"UPDATE retiro SET pagado = true WHERE idcontrato = {this.idcontrato}";
                    NpgsqlCommand comm2 = new NpgsqlCommand(commString2, connection);
                    int resultado2 = comm2.ExecuteNonQuery();
                    String getIdNota = $"SELECT idnota FROM nota_venta ORDER BY idnota DESC LIMIT 1";
                    NpgsqlCommand comm3 = new NpgsqlCommand(getIdNota, connection);
                    String idnota = comm3.ExecuteScalar().ToString();
                    String setRetiros = $"INSERT INTO nota_venta_retiros SELECT {idnota}, idretiro FROM retiro WHERE idcontrato = {this.idcontrato}";
                    NpgsqlCommand comm4 = new NpgsqlCommand(setRetiros, connection);
                    comm4.ExecuteNonQuery();

                    if (radContrato.Checked)
                    {
                        String commString5 = $"UPDATE contrato SET pagado = true WHERE idcontrato = {this.idcontrato}";
                        NpgsqlCommand comm5 = new NpgsqlCommand(commString5, connection);
                        int resultado3 = comm5.ExecuteNonQuery();
                        if (resultado >= 0 && resultado2 >= 0 && resultado3 >= 0)
                        {
                            MessageBox.Show("La nota de venta fue registrada exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            regresar();
                            return;
                        }
                    }

                    String compareCantidad = $"SELECT (cantidadleche = cantidadretirada) FROM contrato WHERE idcontrato = {this.idcontrato}";
                    NpgsqlCommand commCompare = new NpgsqlCommand(compareCantidad, connection);
                    Boolean cantidadesSonIguales = Convert.ToBoolean(commCompare.ExecuteScalar());
                    if (cantidadesSonIguales)
                    {
                        String commString6 = $"UPDATE contrato SET pagado = true WHERE idcontrato = {this.idcontrato}";
                        NpgsqlCommand comm6 = new NpgsqlCommand(commString6, connection);
                        comm6.ExecuteNonQuery();
                    }

                    if (resultado > 0 && resultado2 > 0)
                    {
                        MessageBox.Show("La nota de venta fue registrada exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        regresar();
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

        private void regresar()
        {
            this.Close();
        }
    }
}
