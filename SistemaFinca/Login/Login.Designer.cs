namespace SistemaFinca
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            textUsuario = new TextBox();
            textContraseña = new TextBox();
            label1 = new Label();
            button1 = new Button();
            buttonCerrar = new Button();
            buttonMinimizar = new Button();
            buttonMostrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 330);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.FromArgb(15, 15, 15);
            textUsuario.BorderStyle = BorderStyle.None;
            textUsuario.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsuario.ForeColor = Color.Gray;
            textUsuario.Location = new Point(310, 73);
            textUsuario.Margin = new Padding(0);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(418, 26);
            textUsuario.TabIndex = 1;
            textUsuario.Text = "USUARIO";
            textUsuario.Click += textUsuario_Click;
            textUsuario.Enter += textUsuario_Enter;
            textUsuario.KeyPress += textUsuario_KeyPress;
            textUsuario.Leave += textUsuario_Leave;
            // 
            // textContraseña
            // 
            textContraseña.BackColor = Color.FromArgb(15, 15, 15);
            textContraseña.BorderStyle = BorderStyle.None;
            textContraseña.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textContraseña.ForeColor = Color.Gray;
            textContraseña.Location = new Point(310, 137);
            textContraseña.Margin = new Padding(0);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(418, 26);
            textContraseña.TabIndex = 2;
            textContraseña.Text = "CONTRASEÑA";
            textContraseña.Click += textContraseña_Click;
            textContraseña.Enter += textContraseña_Enter;
            textContraseña.KeyPress += textContraseña_KeyPress;
            textContraseña.Leave += textContraseña_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(463, 7);
            label1.Name = "label1";
            label1.Size = new Size(113, 37);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(310, 225);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(418, 40);
            button1.TabIndex = 3;
            button1.Text = "ACCEDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.FlatAppearance.BorderColor = SystemColors.ControlText;
            buttonCerrar.FlatAppearance.BorderSize = 0;
            buttonCerrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCerrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Image = (Image)resources.GetObject("buttonCerrar.Image");
            buttonCerrar.Location = new Point(740, 7);
            buttonCerrar.Margin = new Padding(0);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(31, 25);
            buttonCerrar.TabIndex = 5;
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += button2_Click;
            // 
            // buttonMinimizar
            // 
            buttonMinimizar.FlatAppearance.BorderColor = SystemColors.ControlText;
            buttonMinimizar.FlatAppearance.BorderSize = 0;
            buttonMinimizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMinimizar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMinimizar.FlatStyle = FlatStyle.Flat;
            buttonMinimizar.Image = (Image)resources.GetObject("buttonMinimizar.Image");
            buttonMinimizar.Location = new Point(702, 11);
            buttonMinimizar.Margin = new Padding(3, 2, 3, 2);
            buttonMinimizar.Name = "buttonMinimizar";
            buttonMinimizar.Size = new Size(26, 22);
            buttonMinimizar.TabIndex = 4;
            buttonMinimizar.UseVisualStyleBackColor = true;
            buttonMinimizar.Click += button3_Click;
            // 
            // buttonMostrar
            // 
            buttonMostrar.FlatAppearance.BorderSize = 0;
            buttonMostrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMostrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMostrar.FlatStyle = FlatStyle.Flat;
            buttonMostrar.Image = (Image)resources.GetObject("buttonMostrar.Image");
            buttonMostrar.Location = new Point(690, 137);
            buttonMostrar.Margin = new Padding(0);
            buttonMostrar.Name = "buttonMostrar";
            buttonMostrar.Size = new Size(38, 26);
            buttonMostrar.TabIndex = 8;
            buttonMostrar.UseVisualStyleBackColor = true;
            buttonMostrar.Click += buttonMostrar1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(buttonMostrar);
            Controls.Add(buttonMinimizar);
            Controls.Add(buttonCerrar);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textContraseña);
            Controls.Add(textUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A-Boost";
            Paint += FormLogin_Paint;
            MouseDown += FormLogin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textUsuario;
        private TextBox textContraseña;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox3;
        private Button buttonCerrar;
        private Button buttonMinimizar;
        private Button buttonMostrar;
    }
}
