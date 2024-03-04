namespace SistemaFinca
{
    partial class FormVR_Registrar : Form
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
            btnRegistrar = new Button();
            btnBuscar = new Button();
            label3 = new Label();
            txtFechaEmision = new TextBox();
            label18 = new Label();
            label1 = new Label();
            txtFechaFinalizacion = new TextBox();
            label2 = new Label();
            txtFechaInicio = new TextBox();
            label6 = new Label();
            txtCedula = new TextBox();
            label4 = new Label();
            txtCantidadLeche = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCantidadRetiro = new TextBox();
            label9 = new Label();
            txtCantidadRetirada = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.Font = new Font("Segoe UI", 11.25F);
            btnRegistrar.Location = new Point(404, 381);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 36);
            btnRegistrar.TabIndex = 103;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Font = new Font("Segoe UI", 11.25F);
            btnBuscar.Location = new Point(510, 113);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(103, 27);
            btnBuscar.TabIndex = 84;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(128, 191);
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
            txtFechaEmision.Location = new Point(258, 188);
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
            label18.Location = new Point(324, 35);
            label18.Name = "label18";
            label18.Size = new Size(225, 32);
            label18.TabIndex = 81;
            label18.Text = "Registrar Retiro";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(104, 259);
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
            txtFechaFinalizacion.Location = new Point(258, 256);
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
            label2.Location = new Point(144, 225);
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
            txtFechaInicio.Location = new Point(258, 222);
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
            label6.Location = new Point(308, 82);
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
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(102, 293);
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
            txtCantidadLeche.Location = new Point(258, 290);
            txtCantidadLeche.Margin = new Padding(3, 2, 3, 2);
            txtCantidadLeche.Name = "txtCantidadLeche";
            txtCantidadLeche.ReadOnly = true;
            txtCantidadLeche.Size = new Size(178, 27);
            txtCantidadLeche.TabIndex = 112;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(162, 156);
            label5.Name = "label5";
            label5.Size = new Size(233, 22);
            label5.TabIndex = 114;
            label5.Text = "Información del contrato";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(508, 156);
            label7.Name = "label7";
            label7.Size = new Size(206, 22);
            label7.TabIndex = 115;
            label7.Text = "Información del retiro";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(514, 191);
            label8.Name = "label8";
            label8.Size = new Size(206, 20);
            label8.TabIndex = 117;
            label8.Text = "Cantidad de leche a retirar (L)";
            // 
            // txtCantidadRetiro
            // 
            txtCantidadRetiro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantidadRetiro.Cursor = Cursors.IBeam;
            txtCantidadRetiro.Font = new Font("Segoe UI", 11.25F);
            txtCantidadRetiro.Location = new Point(521, 219);
            txtCantidadRetiro.Margin = new Padding(3, 2, 3, 2);
            txtCantidadRetiro.Name = "txtCantidadRetiro";
            txtCantidadRetiro.Size = new Size(178, 27);
            txtCantidadRetiro.TabIndex = 116;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(46, 327);
            label9.Name = "label9";
            label9.Size = new Size(206, 20);
            label9.TabIndex = 119;
            label9.Text = "Cantidad de leche retirada (L)";
            // 
            // txtCantidadRetirada
            // 
            txtCantidadRetirada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantidadRetirada.Cursor = Cursors.IBeam;
            txtCantidadRetirada.Font = new Font("Segoe UI", 11.25F);
            txtCantidadRetirada.Location = new Point(258, 324);
            txtCantidadRetirada.Margin = new Padding(3, 2, 3, 2);
            txtCantidadRetirada.Name = "txtCantidadRetirada";
            txtCantidadRetirada.ReadOnly = true;
            txtCantidadRetirada.Size = new Size(178, 27);
            txtCantidadRetirada.TabIndex = 118;
            // 
            // FormVR_Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(label9);
            Controls.Add(txtCantidadRetirada);
            Controls.Add(label8);
            Controls.Add(txtCantidadRetiro);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCantidadLeche);
            Controls.Add(txtCedula);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtFechaInicio);
            Controls.Add(label1);
            Controls.Add(txtFechaFinalizacion);
            Controls.Add(btnRegistrar);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(txtFechaEmision);
            Controls.Add(label18);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVR_Registrar";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnRegistrar;
        private Label label15;
        private Button button1;
        private DataGridView dataGridNotaVenta;
        private Button btnBuscar;
        private Label label3;
        private TextBox txtFechaEmision;
        private Label label18;
        private Label label1;
        private TextBox txtFechaFinalizacion;
        private Label label2;
        private TextBox txtFechaInicio;
        private Label label6;
        private TextBox txtCedula;
        private Label label4;
        private TextBox txtCantidadLeche;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox txtCantidadRetiro;
        private Label label9;
        private TextBox txtCantidadRetirada;
    }
}