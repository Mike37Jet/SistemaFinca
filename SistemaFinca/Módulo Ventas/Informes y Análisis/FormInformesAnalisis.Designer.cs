using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaFinca
{
    partial class FormInformesAnalisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformesAnalisis));
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonRegistrar = new Button();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            panel2 = new Panel();
            panel13 = new Panel();
            textBox5 = new TextBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel14 = new Panel();
            panel11 = new Panel();
            textBox6 = new TextBox();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            panel12 = new Panel();
            panel9 = new Panel();
            textBox4 = new TextBox();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            panel10 = new Panel();
            panel5 = new Panel();
            textBox3 = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            panel8 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel15 = new Panel();
            panel1 = new Panel();
            label18 = new Label();
            chartLineas = new Chart();
            tableLayoutPanel1.SuspendLayout();
            panelFormularioHijo.SuspendLayout();
            panel2.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            InicializarGraficoLineas(chartLineas);
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
            panelFormularioHijo.Controls.Add(panel2);
            panelFormularioHijo.Controls.Add(panel1);
            panelFormularioHijo.Controls.Add(label18);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(650, 459);
            panelFormularioHijo.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panel13);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 125);
            panel2.TabIndex = 36;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Thistle;
            panel13.Controls.Add(textBox5);
            panel13.Controls.Add(label4);
            panel13.Controls.Add(pictureBox3);
            panel13.Controls.Add(panel14);
            panel13.Location = new Point(434, 1);
            panel13.Name = "panel13";
            panel13.Size = new Size(216, 60);
            panel13.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(76, 28);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(131, 27);
            textBox5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(70, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "Gastos";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panel14
            // 
            panel14.Location = new Point(217, 60);
            panel14.Name = "panel14";
            panel14.Size = new Size(219, 65);
            panel14.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Honeydew;
            panel11.Controls.Add(textBox6);
            panel11.Controls.Add(label7);
            panel11.Controls.Add(pictureBox6);
            panel11.Controls.Add(panel12);
            panel11.Location = new Point(434, 62);
            panel11.Name = "panel11";
            panel11.Size = new Size(216, 60);
            panel11.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(76, 27);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(131, 27);
            textBox6.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(70, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 17);
            label7.TabIndex = 4;
            label7.Text = "Dif.  Gan vs Gast";
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Left;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 60);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // panel12
            // 
            panel12.Location = new Point(217, 60);
            panel12.Name = "panel12";
            panel12.Size = new Size(219, 65);
            panel12.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Thistle;
            panel9.Controls.Add(textBox4);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(pictureBox5);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(217, 62);
            panel9.Name = "panel9";
            panel9.Size = new Size(216, 60);
            panel9.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(76, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(70, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 4;
            label6.Text = "Minima Ganancias";
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Left;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 60);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // panel10
            // 
            panel10.Location = new Point(217, 60);
            panel10.Name = "panel10";
            panel10.Size = new Size(219, 65);
            panel10.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Honeydew;
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(217, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(216, 60);
            panel5.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(76, 28);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(70, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 5;
            label3.Text = "Total mensual";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(217, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(216, 60);
            panel7.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Location = new Point(217, 60);
            panel8.Name = "panel8";
            panel8.Size = new Size(219, 65);
            panel8.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Location = new Point(217, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(219, 65);
            panel6.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Honeydew;
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(2, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 60);
            panel3.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(76, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 27);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(70, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 4;
            label5.Text = "Máxima Ganancias";
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Thistle;
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(panel15);
            panel4.Location = new Point(2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 60);
            panel4.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(76, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(70, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Total diario";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel15
            // 
            panel15.Location = new Point(217, 60);
            panel15.Name = "panel15";
            panel15.Size = new Size(219, 65);
            panel15.TabIndex = 1;
            // 
            // panel1
            // 

            panel1.Controls.Add(chartLineas);
            panel1.Location = new Point(0, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 237);
            panel1.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(216, 40);
            label18.Name = "label18";
            label18.Size = new Size(222, 27);
            label18.TabIndex = 34;
            label18.Text = "Informes y Análisis";
            // 
            // FormInformesAnalisis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 504);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInformesAnalisis";
            Text = "Inventario";
            tableLayoutPanel1.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            panel2.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Chart chartLineas;
        private Button buttonRegistrar;
        private Button buttonRegresar;
        private Panel panelFormularioHijo;
        private Label label18;
        private Panel panel1;
        private Panel panel2;
        private Panel panel13;
        private TextBox textBox5;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel panel14;
        private Panel panel11;
        private TextBox textBox6;
        private Label label7;
        private Panel panel12;
        private Panel panel9;
        private TextBox textBox4;
        private Label label6;
        private PictureBox pictureBox5;
        private Panel panel10;
        private Panel panel5;
        private TextBox textBox3;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Panel panel8;
        private Panel panel6;
        private Panel panel3;
        private TextBox textBox2;
        private Label label5;
        private PictureBox pictureBox4;
        private Panel panel4;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel15;
        private PictureBox pictureBox6;
    }
}