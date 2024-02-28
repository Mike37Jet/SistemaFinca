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
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            listUsuarios = new ListView();
            nombre = new ColumnHeader();
            fecha = new ColumnHeader();
            fechaf = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(422, 25);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Informe";
            // 
            // listUsuarios
            // 
            listUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listUsuarios.Columns.AddRange(new ColumnHeader[] { nombre, fecha, fechaf });
            listUsuarios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listUsuarios.Location = new Point(55, 78);
            listUsuarios.Margin = new Padding(3, 2, 3, 2);
            listUsuarios.Name = "listUsuarios";
            listUsuarios.Size = new Size(785, 385);
            listUsuarios.TabIndex = 11;
            listUsuarios.UseCompatibleStateImageBehavior = false;
            listUsuarios.View = View.Details;
            listUsuarios.SelectedIndexChanged += listUsuarios_SelectedIndexChanged;
            // 
            // nombre
            // 
            nombre.Text = "Nombre de Usuario";
            nombre.Width = 150;
            // 
            // fecha
            // 
            fecha.Text = "Fecha y Hora de Inicio de Sesión";
            fecha.Width = 230;
            // 
            // fechaf
            // 
            fechaf.Text = "Fecha y Hora de Fin de Sesión ";
            fechaf.Width = 230;
            // 
            // FormGU_GenerarInforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(listUsuarios);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGU_GenerarInforme";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxInforme;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ListView listU;
        private ColumnHeader columnCorreo;
        private ColumnHeader columnRol;
        private ColumnHeader columnUsuario;
        private ListView listUsuarios;
        private ColumnHeader nombre;
        private ColumnHeader fecha;
        private ColumnHeader fechaf;
    }
}