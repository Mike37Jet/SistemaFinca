namespace SistemaFinca.Módulo_Zonas_de_Pastoreo.Fumigación
{
    partial class GDZP_Fumigación
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
            dataGridView1 = new DataGridView();
            ColumnFechaInicial = new DataGridViewTextBoxColumn();
            ColumnFechaFinal = new DataGridViewTextBoxColumn();
            ColumnQuimico = new DataGridViewTextBoxColumn();
            ColumnCantidad = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnFechaInicial, ColumnFechaFinal, ColumnQuimico, ColumnCantidad });
            dataGridView1.Location = new Point(223, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 143);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnFechaInicial
            // 
            ColumnFechaInicial.HeaderText = "Fecha Inicial";
            ColumnFechaInicial.Name = "ColumnFechaInicial";
            // 
            // ColumnFechaFinal
            // 
            ColumnFechaFinal.HeaderText = "Fecha Final";
            ColumnFechaFinal.Name = "ColumnFechaFinal";
            // 
            // ColumnQuimico
            // 
            ColumnQuimico.HeaderText = "Químico";
            ColumnQuimico.Name = "ColumnQuimico";
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.HeaderText = "Cantidad Químico";
            ColumnCantidad.Name = "ColumnCantidad";
            // 
            // button1
            // 
            button1.Location = new Point(425, 442);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 110);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha Inicial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 149);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha Final";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 187);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 5;
            label4.Text = "Químico";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(373, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(375, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(198, 23);
            textBox4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 228);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 10;
            label5.Text = "Cantidad Químico";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(375, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 47);
            label1.Name = "label1";
            label1.Size = new Size(279, 24);
            label1.TabIndex = 13;
            label1.Text = "Registrar Período Fumigación";
            // 
            // GDZP_Fumigación
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 502);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GDZP_Fumigación";
            Text = "GDZP_Fumigación";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnFechaInicial;
        private DataGridViewTextBoxColumn ColumnFechaFinal;
        private DataGridViewTextBoxColumn ColumnQuimico;
        private DataGridViewTextBoxColumn ColumnCantidad;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
    }
}