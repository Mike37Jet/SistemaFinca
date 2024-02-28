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
            txtNumeroC = new TextBox();
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
            panel1.Size = new Size(895, 55);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 21);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 2;
            label1.Text = "Actualizar cliente";
            // 
            // panelActualizarCliente
            // 
            panelActualizarCliente.Controls.Add(button1);
            panelActualizarCliente.Controls.Add(label3);
            panelActualizarCliente.Controls.Add(txtNumeroC);
            panelActualizarCliente.Controls.Add(label2);
            panelActualizarCliente.Dock = DockStyle.Fill;
            panelActualizarCliente.Location = new Point(0, 55);
            panelActualizarCliente.Name = "panelActualizarCliente";
            panelActualizarCliente.Size = new Size(895, 486);
            panelActualizarCliente.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(400, 130);
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
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(272, 82);
            label3.Name = "label3";
            label3.Size = new Size(27, 21);
            label3.TabIndex = 2;
            label3.Text = "CI:";
            // 
            // txtNumeroC
            // 
            txtNumeroC.Font = new Font("Segoe UI", 12F);
            txtNumeroC.Location = new Point(299, 79);
            txtNumeroC.Name = "txtNumeroC";
            txtNumeroC.Size = new Size(296, 29);
            txtNumeroC.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(111, 34);
            label2.Name = "label2";
            label2.Size = new Size(673, 21);
            label2.TabIndex = 0;
            label2.Text = "Para actualizar los datos de un cliente, ingrese su número de cédula de identidad a continuación:\r\n";
            // 
            // FormC_Actualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
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
        private TextBox txtNumeroC;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}