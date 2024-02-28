namespace SistemaFinca
{
    partial class FormGU_Consultar
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
            label1 = new Label();
            txtNumeroC = new TextBox();
            label2 = new Label();
            button2 = new Button();
            labelContrasena = new Label();
            labelNombreU = new Label();
            labeltele = new Label();
            labelCorreo = new Label();
            label4 = new Label();
            labelNombre = new Label();
            labelApellido = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 27);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Consultar usuario";
            // 
            // txtNumeroC
            // 
            txtNumeroC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumeroC.Cursor = Cursors.IBeam;
            txtNumeroC.Location = new Point(333, 110);
            txtNumeroC.Margin = new Padding(3, 2, 3, 2);
            txtNumeroC.Name = "txtNumeroC";
            txtNumeroC.Size = new Size(244, 23);
            txtNumeroC.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 78);
            label2.Name = "label2";
            label2.Size = new Size(223, 20);
            label2.TabIndex = 3;
            label2.Text = "Número de Cédula de identidad";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(408, 160);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 30);
            button2.TabIndex = 10;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelContrasena
            // 
            labelContrasena.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelContrasena.AutoSize = true;
            labelContrasena.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContrasena.Location = new Point(407, 228);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(83, 20);
            labelContrasena.TabIndex = 11;
            labelContrasena.Text = "Contraseña:";
            labelContrasena.Click += label3_Click;
            // 
            // labelNombreU
            // 
            labelNombreU.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNombreU.AutoSize = true;
            labelNombreU.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombreU.Location = new Point(351, 282);
            labelNombreU.Name = "labelNombreU";
            labelNombreU.Size = new Size(139, 20);
            labelNombreU.TabIndex = 12;
            labelNombreU.Text = "Nombre de Usuario:";
            // 
            // labeltele
            // 
            labeltele.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labeltele.AutoSize = true;
            labeltele.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltele.Location = new Point(344, 419);
            labeltele.Name = "labeltele";
            labeltele.Size = new Size(146, 20);
            labeltele.TabIndex = 13;
            labeltele.Text = "Número de Teléfono:";
            // 
            // labelCorreo
            // 
            labelCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCorreo.Location = new Point(358, 469);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(132, 20);
            labelCorreo.TabIndex = 14;
            labelCorreo.Text = "Correo Electrónico:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(286, 439);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 15;
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(420, 327);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(70, 20);
            labelNombre.TabIndex = 16;
            labelNombre.Text = "Nombres:";
            labelNombre.Click += label3_Click_1;
            // 
            // labelApellido
            // 
            labelApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApellido.Location = new Point(418, 375);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(72, 20);
            labelApellido.TabIndex = 17;
            labelApellido.Text = "Apellidos:";
            // 
            // FormGU_Consultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(label4);
            Controls.Add(labelCorreo);
            Controls.Add(labeltele);
            Controls.Add(labelNombreU);
            Controls.Add(labelContrasena);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(txtNumeroC);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGU_Consultar";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeroC;
        private Label label2;
        private Button button2;
        private Label labelContrasena;
        private Label labelNombreU;
        private Label labeltele;
        private Label labelCorreo;
        private Label label4;
        private Label labelNombre;
        private Label labelApellido;
    }
}