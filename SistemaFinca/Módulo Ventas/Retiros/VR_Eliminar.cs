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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.idretiro == "")
            {
                MessageBox.Show("Seleccione un retiro", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Está seguro de que desea eliminar este retiro?", "Comprobar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(FormLogin.connectionString))
                {
                    try
                    {
                        connection.Open();
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
                            if (lstRetiros.Rows.Count == 1)
                            {
                                lstRetiros.Rows.Clear();
                                return;
                            }
                            lstRetiros.Rows.Clear();
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
            lstRetiros.Rows.Clear();
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

                            string cantidad = reader.GetInt32(0).ToString();
                            string fecha = reader.GetDateTime(1).ToString();
                            string estado = reader.GetBoolean(2) ? "Pagado" : "No pagado";
                            string idRetiro = reader.GetInt32(3).ToString();

                            // Agrega una nueva fila al DataGridView con los valores actuales
                            lstRetiros.Rows.Add(cantidad, fecha, estado, idRetiro);
                            lstRetiros.ClearSelection();
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

        private void lstRetiros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                lstRetiros.ClearSelection();
                lstRetiros.Rows[e.RowIndex].Selected = true;

                this.idretiro = lstRetiros.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
        

   
    
}
