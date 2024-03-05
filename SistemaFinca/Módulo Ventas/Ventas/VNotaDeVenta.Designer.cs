namespace SistemaFinca
{
    partial class FormVNotaDeVenta
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
            panel1 = new Panel();
            txtTotal = new TextBox();
            txtPrecioLitro = new TextBox();
            txtCantidadLeche = new TextBox();
            labelTotal = new Label();
            labelPrecioLitro = new Label();
            labelCantidadLeche = new Label();
            btnRegistrar = new Button();
            label3 = new Label();
            label2 = new Label();
            radContrato = new RadioButton();
            radRetiros = new RadioButton();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtCorreo = new TextBox();
            label1 = new Label();
            label11 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            label18 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(txtPrecioLitro);
            panel1.Controls.Add(txtCantidadLeche);
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(labelPrecioLitro);
            panel1.Controls.Add(labelCantidadLeche);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(radContrato);
            panel1.Controls.Add(radRetiros);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(txtApellidos);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label18);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 541);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtTotal
            // 
            txtTotal.Cursor = Cursors.IBeam;
            txtTotal.Font = new Font("Segoe UI", 11.25F);
            txtTotal.Location = new Point(450, 423);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(119, 27);
            txtTotal.TabIndex = 133;
            txtTotal.Visible = false;
            // 
            // txtPrecioLitro
            // 
            txtPrecioLitro.Cursor = Cursors.IBeam;
            txtPrecioLitro.Font = new Font("Segoe UI", 11.25F);
            txtPrecioLitro.Location = new Point(450, 388);
            txtPrecioLitro.Margin = new Padding(3, 2, 3, 2);
            txtPrecioLitro.Name = "txtPrecioLitro";
            txtPrecioLitro.ReadOnly = true;
            txtPrecioLitro.Size = new Size(119, 27);
            txtPrecioLitro.TabIndex = 132;
            txtPrecioLitro.Visible = false;
            // 
            // txtCantidadLeche
            // 
            txtCantidadLeche.Cursor = Cursors.IBeam;
            txtCantidadLeche.Font = new Font("Segoe UI", 11.25F);
            txtCantidadLeche.Location = new Point(450, 353);
            txtCantidadLeche.Margin = new Padding(3, 2, 3, 2);
            txtCantidadLeche.Name = "txtCantidadLeche";
            txtCantidadLeche.ReadOnly = true;
            txtCantidadLeche.Size = new Size(119, 27);
            txtCantidadLeche.TabIndex = 131;
            txtCantidadLeche.Visible = false;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(358, 423);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(67, 20);
            labelTotal.TabIndex = 130;
            labelTotal.Text = "Total ($):";
            labelTotal.Visible = false;
            // 
            // labelPrecioLitro
            // 
            labelPrecioLitro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPrecioLitro.AutoSize = true;
            labelPrecioLitro.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPrecioLitro.Location = new Point(240, 391);
            labelPrecioLitro.Name = "labelPrecioLitro";
            labelPrecioLitro.Size = new Size(185, 20);
            labelPrecioLitro.TabIndex = 129;
            labelPrecioLitro.Text = "Precio por litro de leche ($):";
            labelPrecioLitro.Visible = false;
            // 
            // labelCantidadLeche
            // 
            labelCantidadLeche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCantidadLeche.AutoSize = true;
            labelCantidadLeche.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCantidadLeche.Location = new Point(277, 360);
            labelCantidadLeche.Name = "labelCantidadLeche";
            labelCantidadLeche.Size = new Size(148, 20);
            labelCantidadLeche.TabIndex = 128;
            labelCantidadLeche.Text = "Cantidad de leche (L):";
            labelCantidadLeche.Visible = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(396, 480);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(104, 31);
            btnRegistrar.TabIndex = 127;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Visible = false;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(386, 320);
            label3.Name = "label3";
            label3.Size = new Size(119, 22);
            label3.TabIndex = 88;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(407, 252);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 87;
            label2.Text = "Pago por:";
            // 
            // radContrato
            // 
            radContrato.AutoSize = true;
            radContrato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radContrato.Location = new Point(462, 280);
            radContrato.Name = "radContrato";
            radContrato.Size = new Size(177, 25);
            radContrato.TabIndex = 86;
            radContrato.TabStop = true;
            radContrato.Text = "Totalidad del contrato";
            radContrato.UseVisualStyleBackColor = true;
            radContrato.CheckedChanged += radContrato_CheckedChanged;
            // 
            // radRetiros
            // 
            radRetiros.AutoSize = true;
            radRetiros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radRetiros.Location = new Point(289, 280);
            radRetiros.Name = "radRetiros";
            radRetiros.Size = new Size(138, 25);
            radRetiros.TabIndex = 85;
            radRetiros.TabStop = true;
            radRetiros.Text = "Retiros de leche";
            radRetiros.UseVisualStyleBackColor = true;
            radRetiros.CheckedChanged += radRetiros_CheckedChanged;
            // 
            // txtNombres
            // 
            txtNombres.Cursor = Cursors.IBeam;
            txtNombres.Font = new Font("Segoe UI", 11.25F);
            txtNombres.Location = new Point(406, 110);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.ReadOnly = true;
            txtNombres.Size = new Size(202, 27);
            txtNombres.TabIndex = 84;
            // 
            // txtApellidos
            // 
            txtApellidos.Cursor = Cursors.IBeam;
            txtApellidos.Font = new Font("Segoe UI", 11.25F);
            txtApellidos.Location = new Point(406, 144);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.ReadOnly = true;
            txtApellidos.Size = new Size(202, 27);
            txtApellidos.TabIndex = 83;
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Font = new Font("Segoe UI", 11.25F);
            txtCorreo.Location = new Point(406, 178);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ReadOnly = true;
            txtCorreo.Size = new Size(202, 27);
            txtCorreo.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 81);
            label1.Name = "label1";
            label1.Size = new Size(162, 22);
            label1.TabIndex = 81;
            label1.Text = "Datos del cliente";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(268, 180);
            label11.Name = "label11";
            label11.Size = new Size(132, 20);
            label11.TabIndex = 70;
            label11.Text = "Correo electrónico";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(328, 146);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 68;
            label9.Text = "Apellidos";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(333, 214);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 64;
            label6.Text = "Teléfono";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(330, 112);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 63;
            label5.Text = "Nombres";
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Font = new Font("Segoe UI", 11.25F);
            txtTelefono.Location = new Point(406, 212);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(202, 27);
            txtTelefono.TabIndex = 62;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(347, 38);
            label18.Name = "label18";
            label18.Size = new Size(201, 32);
            label18.TabIndex = 58;
            label18.Text = "Nota de Venta";
            // 
            // FormVNotaDeVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVNotaDeVenta";
            Text = "Administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private TextBox txtCantidadLeche;
        private Label label17;
        private Label label16;
        private Label label14;
        private Label label13;
        private Label labelPrecioLitro;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private TextBox txtTelefono;
        private Label label18;
        private Label label1;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtCorreo;
        private Label label3;
        private Label label2;
        private RadioButton radContrato;
        private RadioButton radRetiros;
        private Button btnRegistrar;
        private Label labelCantidadLeche;
        private Label labelTotal;
        private TextBox txtTotal;
        private TextBox txtPrecioLitro;
    }
}