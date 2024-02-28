namespace SistemaFinca.Módulo_Clientes.Gestión_Clientes
{
    partial class SubFormGUActualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            Contraseña = new Label();
            txtCorreo = new TextBox();
            txtNombreU = new TextBox();
            buttonActualizar = new Button();
            label3 = new Label();
            txtContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTele = new TextBox();
            radioA = new RadioButton();
            radioD = new RadioButton();
            label7 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(24, 114);
            label6.Name = "label6";
            label6.Size = new Size(228, 21);
            label6.TabIndex = 32;
            label6.Text = "Dirección de correo electrónico:";
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Location = new Point(24, 82);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(0, 15);
            Contraseña.TabIndex = 30;
            Contraseña.Click += label4_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Location = new Point(24, 137);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(501, 23);
            txtCorreo.TabIndex = 29;
            // 
            // txtNombreU
            // 
            txtNombreU.Cursor = Cursors.IBeam;
            txtNombreU.Location = new Point(24, 57);
            txtNombreU.Margin = new Padding(3, 2, 3, 2);
            txtNombreU.Name = "txtNombreU";
            txtNombreU.Size = new Size(244, 23);
            txtNombreU.TabIndex = 27;
            txtNombreU.TextChanged += textBox3_TextChanged;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(240, 325);
            buttonActualizar.Margin = new Padding(3, 2, 3, 2);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(82, 22);
            buttonActualizar.TabIndex = 26;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(379, 33);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 25;
            label3.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Cursor = Cursors.IBeam;
            txtContrasena.Location = new Point(379, 57);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(244, 23);
            txtContrasena.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 56);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 199);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 33);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 41;
            label4.Text = "Nombre Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 193);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 42;
            label5.Text = "Telefono:";
            // 
            // txtTele
            // 
            txtTele.Cursor = Cursors.IBeam;
            txtTele.Location = new Point(24, 216);
            txtTele.Margin = new Padding(3, 2, 3, 2);
            txtTele.Name = "txtTele";
            txtTele.Size = new Size(244, 23);
            txtTele.TabIndex = 43;
            // 
            // radioA
            // 
            radioA.AutoSize = true;
            radioA.Font = new Font("Segoe UI", 12F);
            radioA.Location = new Point(579, 227);
            radioA.Margin = new Padding(3, 2, 3, 2);
            radioA.Name = "radioA";
            radioA.Size = new Size(71, 25);
            radioA.TabIndex = 44;
            radioA.Text = "Activo";
            radioA.UseVisualStyleBackColor = true;
            radioA.CheckedChanged += radioA_CheckedChanged;
            // 
            // radioD
            // 
            radioD.AutoSize = true;
            radioD.Font = new Font("Segoe UI", 12F);
            radioD.Location = new Point(579, 265);
            radioD.Margin = new Padding(3, 2, 3, 2);
            radioD.Name = "radioD";
            radioD.Size = new Size(82, 25);
            radioD.TabIndex = 45;
            radioD.TabStop = true;
            radioD.Text = "Inactivo";
            radioD.UseVisualStyleBackColor = true;
            radioD.CheckedChanged += radioD_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(591, 193);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 46;
            label7.Text = "Estado:";
            label7.Click += label7_Click;
            // 
            // SubFormGUActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 494);
            Controls.Add(label7);
            Controls.Add(radioD);
            Controls.Add(radioA);
            Controls.Add(txtTele);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(Contraseña);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombreU);
            Controls.Add(buttonActualizar);
            Controls.Add(label3);
            Controls.Add(txtContrasena);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SubFormGUActualizar";
            Text = "SubFormActualizar";
            Load += SubFormGUActualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label Contraseña;
        private TextBox txtCorreo;
        private TextBox txtNombreU;
        private Button buttonActualizar;
        private Label label3;
        private TextBox txtContrasena;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtTele;
        private RadioButton radioA;
        private RadioButton radioD;
        private Label label7;
    }
}