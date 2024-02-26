namespace SistemaFinca
{
    partial class FormIFGenerarInforme
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
            label1 = new Label();
            panel2 = new Panel();
            buttonBuscar = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelReporte = new Panel();
            labelInforme = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelReporte.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 36);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 0;
            label1.Text = "Reporte";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonBuscar);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 91);
            panel2.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuscar.Location = new Point(523, 43);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(109, 35);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abrir", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            comboBox1.Location = new Point(285, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(48, 52);
            label4.Name = "label4";
            label4.Size = new Size(38, 21);
            label4.TabIndex = 2;
            label4.Text = "Año";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(240, 52);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 1;
            label3.Text = "Mes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(48, 13);
            label2.Name = "label2";
            label2.Size = new Size(503, 21);
            label2.TabIndex = 0;
            label2.Text = "Ingrese el año y seleccione el para el cual se requiere generar el reporte";
            // 
            // panelReporte
            // 
            panelReporte.Controls.Add(labelInforme);
            panelReporte.Dock = DockStyle.Fill;
            panelReporte.Location = new Point(0, 127);
            panelReporte.Name = "panelReporte";
            panelReporte.Size = new Size(895, 369);
            panelReporte.TabIndex = 2;
            // 
            // labelInforme
            // 
            labelInforme.AutoSize = true;
            labelInforme.Location = new Point(368, 318);
            labelInforme.Name = "labelInforme";
            labelInforme.Size = new Size(74, 15);
            labelInforme.TabIndex = 0;
            labelInforme.Text = "labelInforme";
            // 
            // FormIFGenerarInforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 496);
            Controls.Add(panelReporte);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormIFGenerarInforme";
            Text = "Administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelReporte.ResumeLayout(false);
            panelReporte.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelReporte;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonBuscar;
        private ComboBox comboBox1;
        private Label labelInforme;
    }
}