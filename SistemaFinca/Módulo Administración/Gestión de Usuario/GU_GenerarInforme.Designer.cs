namespace SistemaFinca
{
    partial class FormGU_GenerarInforme
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
            buttonImprimir = new Button();
            textBox1 = new TextBox();
            buttonGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Informe";
            // 
            // buttonImprimir
            // 
            buttonImprimir.Location = new Point(166, 404);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(94, 29);
            buttonImprimir.TabIndex = 10;
            buttonImprimir.Text = "Imprimir";
            buttonImprimir.UseVisualStyleBackColor = true;
            buttonImprimir.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 70);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 303);
            textBox1.TabIndex = 11;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(372, 404);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 12;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // FormGU_GenerarInforme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 459);
            Controls.Add(buttonGuardar);
            Controls.Add(textBox1);
            Controls.Add(buttonImprimir);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGU_GenerarInforme";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonImprimir;
        private TextBox textBox1;
        private Button buttonGuardar;
    }
}