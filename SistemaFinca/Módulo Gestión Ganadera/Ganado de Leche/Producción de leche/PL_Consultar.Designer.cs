namespace SistemaFinca
{
    partial class FormPL_Emitir
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
            radioResumenHistorico = new RadioButton();
            radioAnual = new RadioButton();
            radioMensual = new RadioButton();
            button1 = new Button();
            label2 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
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
            label1.Location = new Point(263, 21);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Mostrar Informe";
            // 
            // panelActualizarCliente
            // 
            panelActualizarCliente.Controls.Add(radioResumenHistorico);
            panelActualizarCliente.Controls.Add(radioAnual);
            panelActualizarCliente.Controls.Add(radioMensual);
            panelActualizarCliente.Controls.Add(button1);
            panelActualizarCliente.Controls.Add(label2);
            panelActualizarCliente.Dock = DockStyle.Fill;
            panelActualizarCliente.Location = new Point(0, 55);
            panelActualizarCliente.Name = "panelActualizarCliente";
            panelActualizarCliente.Size = new Size(650, 449);
            panelActualizarCliente.TabIndex = 3;
            // 
            // radioResumenHistorico
            // 
            radioResumenHistorico.AutoSize = true;
            radioResumenHistorico.Location = new Point(34, 108);
            radioResumenHistorico.Name = "radioResumenHistorico";
            radioResumenHistorico.Size = new Size(154, 24);
            radioResumenHistorico.TabIndex = 6;
            radioResumenHistorico.TabStop = true;
            radioResumenHistorico.Text = "Resumen Histórico";
            radioResumenHistorico.UseVisualStyleBackColor = true;
            // 
            // radioAnual
            // 
            radioAnual.AutoSize = true;
            radioAnual.Location = new Point(34, 78);
            radioAnual.Name = "radioAnual";
            radioAnual.Size = new Size(68, 24);
            radioAnual.TabIndex = 5;
            radioAnual.TabStop = true;
            radioAnual.Text = "Anual";
            radioAnual.UseVisualStyleBackColor = true;
            // 
            // radioMensual
            // 
            radioMensual.AutoSize = true;
            radioMensual.Location = new Point(34, 48);
            radioMensual.Name = "radioMensual";
            radioMensual.Size = new Size(85, 24);
            radioMensual.TabIndex = 4;
            radioMensual.TabStop = true;
            radioMensual.Text = "Mensual";
            radioMensual.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(272, 359);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += imprimir;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 15);
            label2.Name = "label2";
            label2.Size = new Size(223, 40);
            label2.TabIndex = 0;
            label2.Text = "Elegir el resumen de producción\r\n\r\n";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // FormPL_Emitir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 504);
            Controls.Add(panelActualizarCliente);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPL_Emitir";
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
        private Label label2;
        private Button button1;
        private RadioButton radioResumenHistorico;
        private RadioButton radioAnual;
        private RadioButton radioMensual;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}