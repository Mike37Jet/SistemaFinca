namespace SistemaFinca
{
    partial class FormPL_Registrar
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
            label4 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 29);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 0;
            label1.Text = "Registrar cantidad de leche";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(43, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 88);
            label2.Name = "label2";
            label2.Size = new Size(248, 20);
            label2.TabIndex = 3;
            label2.Text = "Número de Identificador del bovino";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(337, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 88);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 5;
            label3.Text = "Cedula del obrero";
            // 
            // button2
            // 
            button2.Location = new Point(276, 379);
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
            textBox3.Location = new Point(43, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 27);
            textBox3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 145);
            label4.Name = "label4";
            label4.Size = new Size(208, 20);
            label4.TabIndex = 14;
            label4.Text = "Cantidad de leche produccida";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // FormPL_Registrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 459);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPL_Registrar";
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
        private Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}