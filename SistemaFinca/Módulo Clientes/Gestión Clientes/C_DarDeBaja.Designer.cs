namespace SistemaFinca
{
    partial class FormC_DarDeBaja
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
            txtNumeroC = new TextBox();
            label2 = new Label();
            buttonGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(369, 56);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 0;
            label1.Text = "Dar de Baja al cliente";
            // 
            // txtNumeroC
            // 
            txtNumeroC.Cursor = Cursors.IBeam;
            txtNumeroC.Font = new Font("Segoe UI", 12F);
            txtNumeroC.Location = new Point(324, 144);
            txtNumeroC.Margin = new Padding(3, 2, 3, 2);
            txtNumeroC.Name = "txtNumeroC";
            txtNumeroC.Size = new Size(244, 29);
            txtNumeroC.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(332, 108);
            label2.Name = "label2";
            label2.Size = new Size(231, 21);
            label2.TabIndex = 3;
            label2.Text = "Número de Cédula de identidad";
            label2.Click += label2_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Font = new Font("Segoe UI", 12F);
            buttonGuardar.Location = new Point(391, 230);
            buttonGuardar.Margin = new Padding(3, 2, 3, 2);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(112, 40);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += button2_Click;
            // 
            // FormC_DarDeBaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(buttonGuardar);
            Controls.Add(label2);
            Controls.Add(txtNumeroC);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormC_DarDeBaja";
            Text = "Administrador";
            Load += FormC_DarDeBaja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeroC;
        private Label label2;
        private Button buttonGuardar;
    }
}