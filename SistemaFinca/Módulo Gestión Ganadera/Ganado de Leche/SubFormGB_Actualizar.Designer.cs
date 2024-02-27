namespace SistemaFinca.Módulo_Clientes.Gestión_Clientes
{
    partial class SubFormGB_Actualizar
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
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            buttonActualizar = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            radioButton1 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(465, 121);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 31;
            label5.Text = "Peso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(136, 121);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 30;
            label4.Text = "Edad";
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(465, 144);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 29);
            textBox4.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(136, 144);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 29);
            textBox3.TabIndex = 27;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Font = new Font("Segoe UI", 12F);
            buttonActualizar.Location = new Point(368, 347);
            buttonActualizar.Margin = new Padding(3, 2, 3, 2);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(93, 41);
            buttonActualizar.TabIndex = 26;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(465, 58);
            label3.Name = "label3";
            label3.Size = new Size(194, 21);
            label3.TabIndex = 25;
            label3.Text = "Número de indentificación";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(465, 81);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 29);
            textBox2.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(136, 205);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 34;
            label7.Text = "Categoría ";
            label7.Click += label7_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(136, 230);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(148, 25);
            radioButton1.TabIndex = 32;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ganado de Carne";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(136, 67);
            label1.Name = "label1";
            label1.Size = new Size(38, 21);
            label1.TabIndex = 36;
            label1.Text = "Res:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(504, 221);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(194, 34);
            button1.TabIndex = 37;
            button1.Text = "Nueva foto del Bovino";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F);
            radioButton2.Location = new Point(136, 274);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(119, 25);
            radioButton2.TabIndex = 39;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ganado Seco";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // SubFormGB_Actualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(radioButton2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(buttonActualizar);
            Controls.Add(label3);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SubFormGB_Actualizar";
            Text = "SubFormActualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button buttonActualizar;
        private Label label3;
        private TextBox textBox2;
        private Label label7;
        private RadioButton radioButton1;
        private Label label1;
        private Button button1;
        private RadioButton radioButton2;
    }
}