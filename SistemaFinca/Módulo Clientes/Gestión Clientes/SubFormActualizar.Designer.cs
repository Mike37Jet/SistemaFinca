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
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(34, 163);
            label6.Name = "label6";
            label6.Size = new Size(160, 21);
            label6.TabIndex = 32;
            label6.Text = "Dirección domiciliaria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(377, 83);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 31;
            label5.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(34, 83);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 30;
            label4.Text = "Nombres";
            // 
            // txtDireccion
            // 
            txtDireccion.Cursor = Cursors.IBeam;
            txtDireccion.Location = new Point(34, 186);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(501, 23);
            txtDireccion.TabIndex = 29;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(377, 112);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(244, 23);
            txtApellido.TabIndex = 28;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(34, 112);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(244, 23);
            txtNombre.TabIndex = 27;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(347, 359);
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
            label3.Location = new Point(377, 9);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 25;
            label3.Text = "Teléfono";
            // 
            // txtTele
            // 
            txtTele.Cursor = Cursors.IBeam;
            txtTele.Location = new Point(377, 41);
            txtTele.Margin = new Padding(3, 2, 3, 2);
            txtTele.Name = "txtTele";
            txtTele.Size = new Size(244, 23);
            txtTele.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 38;
            label1.Text = "Cliente:";
            // 
            // SubFormActualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 480);
            Controls.Add(label1);
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
        private Label label1;
    }
}