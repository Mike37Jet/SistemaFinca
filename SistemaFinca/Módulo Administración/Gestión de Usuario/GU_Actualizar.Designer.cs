namespace SistemaFinca
{
    partial class FormGU_Actualizar
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
            btnBuscar = new Button();
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
            panel1.Font = new Font("Segoe UI", 10.8F);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 41);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(383, 10);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "Actualizar Usuario";
            // 
            // panelActualizarCliente
            // 
            panelActualizarCliente.Controls.Add(btnBuscar);
            panelActualizarCliente.Controls.Add(label3);
            panelActualizarCliente.Controls.Add(txtNumeroC);
            panelActualizarCliente.Controls.Add(label2);
            panelActualizarCliente.Dock = DockStyle.Fill;
            panelActualizarCliente.Location = new Point(0, 41);
            panelActualizarCliente.Margin = new Padding(3, 2, 3, 2);
            panelActualizarCliente.Name = "panelActualizarCliente";
            panelActualizarCliente.Size = new Size(895, 500);
            panelActualizarCliente.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(406, 98);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 30);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(290, 62);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 2;
            label3.Text = "CI:";
            // 
            // txtNumeroC
            // 
            txtNumeroC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumeroC.Font = new Font("Segoe UI", 11.25F);
            txtNumeroC.Location = new Point(317, 59);
            txtNumeroC.Margin = new Padding(3, 2, 3, 2);
            txtNumeroC.Name = "txtNumeroC";
            txtNumeroC.Size = new Size(260, 27);
            txtNumeroC.TabIndex = 1;
            txtNumeroC.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 25);
            label2.Name = "label2";
            label2.Size = new Size(563, 20);
            label2.TabIndex = 0;
            label2.Text = "Para actualizar los datos de un usuario, ingrese su número de cédula a continuación:\r\n";
            // 
            // FormGU_Actualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(panelActualizarCliente);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGU_Actualizar";
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
        private Button btnBuscar;
        private Label label3;
    }
}