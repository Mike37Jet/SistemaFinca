namespace SistemaFinca
{
    partial class FormRecordAlert
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            label18 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            columnNumRecord = new ColumnHeader();
            columnNombre = new ColumnHeader();
            columnNumNota = new ColumnHeader();
            columnValorPagar = new ColumnHeader();
            tableLayoutPanel1.SuspendLayout();
            panelFormularioHijo.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0769234F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.76923F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.11811F));
            tableLayoutPanel1.Controls.Add(buttonRegresar, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 459);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(650, 45);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Dock = DockStyle.Fill;
            buttonRegresar.Location = new Point(495, 3);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(152, 39);
            buttonRegresar.TabIndex = 5;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(listView1);
            panelFormularioHijo.Controls.Add(label2);
            panelFormularioHijo.Controls.Add(label18);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(650, 459);
            panelFormularioHijo.TabIndex = 8;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(196, 30);
            label18.Name = "label18";
            label18.Size = new Size(241, 23);
            label18.TabIndex = 34;
            label18.Text = "Recordatorios y Alertas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 82);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 45;
            label2.Text = "Lista de recordatorios";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnNumRecord, columnNombre, columnNumNota, columnValorPagar });
            listView1.Location = new Point(43, 121);
            listView1.Name = "listView1";
            listView1.Size = new Size(557, 311);
            listView1.TabIndex = 46;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnNumRecord
            // 
            columnNumRecord.Text = "Número de recordatorio";
            columnNumRecord.Width = 180;
            // 
            // columnNombre
            // 
            columnNombre.Text = "Nombre cliente";
            columnNombre.Width = 120;
            // 
            // columnNumNota
            // 
            columnNumNota.Text = "Número de Nota de venta";
            columnNumNota.Width = 180;
            // 
            // columnValorPagar
            // 
            columnValorPagar.Text = "Valor a pagar";
            columnValorPagar.Width = 100;
            // 
            // FormRecordAlert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 504);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRecordAlert";
            Text = "Inventario";
            tableLayoutPanel1.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonRegresar;
        private Panel panelFormularioHijo;
        private Label label18;
        private ListView listView1;
        private ColumnHeader columnNumRecord;
        private ColumnHeader columnNombre;
        private ColumnHeader columnNumNota;
        private ColumnHeader columnValorPagar;
        private Label label2;
    }
}