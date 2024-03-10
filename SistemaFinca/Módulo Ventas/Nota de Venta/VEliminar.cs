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
    public partial class FormVEliminar : Form
    {
        private String idnotaventa = "";
        private String idcontrato = "";

        public FormVEliminar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!FormGU_Registrar.CedulaEsValida(txtCedula.Text))
            {
                MessageBox.Show("Número de cédula de identidad no válido", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            getNotas();
        }

        private void lstNotasVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                lstNotasVenta.ClearSelection();
                lstNotasVenta.Rows[e.RowIndex].Selected = true;

                this.idnotaventa = lstNotasVenta.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.idcontrato = lstNotasVenta.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.idnotaventa == "")
            {
                MessageBox.Show("Seleccione una nota de venta", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Está seguro de que desea eliminar esta nota de venta?", "Comprobar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
                {
                    try
                    {
                        connection.Open();
                        String commString2 = $"UPDATE contrato SET pagado = false WHERE idcontrato = {this.idcontrato}";
                        NpgsqlCommand comm2 = new NpgsqlCommand(commString2, connection);
                        int resultado = comm2.ExecuteNonQuery();

                        String commString = $"UPDATE retiro SET pagado = false WHERE idretiro IN (SELECT idretiro FROM nota_venta_retiros WHERE idnota = {this.idnotaventa})";
                        NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                        int resultado2 = comm.ExecuteNonQuery();

                        String commEliminar = $"DELETE FROM nota_venta WHERE idnota = {this.idnotaventa}";
                        NpgsqlCommand comm3 = new NpgsqlCommand(commEliminar, connection);
                        int resultado3 = comm3.ExecuteNonQuery();

                        if (resultado >= 0 && resultado2 >= 0 && resultado3 >= 0)
                        {
                            MessageBox.Show("Eliminación de nota de venta exitosa", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (lstNotasVenta.Rows.Count == 1)
                            {
                                lstNotasVenta.Rows.Clear();
                                return;
                            }
                            lstNotasVenta.Rows.Clear();
                            getNotas();
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
        }

        private void getNotas()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
            {
                try
                {
                    connection.Open();
                    String commExisteString = $"SELECT cedulacliente FROM cliente WHERE cedulacliente = '{txtCedula.Text}'";
                    NpgsqlCommand commExiste = new NpgsqlCommand(commExisteString, connection);
                    using (NpgsqlDataReader reader = commExiste.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Cliente no registrado", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    String commNotas = $"SELECT cantidadleche, monto, fechaemision, idnota, idcontrato FROM nota_venta WHERE cedulacliente = '{txtCedula.Text}'";
                    NpgsqlCommand comm = new NpgsqlCommand(commNotas, connection);
                    using (NpgsqlDataReader reader = comm.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No existen notas de venta asociadas al cliente", "Vuelve a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        lstNotasVenta.Rows.Clear();
                        while (reader.Read())
                        {
                            String cantidad = reader.GetInt32(0).ToString();
                            String monto = reader.GetDecimal(1).ToString();
                            String fechaemision = reader.GetDateTime(2).ToString("dd/MM/yyyy");
                            String notaventa = reader.GetInt32(3).ToString();
                            String idcontrato = reader.GetInt32(4).ToString();
                            lstNotasVenta.Rows.Add(cantidad, monto, fechaemision, notaventa, idcontrato);
                            lstNotasVenta.ClearSelection();
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
    }
}
