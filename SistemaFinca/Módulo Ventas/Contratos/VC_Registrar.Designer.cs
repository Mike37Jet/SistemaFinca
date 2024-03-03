namespace SistemaFinca
{
    partial class FormVC_Registrar : Form
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
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
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
            label7 = new Label();
            label13 = new Label();
            label4 = new Label();
            txtCantidadLeche = new TextBox();
            labelNombres = new Label();
            labelApellidos = new Label();
            labelTelefono = new Label();
            labelCorreo = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.Font = new Font("Segoe UI", 11.25F);
            btnRegistrar.Location = new Point(404, 453);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 36);
            btnRegistrar.TabIndex = 103;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F);
            label12.Location = new Point(417, 215);
            label12.Name = "label12";
            label12.Size = new Size(15, 20);
            label12.TabIndex = 94;
            label12.Text = "-";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(236, 215);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 93;
            label11.Text = "Teléfono";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(417, 188);
            label10.Name = "label10";
            label10.Size = new Size(15, 20);
            label10.TabIndex = 92;
            label10.Text = "-";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(236, 187);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 91;
            label9.Text = "Apellidos";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(417, 161);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 90;
            label8.Text = "-";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(236, 159);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 86;
            label5.Text = "Nombres";
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
            label3.Location = new Point(308, 285);
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
            txtFechaEmision.Location = new Point(438, 282);
            txtFechaEmision.Margin = new Padding(3, 2, 3, 2);
            txtFechaEmision.Name = "txtFechaEmision";
            txtFechaEmision.Size = new Size(178, 27);
            txtFechaEmision.TabIndex = 82;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(383, 38);
            label18.Name = "label18";
            label18.Size = new Size(130, 32);
            label18.TabIndex = 81;
            label18.Text = "Contrato";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(284, 355);
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
            txtFechaFinalizacion.Location = new Point(438, 352);
            txtFechaFinalizacion.Margin = new Padding(3, 2, 3, 2);
            txtFechaFinalizacion.Name = "txtFechaFinalizacion";
            txtFechaFinalizacion.Size = new Size(178, 27);
            txtFechaFinalizacion.TabIndex = 104;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(324, 320);
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
            txtFechaInicio.Location = new Point(438, 317);
            txtFechaInicio.Margin = new Padding(3, 2, 3, 2);
            txtFechaInicio.Name = "txtFechaInicio";
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
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(417, 242);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 111;
            label7.Text = "-";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F);
            label13.Location = new Point(236, 243);
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
            label4.Location = new Point(303, 390);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 113;
            label4.Text = "Cantidad de leche";
            // 
            // txtCantidadLeche
            // 
            txtCantidadLeche.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantidadLeche.Cursor = Cursors.IBeam;
            txtCantidadLeche.Font = new Font("Segoe UI", 11.25F);
            txtCantidadLeche.Location = new Point(438, 387);
            txtCantidadLeche.Margin = new Padding(3, 2, 3, 2);
            txtCantidadLeche.Name = "txtCantidadLeche";
            txtCantidadLeche.Size = new Size(178, 27);
            txtCantidadLeche.TabIndex = 112;
            // 
            // labelNombres
            // 
            labelNombres.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNombres.AutoSize = true;
            labelNombres.Font = new Font("Segoe UI", 11.25F);
            labelNombres.Location = new Point(438, 161);
            labelNombres.Name = "labelNombres";
            labelNombres.Size = new Size(0, 20);
            labelNombres.TabIndex = 114;
            // 
            // labelApellidos
            // 
            labelApellidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelApellidos.AutoSize = true;
            labelApellidos.Font = new Font("Segoe UI", 11.25F);
            labelApellidos.Location = new Point(438, 188);
            labelApellidos.Name = "labelApellidos";
            labelApellidos.Size = new Size(0, 20);
            labelApellidos.TabIndex = 115;
            // 
            // labelTelefono
            // 
            labelTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI", 11.25F);
            labelTelefono.Location = new Point(438, 215);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(0, 20);
            labelTelefono.TabIndex = 116;
            // 
            // labelCorreo
            // 
            labelCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Segoe UI", 11.25F);
            labelCorreo.Location = new Point(438, 242);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(0, 20);
            labelCorreo.TabIndex = 117;
            // 
            // FormVC_Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(labelCorreo);
            Controls.Add(labelTelefono);
            Controls.Add(labelApellidos);
            Controls.Add(labelNombres);
            Controls.Add(label4);
            Controls.Add(txtCantidadLeche);
            Controls.Add(label7);
            Controls.Add(label13);
            Controls.Add(txtCedula);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtFechaInicio);
            Controls.Add(label1);
            Controls.Add(txtFechaFinalizacion);
            Controls.Add(btnRegistrar);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(txtFechaEmision);
            Controls.Add(label18);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVC_Registrar";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnRegistrar;
        private Label label15;
        private Button button1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView dataGridNotaVenta;
        private Label label5;
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
        private Label label7;
        private Label label13;
        private Label label4;
        private TextBox txtCantidadLeche;
        private Label labelNombres;
        private Label labelApellidos;
        private Label labelTelefono;
        private Label labelCorreo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}