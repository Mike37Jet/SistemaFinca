namespace SistemaFinca
{
    partial class FormVC_Consultar : Form
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
            label11 = new Label();
            label9 = new Label();
            label5 = new Label();
            btnConsultar = new Button();
            label3 = new Label();
            txtFechaEmision = new TextBox();
            label18 = new Label();
            label1 = new Label();
            txtFechaFinalizacion = new TextBox();
            label2 = new Label();
            txtFechaInicio = new TextBox();
            label6 = new Label();
            txtCedula = new TextBox();
            label13 = new Label();
            label4 = new Label();
            txtCantidadLeche = new TextBox();
            label14 = new Label();
            txtCantidadRetirada = new TextBox();
            label16 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            SuspendLayout();
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(361, 259);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 93;
            label11.Text = "Teléfono";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(356, 225);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 91;
            label9.Text = "Apellidos";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(358, 191);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 86;
            label5.Text = "Nombres";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.Font = new Font("Segoe UI", 11.25F);
            btnConsultar.Location = new Point(510, 113);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(103, 27);
            btnConsultar.TabIndex = 84;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(304, 327);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 83;
            label3.Text = "Fecha de emisión";
            // 
            // txtFechaEmision
            // 
            txtFechaEmision.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFechaEmision.Cursor = Cursors.IBeam;
            txtFechaEmision.Font = new Font("Segoe UI", 11.25F);
            txtFechaEmision.Location = new Point(438, 324);
            txtFechaEmision.Margin = new Padding(3, 2, 3, 2);
            txtFechaEmision.Name = "txtFechaEmision";
            txtFechaEmision.ReadOnly = true;
            txtFechaEmision.Size = new Size(178, 27);
            txtFechaEmision.TabIndex = 82;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(324, 34);
            label18.Name = "label18";
            label18.Size = new Size(265, 32);
            label18.TabIndex = 81;
            label18.Text = "Consultar Contrato";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(280, 395);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 105;
            label1.Text = "Fecha de finalización";
            // 
            // txtFechaFinalizacion
            // 
            txtFechaFinalizacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFechaFinalizacion.Cursor = Cursors.IBeam;
            txtFechaFinalizacion.Font = new Font("Segoe UI", 11.25F);
            txtFechaFinalizacion.Location = new Point(438, 392);
            txtFechaFinalizacion.Margin = new Padding(3, 2, 3, 2);
            txtFechaFinalizacion.Name = "txtFechaFinalizacion";
            txtFechaFinalizacion.ReadOnly = true;
            txtFechaFinalizacion.Size = new Size(178, 27);
            txtFechaFinalizacion.TabIndex = 104;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(320, 361);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 107;
            label2.Text = "Fecha de inicio";
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFechaInicio.Cursor = Cursors.IBeam;
            txtFechaInicio.Font = new Font("Segoe UI", 11.25F);
            txtFechaInicio.Location = new Point(438, 358);
            txtFechaInicio.Margin = new Padding(3, 2, 3, 2);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.ReadOnly = true;
            txtFechaInicio.Size = new Size(178, 27);
            txtFechaInicio.TabIndex = 106;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(341, 82);
            label6.Name = "label6";
            label6.Size = new Size(221, 20);
            label6.TabIndex = 108;
            label6.Text = "Número de cédula de identidad";
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCedula.Cursor = Cursors.IBeam;
            txtCedula.Font = new Font("Segoe UI", 11.25F);
            txtCedula.Location = new Point(308, 113);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(178, 27);
            txtCedula.TabIndex = 109;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F);
            label13.Location = new Point(296, 293);
            label13.Name = "label13";
            label13.Size = new Size(132, 20);
            label13.TabIndex = 110;
            label13.Text = "Correo electrónico";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(278, 429);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 113;
            label4.Text = "Cantidad de leche (L)";
            // 
            // txtCantidadLeche
            // 
            txtCantidadLeche.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantidadLeche.Cursor = Cursors.IBeam;
            txtCantidadLeche.Font = new Font("Segoe UI", 11.25F);
            txtCantidadLeche.Location = new Point(438, 426);
            txtCantidadLeche.Margin = new Padding(3, 2, 3, 2);
            txtCantidadLeche.Name = "txtCantidadLeche";
            txtCantidadLeche.ReadOnly = true;
            txtCantidadLeche.Size = new Size(178, 27);
            txtCantidadLeche.TabIndex = 112;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F);
            label14.Location = new Point(282, 463);
            label14.Name = "label14";
            label14.Size = new Size(146, 20);
            label14.TabIndex = 119;
            label14.Text = "Cantidad retirada (L)";
            // 
            // txtCantidadRetirada
            // 
            txtCantidadRetirada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantidadRetirada.Cursor = Cursors.IBeam;
            txtCantidadRetirada.Font = new Font("Segoe UI", 11.25F);
            txtCantidadRetirada.Location = new Point(438, 460);
            txtCantidadRetirada.Margin = new Padding(3, 2, 3, 2);
            txtCantidadRetirada.Name = "txtCantidadRetirada";
            txtCantidadRetirada.ReadOnly = true;
            txtCantidadRetirada.Size = new Size(178, 27);
            txtCantidadRetirada.TabIndex = 118;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(383, 156);
            label16.Name = "label16";
            label16.Size = new Size(139, 20);
            label16.TabIndex = 120;
            label16.Text = "Datos del contrato";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Font = new Font("Segoe UI", 11.25F);
            txtCorreo.Location = new Point(438, 290);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ReadOnly = true;
            txtCorreo.Size = new Size(178, 27);
            txtCorreo.TabIndex = 121;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Font = new Font("Segoe UI", 11.25F);
            txtTelefono.Location = new Point(438, 256);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(178, 27);
            txtTelefono.TabIndex = 122;
            // 
            // txtApellidos
            // 
            txtApellidos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtApellidos.Cursor = Cursors.IBeam;
            txtApellidos.Font = new Font("Segoe UI", 11.25F);
            txtApellidos.Location = new Point(438, 222);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.ReadOnly = true;
            txtApellidos.Size = new Size(178, 27);
            txtApellidos.TabIndex = 123;
            // 
            // txtNombres
            // 
            txtNombres.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNombres.Cursor = Cursors.IBeam;
            txtNombres.Font = new Font("Segoe UI", 11.25F);
            txtNombres.Location = new Point(438, 188);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.ReadOnly = true;
            txtNombres.Size = new Size(178, 27);
            txtNombres.TabIndex = 124;
            // 
            // FormVC_Consultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(txtNombres);
            Controls.Add(txtApellidos);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(txtCantidadRetirada);
            Controls.Add(label4);
            Controls.Add(txtCantidadLeche);
            Controls.Add(label13);
            Controls.Add(txtCedula);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtFechaInicio);
            Controls.Add(label1);
            Controls.Add(txtFechaFinalizacion);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(btnConsultar);
            Controls.Add(label3);
            Controls.Add(txtFechaEmision);
            Controls.Add(label18);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVC_Consultar";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label15;
        private Button button1;
        private Label label11;
        private Label label9;
        private DataGridView dataGridNotaVenta;
        private Label label5;
        private Button btnConsultar;
        private Label label3;
        private TextBox txtFechaEmision;
        private Label label18;
        private Label label1;
        private TextBox txtFechaFinalizacion;
        private Label label2;
        private TextBox txtFechaInicio;
        private Label label6;
        private TextBox txtCedula;
        private Label label13;
        private Label label4;
        private TextBox txtCantidadLeche;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label14;
        private TextBox txtCantidadRetirada;
        private Label label16;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtApellidos;
        private TextBox txtNombres;
    }
}