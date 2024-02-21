namespace SistemaFinca
{
    partial class FormProcesoFaenamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcesoFaenamiento));
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            label2 = new Label();
            label1 = new Label();
            listView2 = new ListView();
            columnNumIdent = new ColumnHeader();
            columnRaza = new ColumnHeader();
            columnEdad = new ColumnHeader();
            columnCategoria = new ColumnHeader();
            columnPromedioLeche = new ColumnHeader();
            columnNumCrias = new ColumnHeader();
            buttonRegistrar = new Button();
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
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.277874F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.701333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.701333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1231308F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4392662F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.7570648F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(buttonRegistrar, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonRegresar, 6, 0);
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
            buttonRegresar.Location = new Point(500, 3);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(147, 39);
            buttonRegresar.TabIndex = 10;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(listView2);
            panelFormularioHijo.Controls.Add(label2);
            panelFormularioHijo.Controls.Add(label1);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(650, 459);
            panelFormularioHijo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 91);
            label2.Name = "label2";
            label2.Size = new Size(248, 20);
            label2.TabIndex = 3;
            label2.Text = "Lista de bovino para el faenamiento";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 31);
            label1.Name = "label1";
            label1.Size = new Size(158, 27);
            label1.TabIndex = 5;
            label1.Text = "Faenamiento";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView2.Columns.AddRange(new ColumnHeader[] { columnNumIdent, columnRaza, columnEdad, columnCategoria, columnPromedioLeche, columnNumCrias });
            listView2.Location = new Point(53, 114);
            listView2.Name = "listView2";
            listView2.Size = new Size(523, 311);
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnNumIdent
            // 
            columnNumIdent.Text = "Número Identificador";
            columnNumIdent.Width = 160;
            // 
            // columnRaza
            // 
            columnRaza.Text = "Raza";
            columnRaza.Width = 50;
            // 
            // columnEdad
            // 
            columnEdad.Text = "Edad";
            columnEdad.Width = 50;
            // 
            // columnCategoria
            // 
            columnCategoria.Text = "Categoría";
            columnCategoria.Width = 80;
            // 
            // columnPromedioLeche
            // 
            columnPromedioLeche.Text = "Promedio diario de leche.";
            columnPromedioLeche.Width = 80;
            // 
            // columnNumCrias
            // 
            columnNumCrias.Text = "Número de crías";
            columnNumCrias.Width = 90;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.Gray;
            buttonRegistrar.Dock = DockStyle.Fill;
            buttonRegistrar.Image = (Image)resources.GetObject("buttonRegistrar.Image");
            buttonRegistrar.Location = new Point(0, 0);
            buttonRegistrar.Margin = new Padding(0);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(91, 45);
            buttonRegistrar.TabIndex = 6;
            buttonRegistrar.TextAlign = ContentAlignment.BottomCenter;
            buttonRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click_1;
            // 
            // FormProcesoFaenamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 504);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProcesoFaenamiento";
            Text = "Inventario";
            tableLayoutPanel1.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelFormularioHijo;
        private Label label1;
        private Label label2;
        private Button buttonRegresar;
        private ListView listView2;
        private ColumnHeader columnNumIdent;
        private ColumnHeader columnRaza;
        private ColumnHeader columnEdad;
        private ColumnHeader columnCategoria;
        private ColumnHeader columnPromedioLeche;
        private ColumnHeader columnNumCrias;
        private Button buttonRegistrar;
    }
}