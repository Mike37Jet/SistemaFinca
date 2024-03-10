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
            btnBuscar = new Button();
            label18 = new Label();
            label6 = new Label();
            txtCedula = new TextBox();
            panelDatosRetirar = new Panel();
            textCantidadFaltante = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtCantidadRetirada = new TextBox();
            label8 = new Label();
            txtCantidadRetiro = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCantidadLeche = new TextBox();
            label2 = new Label();
            txtFechaInicio = new TextBox();
            label1 = new Label();
            txtFechaFinalizacion = new TextBox();
            btnRegistrar = new Button();
            label3 = new Label();
            txtFechaEmision = new TextBox();
            panelDatosRetirar.SuspendLayout();
            SuspendLayout();
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
            // panelDatosRetirar
            // 
            panelDatosRetirar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDatosRetirar.Controls.Add(textCantidadFaltante);
            panelDatosRetirar.Controls.Add(label10);
            panelDatosRetirar.Controls.Add(label9);
            panelDatosRetirar.Controls.Add(txtCantidadRetirada);
            panelDatosRetirar.Controls.Add(label8);
            panelDatosRetirar.Controls.Add(txtCantidadRetiro);
            panelDatosRetirar.Controls.Add(label7);
            panelDatosRetirar.Controls.Add(label5);
            panelDatosRetirar.Controls.Add(label4);
            panelDatosRetirar.Controls.Add(txtCantidadLeche);
            panelDatosRetirar.Controls.Add(label2);
            panelDatosRetirar.Controls.Add(txtFechaInicio);
            panelDatosRetirar.Controls.Add(label1);
            panelDatosRetirar.Controls.Add(txtFechaFinalizacion);
            panelDatosRetirar.Controls.Add(btnRegistrar);
            panelDatosRetirar.Controls.Add(label3);
            panelDatosRetirar.Controls.Add(txtFechaEmision);
            panelDatosRetirar.Location = new Point(-1, 158);
            panelDatosRetirar.Name = "panelDatosRetirar";
            panelDatosRetirar.Size = new Size(897, 383);
            panelDatosRetirar.TabIndex = 110;
            // 
            // textCantidadFaltante
            // 
            textCantidadFaltante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textCantidadFaltante.BorderStyle = BorderStyle.None;
            textCantidadFaltante.Cursor = Cursors.IBeam;
            textCantidadFaltante.Font = new Font("Segoe UI", 11.25F);
            textCantidadFaltante.Location = new Point(287, 245);
            textCantidadFaltante.Margin = new Padding(3, 2, 3, 2);
            textCantidadFaltante.Name = "textCantidadFaltante";
            textCantidadFaltante.ReadOnly = true;
            textCantidadFaltante.Size = new Size(178, 20);
            textCantidadFaltante.TabIndex = 138;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(75, 245);
            label10.Name = "label10";
            label10.Size = new Size(208, 20);
            label10.TabIndex = 137;
            label10.Text = "Cantidad de leche faltante (L):";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(75, 210);
            label9.Name = "label9";
            label9.Size = new Size(209, 20);
            label9.TabIndex = 136;
            label9.Text = "Cantidad de leche retirada (L):";
            // 
            // txtCantidadRetirada
            // 
            txtCantidadRetirada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantidadRetirada.BorderStyle = BorderStyle.None;
            txtCantidadRetirada.Cursor = Cursors.IBeam;
            txtCantidadRetirada.Font = new Font("Segoe UI", 11.25F);
            txtCantidadRetirada.Location = new Point(287, 210);
            txtCantidadRetirada.Margin = new Padding(3, 2, 3, 2);
            txtCantidadRetirada.Name = "txtCantidadRetirada";
            txtCantidadRetirada.ReadOnly = true;
            txtCantidadRetirada.Size = new Size(178, 20);
            txtCantidadRetirada.TabIndex = 135;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(537, 74);
            label8.Name = "label8";
            label8.Size = new Size(206, 20);
            label8.TabIndex = 134;
            label8.Text = "Cantidad de leche a retirar (L)";
            // 
            // txtCantidadRetiro
            // 
            txtCantidadRetiro.Cursor = Cursors.IBeam;
            txtCantidadRetiro.Font = new Font("Segoe UI", 11.25F);
            txtCantidadRetiro.Location = new Point(550, 102);
            txtCantidadRetiro.Margin = new Padding(3, 2, 3, 2);
            txtCantidadRetiro.Name = "txtCantidadRetiro";
            txtCantidadRetiro.Size = new Size(178, 27);
            txtCantidadRetiro.TabIndex = 133;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(537, 39);
            label7.Name = "label7";
            label7.Size = new Size(206, 22);
            label7.TabIndex = 132;
            label7.Text = "Información del retiro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(191, 39);
            label5.Name = "label5";
            label5.Size = new Size(233, 22);
            label5.TabIndex = 131;
            label5.Text = "Información del contrato";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(94, 176);
            label4.Name = "label4";
            label4.Size = new Size(190, 20);
            label4.TabIndex = 130;
            label4.Text = "Cantidad de leche Total (L):";
            // 
            // txtCantidadLeche
            // 
            txtCantidadLeche.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantidadLeche.BorderStyle = BorderStyle.None;
            txtCantidadLeche.Cursor = Cursors.IBeam;
            txtCantidadLeche.Font = new Font("Segoe UI", 11.25F);
            txtCantidadLeche.Location = new Point(287, 176);
            txtCantidadLeche.Margin = new Padding(3, 2, 3, 2);
            txtCantidadLeche.Name = "txtCantidadLeche";
            txtCantidadLeche.ReadOnly = true;
            txtCantidadLeche.Size = new Size(178, 20);
            txtCantidadLeche.TabIndex = 129;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(173, 108);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 128;
            label2.Text = "Fecha de inicio:";
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFechaInicio.BorderStyle = BorderStyle.None;
            txtFechaInicio.Cursor = Cursors.IBeam;
            txtFechaInicio.Font = new Font("Segoe UI", 11.25F);
            txtFechaInicio.Location = new Point(287, 108);
            txtFechaInicio.Margin = new Padding(3, 2, 3, 2);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.ReadOnly = true;
            txtFechaInicio.Size = new Size(178, 20);
            txtFechaInicio.TabIndex = 127;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(133, 142);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 126;
            label1.Text = "Fecha de finalización:";
            // 
            // txtFechaFinalizacion
            // 
            txtFechaFinalizacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFechaFinalizacion.BorderStyle = BorderStyle.None;
            txtFechaFinalizacion.Cursor = Cursors.IBeam;
            txtFechaFinalizacion.Font = new Font("Segoe UI", 11.25F);
            txtFechaFinalizacion.Location = new Point(287, 142);
            txtFechaFinalizacion.Margin = new Padding(3, 2, 3, 2);
            txtFechaFinalizacion.Name = "txtFechaFinalizacion";
            txtFechaFinalizacion.ReadOnly = true;
            txtFechaFinalizacion.Size = new Size(178, 20);
            txtFechaFinalizacion.TabIndex = 125;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.Font = new Font("Segoe UI", 11.25F);
            btnRegistrar.Location = new Point(406, 310);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 36);
            btnRegistrar.TabIndex = 124;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(157, 74);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 123;
            label3.Text = "Fecha de emisión:";
            // 
            // txtFechaEmision
            // 
            txtFechaEmision.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFechaEmision.BorderStyle = BorderStyle.None;
            txtFechaEmision.Cursor = Cursors.IBeam;
            txtFechaEmision.Font = new Font("Segoe UI", 11.25F);
            txtFechaEmision.Location = new Point(287, 74);
            txtFechaEmision.Margin = new Padding(3, 2, 3, 2);
            txtFechaEmision.Name = "txtFechaEmision";
            txtFechaEmision.ReadOnly = true;
            txtFechaEmision.Size = new Size(178, 20);
            txtFechaEmision.TabIndex = 122;
            // 
            // FormVR_Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(panelDatosRetirar);
            Controls.Add(txtCedula);
            Controls.Add(label6);
            Controls.Add(btnBuscar);
            Controls.Add(label18);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVR_Registrar";
            Text = "Administrador";
            panelDatosRetirar.ResumeLayout(false);
            panelDatosRetirar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label15;
        private Button button1;
        private DataGridView dataGridNotaVenta;
        private Button btnBuscar;
        private Label label18;
        private Label label6;
        private TextBox txtCedula;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panelDatosRetirar;
        private TextBox textCantidadFaltante;
        private Label label10;
        private Label label9;
        private TextBox txtCantidadRetirada;
        private Label label8;
        private TextBox txtCantidadRetiro;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox txtCantidadLeche;
        private Label label2;
        private TextBox txtFechaInicio;
        private Label label1;
        private TextBox txtFechaFinalizacion;
        private Button btnRegistrar;
        private Label label3;
        private TextBox txtFechaEmision;
    }
}