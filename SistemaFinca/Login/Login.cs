using System.Data;
using System.Runtime.InteropServices;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace SistemaFinca
{

    public partial class FormLogin : Form
    {
        public static String user = "postgres";
        public static String password = "eeee2003";
        public static String connectionString = $"Server=localhost;Port=5432;User Id={user};Password={password};Database=aboost";

        public FormLogin()
        {
            InitializeComponent();
            buttonMostrar.TabStop = false;
            buttonMinimizar.TabStop = false;
            buttonCerrar.TabStop = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendeMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormLogin_Paint(object sender, PaintEventArgs e)
        {
            Graphics login;
            login = CreateGraphics();
            Pen lapiz = new Pen(Color.Gray);
            login.DrawLine(lapiz, 310, 100, 728, 100);
            login.DrawLine(lapiz, 310, 165, 728, 165);
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (labelUsuario.Visible == true)
            {
                textUsuario.SelectionStart = 0;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (labelUsuario.Visible == false && textUsuario.Text == "")
            {
                labelUsuario.Visible = true;
            }
        }

        private void textContrase�a_Enter(object sender, EventArgs e)
        {
            if (labelContrase�a.Visible == true)
            {
                textContrase�a.SelectionStart = 0;
            }

        }

        private void textContrase�a_Leave(object sender, EventArgs e)
        {
            if (labelContrase�a.Visible == false && textContrase�a.Text == "")
            {
                textContrase�a.PasswordChar = '\0';
                labelContrase�a.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonCerrar.FlatAppearance.BorderSize = 0;
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendeMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text.Length < 5 || textUsuario.Text.Length > 15 || textContrase�a.Text.Length < 8 || textContrase�a.Text.Length > 20)
            {
                MessageBox.Show("Usuario o contrase�a incorrecta. Por favor, int�ntalo de nuevo.", "Ingreso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        String commString = $"SELECT rol, contrasena, estado, usuario FROM usuario WHERE usuario = '{textUsuario.Text}'";
                        NpgsqlCommand comm = new NpgsqlCommand(commString, connection);
                        NpgsqlDataReader reader = comm.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Usuario o contrase�a incorrecta. Por favor, int�ntalo de nuevo.", "Ingreso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Read();
                        char rol = reader.GetChar(0);
                        String contrasenaValida = reader.GetString(1);
                        char estado = reader.GetChar(2);
                        String usuario = reader.GetString(3);

                        if (estado == 'I')
                        {
                            MessageBox.Show("Usuario desactivado temporalmente", "Ingreso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (textContrase�a.Text == contrasenaValida)
                        {
                            reader.Close();
                            String commString2 = $"SELECT to_char(now()::timestamp(0), 'YYYY-MM-DD HH24:MI:SS')";
                            NpgsqlCommand comm2 = new NpgsqlCommand(commString2, connection);
                            String fechaInicio = comm2.ExecuteScalar().ToString();
                            FormMenu formMenu = new FormMenu(rol, usuario, fechaInicio);
                            formMenu.Show(this);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contrase�a inconrrecta. Por favor, int�ntalo de nuevo.", "Ingreso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textContrase�a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (labelContrase�a.Visible == true)
            {
                labelContrase�a.Visible = false;
                textContrase�a.PasswordChar = '*';
            }


            if (textContrase�a.PasswordChar == '*')
            {
                textContrase�a.PasswordChar = '*';
            }
            else
            {
                textContrase�a.PasswordChar = '\0';
            }
        }

        private void textUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (labelUsuario.Visible == true)
            {
                labelUsuario.Visible = false;
            }
        }

        private void textUsuario_Click(object sender, EventArgs e)
        {
            if (labelUsuario.Visible == true)
            {
                textUsuario.SelectionStart = 0;
            }
        }

        private void textContrase�a_Click(object sender, EventArgs e)
        {
            if (labelContrase�a.Visible == true)
            {
                textContrase�a.SelectionStart = 0;
            }
        }

        private void buttonMostrar1_Click(object sender, EventArgs e)
        {
            if (textContrase�a.PasswordChar == '*')
            {
                textContrase�a.PasswordChar = '\0';
            }
            else if (textContrase�a.Text != "CONTRASE�A")
            {
                textContrase�a.PasswordChar = '*';
            }
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {
            textUsuario.Focus();
        }

        private void labelContrase�a_Click(object sender, EventArgs e)
        {
            textContrase�a.Focus();
        }
    }
}
