namespace SistemaFinca.Módulo_Clientes.Gestión_Clientes
{
    partial class SubFormActualizar
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
            label5 = new Label();
            label4 = new Label();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            buttonActualizar = new Button();
            label3 = new Label();
            txtTele = new TextBox();
            labelCliente = new Label();
            label2 = new Label();
            txtCorreo = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(34, 185);
            label6.Name = "label6";
            label6.Size = new Size(160, 21);
            label6.TabIndex = 32;
            label6.Text = "Dirección domiciliaria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(291, 59);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 31;
            label5.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(34, 59);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 30;
            label4.Text = "Nombres";
            // 
            // txtDireccion
            // 
            txtDireccion.Cursor = Cursors.IBeam;
            txtDireccion.Font = new Font("Segoe UI", 11.25F);
            txtDireccion.Location = new Point(34, 208);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(501, 27);
            txtDireccion.TabIndex = 29;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Font = new Font("Segoe UI", 11.25F);
            txtApellido.Location = new Point(291, 88);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(244, 27);
            txtApellido.TabIndex = 28;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Segoe UI", 11.25F);
            txtNombre.Location = new Point(34, 88);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(244, 27);
            txtNombre.TabIndex = 27;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonActualizar.Location = new Point(34, 332);
            buttonActualizar.Margin = new Padding(3, 2, 3, 2);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(124, 46);
            buttonActualizar.TabIndex = 26;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(34, 124);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 25;
            label3.Text = "Teléfono";
            // 
            // txtTele
            // 
            txtTele.Cursor = Cursors.IBeam;
            txtTele.Font = new Font("Segoe UI", 11.25F);
            txtTele.Location = new Point(34, 147);
            txtTele.Margin = new Padding(3, 2, 3, 2);
            txtTele.Name = "txtTele";
            txtTele.Size = new Size(244, 27);
            txtTele.TabIndex = 24;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Segoe UI", 12F);
            labelCliente.Location = new Point(34, 24);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(235, 21);
            labelCliente.TabIndex = 38;
            labelCliente.Text = "Número de cédula de identidad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 246);
            label2.Name = "label2";
            label2.Size = new Size(225, 21);
            label2.TabIndex = 40;
            label2.Text = "Dirección de correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Font = new Font("Segoe UI", 11.25F);
            txtCorreo.Location = new Point(34, 269);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(501, 27);
            txtCorreo.TabIndex = 39;
            // 
            // SubFormActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 480);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(labelCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(buttonActualizar);
            Controls.Add(label3);
            Controls.Add(txtTele);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SubFormActualizar";
            Text = "SubFormActualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button buttonActualizar;
        private Label label3;
        private TextBox txtTele;
        private Label labelCliente;
        private Label label2;
        private TextBox txtCorreo;
    }
}