namespace SistemaFinca
{
    partial class FormGB_Remover
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
            buttonGuardar = new Button();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Remover Bovino";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(75, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 85);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 3;
            label2.Text = "Número de Identificación";
            label2.Click += label2_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(290, 386);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 164);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 21;
            label3.Text = "Motivo";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(75, 198);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(118, 24);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "Fallecimiento";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(75, 228);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(115, 24);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "Faenamiento";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(76, 258);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 24);
            radioButton3.TabIndex = 24;
            radioButton3.TabStop = true;
            radioButton3.Text = "Venta";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // FormGB_Remover
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 459);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(buttonGuardar);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGB_Remover";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button buttonGuardar;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}