namespace SistemaFinca
{
    partial class FormVConsultar
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
            lstNotasVenta = new ListView();
            columnCantidad = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnFechaEmision = new ColumnHeader();
            txtCedula = new TextBox();
            label4 = new Label();
            btnConsultar = new Button();
            label18 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lstNotasVenta);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(label18);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 541);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lstNotasVenta
            // 
            lstNotasVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstNotasVenta.Columns.AddRange(new ColumnHeader[] { columnCantidad, columnHeader1, columnFechaEmision });
            lstNotasVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstNotasVenta.Location = new Point(213, 166);
            lstNotasVenta.Margin = new Padding(3, 2, 3, 2);
            lstNotasVenta.Name = "lstNotasVenta";
            lstNotasVenta.Size = new Size(471, 239);
            lstNotasVenta.TabIndex = 137;
            lstNotasVenta.UseCompatibleStateImageBehavior = false;
            lstNotasVenta.View = View.Details;
            // 
            // columnCantidad
            // 
            columnCantidad.Text = "Cantidad de leche";
            columnCantidad.Width = 140;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Monto";
            columnHeader1.Width = 140;
            // 
            // columnFechaEmision
            // 
            columnFechaEmision.Text = "Fecha de emisión";
            columnFechaEmision.Width = 160;
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCedula.Cursor = Cursors.IBeam;
            txtCedula.Font = new Font("Segoe UI", 11.25F);
            txtCedula.Location = new Point(263, 117);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(178, 27);
            txtCedula.TabIndex = 136;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(347, 86);
            label4.Name = "label4";
            label4.Size = new Size(221, 20);
            label4.TabIndex = 135;
            label4.Text = "Número de cédula de identidad";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.Font = new Font("Segoe UI", 11.25F);
            btnConsultar.Location = new Point(465, 117);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(103, 27);
            btnConsultar.TabIndex = 134;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(274, 36);
            label18.Name = "label18";
            label18.Size = new Size(351, 32);
            label18.TabIndex = 58;
            label18.Text = "Consultar Notas de Venta";
            // 
            // FormVConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVConsultar";
            Text = "Administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private Label label17;
        private Label label16;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label8;
        private Label label18;
        private TextBox txtCedula;
        private Label label4;
        private Button btnConsultar;
        private ListView lstNotasVenta;
        private ColumnHeader columnCantidad;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnFechaEmision;
    }
}