using System.Runtime.InteropServices;
namespace SistemaFinca
{

    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();


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
            login.DrawLine(lapiz, 310, 100, 717, 100);
            login.DrawLine(lapiz, 310, 165, 717, 165);
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "USUARIO")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.LightGray;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                textUsuario.Text = "USUARIO";
                textUsuario.ForeColor = Color.DimGray;
            }
        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "CONTRASEÑA")
            {
                textContraseña.Text = "";
                textContraseña.ForeColor = Color.LightGray;
            }
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (textContraseña.Text == "")
            {
                textContraseña.PasswordChar = '\0';
                textContraseña.Text = "CONTRASEÑA";
                textContraseña.ForeColor = Color.DimGray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendeMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "admin" && textContraseña.Text == "admin")
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta. Por favor, inténtalo de nuevo.", "Ingreso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            textContraseña.PasswordChar = '*';
        }
    }
}
