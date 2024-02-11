namespace SistemaFinca
{
    partial class FormAB_Actualizar
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
            button2 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 33);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Alimento";
            // 
            // button2
            // 
            button2.Location = new Point(269, 347);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 175);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 18;
            label4.Text = "Fecha de Vencimiento";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(42, 198);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 27);
            textBox3.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 94);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 16;
            label5.Text = "Cantidad";
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(326, 117);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(278, 27);
            textBox4.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 94);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 14;
            label6.Text = "Nombre";
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Location = new Point(42, 117);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(278, 27);
            textBox5.TabIndex = 13;
            // 
            // FormAB_Actualizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 504);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAB_Actualizar";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
    }
}