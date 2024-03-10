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
            label18 = new Label();
            label6 = new Label();
            btnBuscar = new Button();
            txtCedula = new TextBox();
            panelRegistrarContrato = new Panel();
            dateTimeFinalizacion = new DateTimePicker();
            dateTimeInicio = new DateTimePicker();
            label4 = new Label();
            txtCantidadLeche = new TextBox();
            labelCorreo = new Label();
            label13 = new Label();
            label2 = new Label();
            txtFechaInicio = new TextBox();
            label1 = new Label();
            txtFechaFinalizacion = new TextBox();
            btnRegistrar = new Button();
            labelTelefono = new Label();
            label11 = new Label();
            labelApellidos = new Label();
            label9 = new Label();
            labelNombres = new Label();
            label5 = new Label();
            label3 = new Label();
            txtFechaEmision = new TextBox();
            panelRegistrarContrato.SuspendLayout();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(308, 28);
            label18.Name = "label18";
            label18.Size = new Size(261, 32);
            label18.TabIndex = 81;
            label18.Text = "Registrar Contrato";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(308, 72);
            label6.Name = "label6";
            label6.Size = new Size(221, 20);
            label6.TabIndex = 108;
            label6.Text = "Número de cédula de identidad";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Font = new Font("Segoe UI", 11.25F);
            btnBuscar.Location = new Point(506, 103);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(103, 27);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCedula.Cursor = Cursors.IBeam;
            txtCedula.Font = new Font("Segoe UI", 11.25F);
            txtCedula.Location = new Point(308, 103);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(178, 27);
            txtCedula.TabIndex = 1;
            // 
            // panelRegistrarContrato
            // 
            panelRegistrarContrato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRegistrarContrato.Controls.Add(dateTimeFinalizacion);
            panelRegistrarContrato.Controls.Add(dateTimeInicio);
            panelRegistrarContrato.Controls.Add(label4);
            panelRegistrarContrato.Controls.Add(txtCantidadLeche);
            panelRegistrarContrato.Controls.Add(labelCorreo);
            panelRegistrarContrato.Controls.Add(label13);
            panelRegistrarContrato.Controls.Add(label2);
            panelRegistrarContrato.Controls.Add(txtFechaInicio);
            panelRegistrarContrato.Controls.Add(label1);
            panelRegistrarContrato.Controls.Add(txtFechaFinalizacion);
            panelRegistrarContrato.Controls.Add(btnRegistrar);
            panelRegistrarContrato.Controls.Add(labelTelefono);
            panelRegistrarContrato.Controls.Add(label11);
            panelRegistrarContrato.Controls.Add(labelApellidos);
            panelRegistrarContrato.Controls.Add(label9);
            panelRegistrarContrato.Controls.Add(labelNombres);
            panelRegistrarContrato.Controls.Add(label5);
            panelRegistrarContrato.Controls.Add(label3);
            panelRegistrarContrato.Controls.Add(txtFechaEmision);
            panelRegistrarContrato.Location = new Point(0, 151);
            panelRegistrarContrato.Name = "panelRegistrarContrato";
            panelRegistrarContrato.Size = new Size(895, 390);
            panelRegistrarContrato.TabIndex = 110;
            // 
            // dateTimeFinalizacion
            // 
            dateTimeFinalizacion.Location = new Point(633, 221);
            dateTimeFinalizacion.Name = "dateTimeFinalizacion";
            dateTimeFinalizacion.Size = new Size(210, 23);
            dateTimeFinalizacion.TabIndex = 5;
            dateTimeFinalizacion.ValueChanged += dateTimeFinalizacion_ValueChanged;
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Location = new Point(633, 186);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(210, 23);
            dateTimeInicio.TabIndex = 4;
            dateTimeInicio.ValueChanged += dateTimeInicio_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(249, 259);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 134;
            label4.Text = "Cantidad de leche (L)";
            // 
            // txtCantidadLeche
            // 
            txtCantidadLeche.Cursor = Cursors.IBeam;
            txtCantidadLeche.Font = new Font("Segoe UI", 11.25F);
            txtCantidadLeche.Location = new Point(438, 256);
            txtCantidadLeche.Margin = new Padding(3, 2, 3, 2);
            txtCantidadLeche.Name = "txtCantidadLeche";
            txtCantidadLeche.Size = new Size(178, 27);
            txtCantidadLeche.TabIndex = 6;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Segoe UI", 11.25F);
            labelCorreo.Location = new Point(438, 111);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(15, 20);
            labelCorreo.TabIndex = 132;
            labelCorreo.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F);
            label13.Location = new Point(267, 114);
            label13.Name = "label13";
            label13.Size = new Size(132, 20);
            label13.TabIndex = 131;
            label13.Text = "Correo electrónico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(291, 189);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 130;
            label2.Text = "Fecha de inicio";
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Cursor = Cursors.IBeam;
            txtFechaInicio.Font = new Font("Segoe UI", 11.25F);
            txtFechaInicio.Location = new Point(438, 186);
            txtFechaInicio.Margin = new Padding(3, 2, 3, 2);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(178, 27);
            txtFechaInicio.TabIndex = 129;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(251, 224);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 128;
            label1.Text = "Fecha de finalización";
            // 
            // txtFechaFinalizacion
            // 
            txtFechaFinalizacion.Cursor = Cursors.IBeam;
            txtFechaFinalizacion.Font = new Font("Segoe UI", 11.25F);
            txtFechaFinalizacion.Location = new Point(438, 221);
            txtFechaFinalizacion.Margin = new Padding(3, 2, 3, 2);
            txtFechaFinalizacion.Name = "txtFechaFinalizacion";
            txtFechaFinalizacion.Size = new Size(178, 27);
            txtFechaFinalizacion.TabIndex = 127;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(395, 317);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(104, 36);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI", 11.25F);
            labelTelefono.Location = new Point(438, 84);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(15, 20);
            labelTelefono.TabIndex = 125;
            labelTelefono.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(332, 86);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 124;
            label11.Text = "Teléfono";
            // 
            // labelApellidos
            // 
            labelApellidos.AutoSize = true;
            labelApellidos.Font = new Font("Segoe UI", 11.25F);
            labelApellidos.Location = new Point(438, 57);
            labelApellidos.Name = "labelApellidos";
            labelApellidos.Size = new Size(15, 20);
            labelApellidos.TabIndex = 123;
            labelApellidos.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(327, 58);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 122;
            label9.Text = "Apellidos";
            // 
            // labelNombres
            // 
            labelNombres.AutoSize = true;
            labelNombres.Font = new Font("Segoe UI", 11.25F);
            labelNombres.Location = new Point(438, 30);
            labelNombres.Name = "labelNombres";
            labelNombres.Size = new Size(15, 20);
            labelNombres.TabIndex = 121;
            labelNombres.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(329, 30);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 120;
            label5.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(275, 154);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 119;
            label3.Text = "Fecha de emisión";
            // 
            // txtFechaEmision
            // 
            txtFechaEmision.Cursor = Cursors.IBeam;
            txtFechaEmision.Font = new Font("Segoe UI", 11.25F);
            txtFechaEmision.Location = new Point(438, 151);
            txtFechaEmision.Margin = new Padding(3, 2, 3, 2);
            txtFechaEmision.Name = "txtFechaEmision";
            txtFechaEmision.Size = new Size(178, 27);
            txtFechaEmision.TabIndex = 3;
            // 
            // FormVC_Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(panelRegistrarContrato);
            Controls.Add(txtCedula);
            Controls.Add(label6);
            Controls.Add(btnBuscar);
            Controls.Add(label18);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVC_Registrar";
            Text = "Administrador";
            panelRegistrarContrato.ResumeLayout(false);
            panelRegistrarContrato.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label15;
        private Button button1;
        private DataGridView dataGridNotaVenta;
        private Label label18;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnBuscar;
        private TextBox txtCedula;
        private Panel panelRegistrarContrato;
      
        private Label label4;
        private TextBox txtCantidadLeche;
        private Label labelCorreo;
        private Label label13;
        private Label label2;
        private TextBox txtFechaInicio;
        private Label label1;
        private TextBox txtFechaFinalizacion;
        private Button btnRegistrar;
        private Label labelTelefono;
        private Label label11;
        private Label labelApellidos;
        private Label label9;
        private Label labelNombres;
        private Label label5;
        private Label label3;
        private TextBox txtFechaEmision;
        private DateTimePicker dateTimeFinalizacion;
        private DateTimePicker dateTimeInicio;
    }
}