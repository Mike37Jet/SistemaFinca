namespace SistemaFinca
{
    partial class FormSeguimientoActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguimientoActividades));
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonRegistrar = new Button();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            label3 = new Label();
            label18 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label9 = new Label();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0769234F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.76923F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.11811F));
            tableLayoutPanel1.Controls.Add(buttonRegistrar, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonRegresar, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 459);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(650, 45);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Dock = DockStyle.Fill;
            buttonRegistrar.Image = (Image)resources.GetObject("buttonRegistrar.Image");
            buttonRegistrar.Location = new Point(0, 0);
            buttonRegistrar.Margin = new Padding(0);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(69, 45);
            buttonRegistrar.TabIndex = 6;
            buttonRegistrar.TextAlign = ContentAlignment.BottomCenter;
            buttonRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click_1;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Dock = DockStyle.Fill;
            buttonRegresar.Location = new Point(495, 3);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(152, 39);
            buttonRegresar.TabIndex = 5;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(textBox8);
            panelFormularioHijo.Controls.Add(label9);
            panelFormularioHijo.Controls.Add(textBox7);
            panelFormularioHijo.Controls.Add(label8);
            panelFormularioHijo.Controls.Add(textBox4);
            panelFormularioHijo.Controls.Add(label5);
            panelFormularioHijo.Controls.Add(textBox5);
            panelFormularioHijo.Controls.Add(label6);
            panelFormularioHijo.Controls.Add(textBox6);
            panelFormularioHijo.Controls.Add(label7);
            panelFormularioHijo.Controls.Add(textBox3);
            panelFormularioHijo.Controls.Add(label4);
            panelFormularioHijo.Controls.Add(textBox2);
            panelFormularioHijo.Controls.Add(label2);
            panelFormularioHijo.Controls.Add(textBox1);
            panelFormularioHijo.Controls.Add(label3);
            panelFormularioHijo.Controls.Add(label18);
            panelFormularioHijo.Controls.Add(label1);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(650, 459);
            panelFormularioHijo.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 72);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 37;
            label3.Text = "Fecha inicial de fumigación";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(193, 27);
            label18.Name = "label18";
            label18.Size = new Size(281, 23);
            label18.TabIndex = 34;
            label18.Text = "Seguimiento de Actividades";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 27);
            label1.Name = "label1";
            label1.Size = new Size(90, 27);
            label1.TabIndex = 5;
            label1.Text = "Ventas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 72);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 39;
            label2.Text = "Fecha final de fumigación";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 72);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 41;
            label4.Text = "Producto químico";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(436, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 27);
            textBox3.TabIndex = 42;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(436, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(190, 27);
            textBox4.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 142);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 47;
            label5.Text = "Cantidad de agua ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(228, 165);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(190, 27);
            textBox5.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(228, 142);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 45;
            label6.Text = "Fecha final de riego";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(20, 165);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(190, 27);
            textBox6.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 142);
            label7.Name = "label7";
            label7.Size = new Size(150, 20);
            label7.TabIndex = 43;
            label7.Text = "Fecha inicial de riego";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 215);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 49;
            label8.Text = "Observaciones";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(20, 238);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(350, 116);
            textBox7.TabIndex = 50;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(397, 238);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(190, 27);
            textBox8.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(397, 215);
            label9.Name = "label9";
            label9.Size = new Size(115, 20);
            label9.TabIndex = 51;
            label9.Text = "Código de zona";
            // 
            // FormSeguimientoActividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 504);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSeguimientoActividades";
            Text = "Inventario";
            tableLayoutPanel1.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonRegistrar;
        private Button buttonRegresar;
        private Panel panelFormularioHijo;
        private Label label1;
        private Label label3;
        private Label label18;
        private TextBox textBox1;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox8;
        private Label label9;
    }
}