namespace SistemaFinca
{
    partial class FormBuscar
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panelFormularioHijo = new Panel();
            panelHijoPagos = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            buttonBuscarCliente = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label18 = new Label();
            tableLayoutPanelContrato = new TableLayoutPanel();
            buttonRegresar = new Button();
            panelFormularioHijo.SuspendLayout();
            panelHijoPagos.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(panelHijoPagos);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Margin = new Padding(3, 2, 3, 2);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(895, 541);
            panelFormularioHijo.TabIndex = 8;
            panelFormularioHijo.Paint += panelFormularioHijo_Paint;
            // 
            // panelHijoPagos
            // 
            panelHijoPagos.Controls.Add(tableLayoutPanel1);
            panelHijoPagos.Controls.Add(buttonBuscarCliente);
            panelHijoPagos.Controls.Add(label2);
            panelHijoPagos.Controls.Add(textBox1);
            panelHijoPagos.Controls.Add(label1);
            panelHijoPagos.Controls.Add(label18);
            panelHijoPagos.Dock = DockStyle.Fill;
            panelHijoPagos.Location = new Point(0, 0);
            panelHijoPagos.Name = "panelHijoPagos";
            panelHijoPagos.Size = new Size(895, 541);
            panelHijoPagos.TabIndex = 45;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0769234F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.76923F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.11811F));
            tableLayoutPanel1.Controls.Add(button1, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 491);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(895, 50);
            tableLayoutPanel1.TabIndex = 49;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(680, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(212, 46);
            button1.TabIndex = 5;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuscarCliente.Location = new Point(399, 269);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(97, 35);
            buttonBuscarCliente.TabIndex = 48;
            buttonBuscarCliente.Text = "Buscar";
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 202);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 47;
            label2.Text = "CI:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(311, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 29);
            textBox1.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 124);
            label1.Name = "label1";
            label1.Size = new Size(503, 21);
            label1.TabIndex = 45;
            label1.Text = "Buscar al cliente interesado en completar el pago de la factura de venta.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(344, 62);
            label18.Name = "label18";
            label18.Size = new Size(207, 32);
            label18.TabIndex = 44;
            label18.Text = "Buscar Cliente";
            // 
            // tableLayoutPanelContrato
            // 
            tableLayoutPanelContrato.ColumnCount = 6;
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0769234F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.76923F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.11811F));
            tableLayoutPanelContrato.Dock = DockStyle.Bottom;
            tableLayoutPanelContrato.Location = new Point(0, 0);
            tableLayoutPanelContrato.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContrato.Name = "tableLayoutPanelContrato";
            tableLayoutPanelContrato.RowCount = 1;
            tableLayoutPanelContrato.Size = new Size(200, 100);
            tableLayoutPanelContrato.TabIndex = 0;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Dock = DockStyle.Fill;
            buttonRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(153, 2);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(44, 96);
            buttonRegresar.TabIndex = 5;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            // 
            // FormBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(panelFormularioHijo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBuscar";
            Text = "Inventario";
            panelFormularioHijo.ResumeLayout(false);
            panelHijoPagos.ResumeLayout(false);
            panelHijoPagos.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelFormularioHijo;
        private Panel panelHijoPagos;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button buttonBuscarCliente;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label18;
        private TableLayoutPanel tableLayoutPanelContrato;
        private Button buttonRegresar;
    }
}