namespace SistemaFinca
{
    partial class FormGB_Registrar
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            radioButton3 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 29);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Registrar nuevo Bovino";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(45, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 70);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 3;
            label2.Text = "Número de Identificador";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(339, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 70);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "Raza";
            // 
            // button2
            // 
            button2.Location = new Point(277, 399);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(45, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(339, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(278, 27);
            textBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 127);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 14;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 127);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 15;
            label5.Text = "Peso";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(45, 234);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(172, 24);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "Productoras de Carne";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(45, 264);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(172, 24);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Productoras de Leche";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 201);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 19;
            label7.Text = "Categoría ";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(45, 294);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(121, 24);
            radioButton3.TabIndex = 20;
            radioButton3.TabStop = true;
            radioButton3.Text = "Dual-purpose";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(348, 229);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 21;
            button1.Text = "Añadir fotografia";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormGB_Registrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 459);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGB_Registrar";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private RadioButton radioButton3;
        private Button button1;
    }
}