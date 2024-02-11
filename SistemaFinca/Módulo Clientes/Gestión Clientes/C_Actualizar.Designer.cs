namespace SistemaFinca
{
    partial class FormC_Actualizar
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
            panelActualizarCliente = new Panel();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panelActualizarCliente.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 55);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 21);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 2;
            label1.Text = "Actualizar cliente";
            // 
            // panelActualizarCliente
            // 
            panelActualizarCliente.Controls.Add(button1);
            panelActualizarCliente.Controls.Add(label3);
            panelActualizarCliente.Controls.Add(textBox1);
            panelActualizarCliente.Controls.Add(label2);
            panelActualizarCliente.Dock = DockStyle.Fill;
            panelActualizarCliente.Location = new Point(0, 55);
            panelActualizarCliente.Name = "panelActualizarCliente";
            panelActualizarCliente.Size = new Size(650, 449);
            panelActualizarCliente.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(278, 130);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 83);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 2;
            label3.Text = "CI:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 33);
            label2.Name = "label2";
            label2.Size = new Size(559, 20);
            label2.TabIndex = 0;
            label2.Text = "Para actualizar los datos de un cliente, ingrese su número de cédula a continuación:\r\n";
            // 
            // FormC_Actualizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 504);
            Controls.Add(panelActualizarCliente);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormC_Actualizar";
            Text = "Administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelActualizarCliente.ResumeLayout(false);
            panelActualizarCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panelActualizarCliente;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}