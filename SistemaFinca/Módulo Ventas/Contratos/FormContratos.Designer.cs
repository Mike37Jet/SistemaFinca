namespace SistemaFinca
{
    partial class FormContratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContratos));
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanelContrato = new TableLayoutPanel();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnGenerar = new Button();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            lstContratos = new ListView();
            columnID = new ColumnHeader();
            columnCantidad = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnFechaInicio = new ColumnHeader();
            columnFechaFin = new ColumnHeader();
            label18 = new Label();
            tableLayoutPanelContrato.SuspendLayout();
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
            // tableLayoutPanelContrato
            // 
            tableLayoutPanelContrato.ColumnCount = 6;
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0769234F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.76923F));
            tableLayoutPanelContrato.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.11811F));
            tableLayoutPanelContrato.Controls.Add(btnEliminar, 0, 0);
            tableLayoutPanelContrato.Controls.Add(btnConsultar, 0, 0);
            tableLayoutPanelContrato.Controls.Add(btnGenerar, 0, 0);
            tableLayoutPanelContrato.Controls.Add(buttonRegresar, 5, 0);
            tableLayoutPanelContrato.Dock = DockStyle.Bottom;
            tableLayoutPanelContrato.Location = new Point(0, 491);
            tableLayoutPanelContrato.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContrato.Name = "tableLayoutPanelContrato";
            tableLayoutPanelContrato.RowCount = 1;
            tableLayoutPanelContrato.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelContrato.Size = new Size(895, 50);
            tableLayoutPanelContrato.TabIndex = 7;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(190, 0);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 50);
            btnEliminar.TabIndex = 16;
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.MouseMove += btnEliminar_MouseMove;
            // 
            // btnConsultar
            // 
            btnConsultar.Dock = DockStyle.Fill;
            btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.Location = new Point(95, 0);
            btnConsultar.Margin = new Padding(0);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(95, 50);
            btnConsultar.TabIndex = 15;
            btnConsultar.TextAlign = ContentAlignment.BottomCenter;
            btnConsultar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            btnConsultar.MouseMove += btnConsultar_MouseMove;
            // 
            // btnGenerar
            // 
            btnGenerar.Dock = DockStyle.Fill;
            btnGenerar.Image = (Image)resources.GetObject("btnGenerar.Image");
            btnGenerar.Location = new Point(0, 0);
            btnGenerar.Margin = new Padding(0);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(95, 50);
            btnGenerar.TabIndex = 14;
            btnGenerar.TextAlign = ContentAlignment.BottomCenter;
            btnGenerar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            btnGenerar.MouseMove += btnGenerar_MouseMove;
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
            panelFormularioHijo.Controls.Add(lstContratos);
            panelFormularioHijo.Controls.Add(label18);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Margin = new Padding(3, 2, 3, 2);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(895, 491);
            panelFormularioHijo.TabIndex = 8;
            panelFormularioHijo.Paint += panelFormularioHijo_Paint;
            // 
            // lstContratos
            // 
            lstContratos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstContratos.Columns.AddRange(new ColumnHeader[] { columnID, columnCantidad, columnHeader1, columnFechaInicio, columnFechaFin });
            lstContratos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstContratos.Location = new Point(71, 71);
            lstContratos.Margin = new Padding(3, 2, 3, 2);
            lstContratos.Name = "lstContratos";
            lstContratos.Size = new Size(746, 382);
            lstContratos.TabIndex = 40;
            lstContratos.UseCompatibleStateImageBehavior = false;
            lstContratos.View = View.Details;
            // 
            // columnID
            // 
            columnID.Text = "Número de cédula";
            columnID.Width = 160;
            // 
            // columnCantidad
            // 
            columnCantidad.Text = "Cantidad de leche";
            columnCantidad.Width = 140;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cantidad retirada";
            columnHeader1.Width = 140;
            // 
            // columnFechaInicio
            // 
            columnFechaInicio.Text = "Fecha de inicio";
            columnFechaInicio.Width = 140;
            // 
            // columnFechaFin
            // 
            columnFechaFin.Text = "Fecha de finalización";
            columnFechaFin.Width = 160;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(366, 27);
            label18.Name = "label18";
            label18.Size = new Size(145, 32);
            label18.TabIndex = 39;
            label18.Text = "Contratos";
            // 
            // FormContratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanelContrato);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormContratos";
            Text = "Inventario";
            tableLayoutPanelContrato.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanelContrato;
        private Button buttonRegresar;
        private Panel panelFormularioHijo;
        private Label label18;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnGenerar;
        private ListView lstContratos;
        private ColumnHeader columnID;
        private ColumnHeader columnCantidad;
        private ColumnHeader columnFechaInicio;
        private ColumnHeader columnFechaFin;
        private ColumnHeader columnHeader1;
    }
}