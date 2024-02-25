namespace SistemaFinca
{
    partial class FormContratos
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
            tableLayoutPanelContrato = new TableLayoutPanel();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            buttonBuscarCliente = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label18 = new Label();
            tableLayoutPanelContrato.SuspendLayout();
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
            // tableLayoutPanelContrato
            // 
            tableLayoutPanelContrato.ColumnCount = 6;
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0769234F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.76923F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.11811F));
            tableLayoutPanelContrato.Controls.Add(buttonRegresar, 5, 0);
            tableLayoutPanelContrato.Dock = DockStyle.Bottom;
            tableLayoutPanelContrato.Location = new Point(0, 491);
            tableLayoutPanelContrato.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContrato.Name = "tableLayoutPanelContrato";
            tableLayoutPanelContrato.RowCount = 1;
            tableLayoutPanelContrato.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelContrato.Size = new Size(895, 50);
            tableLayoutPanelContrato.TabIndex = 7;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Dock = DockStyle.Fill;
            buttonRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(680, 2);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(212, 46);
            buttonRegresar.TabIndex = 5;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(buttonBuscarCliente);
            panelFormularioHijo.Controls.Add(label2);
            panelFormularioHijo.Controls.Add(textBox1);
            panelFormularioHijo.Controls.Add(label1);
            panelFormularioHijo.Controls.Add(label18);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Margin = new Padding(3, 2, 3, 2);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(895, 491);
            panelFormularioHijo.TabIndex = 8;
            panelFormularioHijo.Paint += panelFormularioHijo_Paint;
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuscarCliente.Location = new Point(400, 241);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(97, 35);
            buttonBuscarCliente.TabIndex = 43;
            buttonBuscarCliente.Text = "Buscar";
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 174);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 42;
            label2.Text = "CI:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(309, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 29);
            textBox1.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 96);
            label1.Name = "label1";
            label1.Size = new Size(351, 21);
            label1.TabIndex = 40;
            label1.Text = "Buscar al cliente interesado en emitir un contrato.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(342, 34);
            label18.Name = "label18";
            label18.Size = new Size(207, 32);
            label18.TabIndex = 39;
            label18.Text = "Buscar Cliente";
            // 
            // FormContratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanelContrato);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormContratos";
            Text = "Inventario";
            tableLayoutPanelContrato.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanelContrato;
        private Button buttonRegresar;
        private Panel panelFormularioHijo;
        private Button buttonBuscarCliente;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label18;
    }
}