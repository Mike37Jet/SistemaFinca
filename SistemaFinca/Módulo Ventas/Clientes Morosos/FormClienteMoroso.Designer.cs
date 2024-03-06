namespace SistemaFinca
{
    partial class FormClienteMoroso
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
            labelClientesDeudores = new Label();
            listView1 = new ListView();
            columnNumCedula = new ColumnHeader();
            columnNombre = new ColumnHeader();
            columnNumTelefonico = new ColumnHeader();
            columnDirDomiciliaria = new ColumnHeader();
            label2 = new Label();
            label18 = new Label();
            columnDirEmail = new ColumnHeader();
            columnMontoPagar = new ColumnHeader();
            columnCantEntregada = new ColumnHeader();
            columnCantFaltante = new ColumnHeader();
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
            tableLayoutPanel1.Location = new Point(0, 541);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(895, 50);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Dock = DockStyle.Fill;
            buttonRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(680, 2);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(212, 46);
            buttonRegresar.TabIndex = 5;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(labelClientesDeudores);
            panelFormularioHijo.Controls.Add(listView1);
            panelFormularioHijo.Controls.Add(label2);
            panelFormularioHijo.Controls.Add(label18);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Margin = new Padding(3, 2, 3, 2);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(895, 541);
            panelFormularioHijo.TabIndex = 8;
            // 
            // labelClientesDeudores
            // 
            labelClientesDeudores.AutoSize = true;
            labelClientesDeudores.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelClientesDeudores.Location = new Point(348, 18);
            labelClientesDeudores.Name = "labelClientesDeudores";
            labelClientesDeudores.Size = new Size(212, 28);
            labelClientesDeudores.TabIndex = 47;
            labelClientesDeudores.Text = "Clientes Morosos";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnNumCedula, columnNombre, columnNumTelefonico, columnDirDomiciliaria, columnDirEmail, columnMontoPagar, columnCantEntregada, columnCantFaltante });
            listView1.Location = new Point(38, 91);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(816, 420);
            listView1.TabIndex = 46;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnNumCedula
            // 
            columnNumCedula.Text = "Número de cédula";
            columnNumCedula.Width = 180;
            // 
            // columnNombre
            // 
            columnNombre.Text = "Nombre";
            columnNombre.Width = 120;
            // 
            // columnNumTelefonico
            // 
            columnNumTelefonico.Text = "Número telefónico";
            columnNumTelefonico.Width = 180;
            // 
            // columnDirDomiciliaria
            // 
            columnDirDomiciliaria.Text = "Dirección domiciliaria";
            columnDirDomiciliaria.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 62);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 45;
            label2.Text = "Lista clientes morosos";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(172, 22);
            label18.Name = "label18";
            label18.Size = new Size(0, 18);
            label18.TabIndex = 34;
            // 
            // columnDirEmail
            // 
            columnDirEmail.Text = "Correo electrónico";
            columnDirEmail.Width = 160;
            // 
            // columnMontoPagar
            // 
            columnMontoPagar.Text = "Monto a pagar";
            columnMontoPagar.Width = 120;
            // 
            // columnCantEntregada
            // 
            columnCantEntregada.Text = "Cantidad de litros entregada";
            // 
            // columnCantFaltante
            // 
            columnCantFaltante.Text = "CantidadFaltante";
            // 
            // FormRecordAlert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 591);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private ColumnHeader columnNumCedula;
        private ColumnHeader columnNombre;
        private ColumnHeader columnNumTelefonico;
        private ColumnHeader columnDirDomiciliaria;
        private Label label2;
        private Label labelClientesDeudores;
        private ColumnHeader columnDirEmail;
        private ColumnHeader columnMontoPagar;
        private ColumnHeader columnCantEntregada;
        private ColumnHeader columnCantFaltante;
    }
}