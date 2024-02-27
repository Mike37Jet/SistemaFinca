﻿namespace SistemaFinca
{
    partial class FormGestionPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionPagos));
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonRegistrarPago = new Button();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            listView1 = new ListView();
            columnCodigoNotaVenta = new ColumnHeader();
            columnNombre = new ColumnHeader();
            columnFecha = new ColumnHeader();
            columnValorPagar = new ColumnHeader();
            label2 = new Label();
            label18 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelFormularioHijo.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.63409F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6357212F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6357212F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0981445F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.83201F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.1643162F));
            tableLayoutPanel1.Controls.Add(buttonRegistrarPago, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonRegresar, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 541);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(895, 50);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // buttonRegistrarPago
            // 
            buttonRegistrarPago.Dock = DockStyle.Fill;
            buttonRegistrarPago.Image = (Image)resources.GetObject("buttonRegistrarPago.Image");
            buttonRegistrarPago.Location = new Point(0, 0);
            buttonRegistrarPago.Margin = new Padding(0);
            buttonRegistrarPago.Name = "buttonRegistrarPago";
            buttonRegistrarPago.Size = new Size(95, 50);
            buttonRegistrarPago.TabIndex = 6;
            buttonRegistrarPago.UseVisualStyleBackColor = true;
            buttonRegistrarPago.Click += buttonRegistrarPago_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Dock = DockStyle.Fill;
            buttonRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(680, 3);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(212, 44);
            buttonRegresar.TabIndex = 5;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(listView2);
            panelFormularioHijo.Controls.Add(label1);
            panelFormularioHijo.Controls.Add(listView1);
            panelFormularioHijo.Controls.Add(label2);
            panelFormularioHijo.Controls.Add(label18);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(895, 541);
            panelFormularioHijo.TabIndex = 8;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView2.Font = new Font("Segoe UI", 11.25F);
            listView2.Location = new Point(43, 316);
            listView2.Name = "listView2";
            listView2.Size = new Size(796, 184);
            listView2.TabIndex = 48;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código de Nota de Venta";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre cliente";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha";
            columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Valor a pagar";
            columnHeader4.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(43, 294);
            label1.Name = "label1";
            label1.Size = new Size(238, 20);
            label1.TabIndex = 47;
            label1.Text = "Lista de notas de venta pendientes";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnCodigoNotaVenta, columnNombre, columnFecha, columnValorPagar });
            listView1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(43, 92);
            listView1.Name = "listView1";
            listView1.Size = new Size(796, 180);
            listView1.TabIndex = 46;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnCodigoNotaVenta
            // 
            columnCodigoNotaVenta.Text = "Código de Nota de Venta";
            columnCodigoNotaVenta.Width = 200;
            // 
            // columnNombre
            // 
            columnNombre.Text = "Nombre cliente";
            columnNombre.Width = 120;
            // 
            // columnFecha
            // 
            columnFecha.Text = "Fecha";
            columnFecha.Width = 50;
            // 
            // columnValorPagar
            // 
            columnValorPagar.Text = "Valor a pagar";
            columnValorPagar.Width = 130;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(43, 71);
            label2.Name = "label2";
            label2.Size = new Size(222, 20);
            label2.TabIndex = 45;
            label2.Text = "Lista de notas de venta pagadas";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(340, 32);
            label18.Name = "label18";
            label18.Size = new Size(214, 28);
            label18.TabIndex = 34;
            label18.Text = "Gestión de Pagos";
            // 
            // FormGestionPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 591);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionPagos";
            Text = "Inventario";
            tableLayoutPanel1.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonRegresar;
        private Panel panelFormularioHijo;
        private Label label18;
        private ListView listView1;
        private ColumnHeader columnCodigoNotaVenta;
        private ColumnHeader columnNombre;
        private ColumnHeader columnFecha;
        private ColumnHeader columnValorPagar;
        private Label label2;
        private Label label1;
        private Button buttonRegistrarPago;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
    }
}