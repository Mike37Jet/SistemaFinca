namespace SistemaFinca
{
    partial class FormRetiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetiros));
            tableLayoutPanel2 = new TableLayoutPanel();
            panelFormularioHijo = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEliminar = new Button();
            btnRegistrar = new Button();
            btnRegresar = new Button();
            panelHijoPagos = new Panel();
            lstRetiros = new ListView();
            columnCantidad = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label18 = new Label();
            tableLayoutPanelContrato = new TableLayoutPanel();
            buttonRegresar = new Button();
            panelFormularioHijo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelHijoPagos.SuspendLayout();
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
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(tableLayoutPanel1);
            panelFormularioHijo.Controls.Add(panelHijoPagos);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Margin = new Padding(3, 2, 3, 2);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(895, 541);
            panelFormularioHijo.TabIndex = 8;
         
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
            tableLayoutPanel1.Controls.Add(btnEliminar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnRegistrar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnRegresar, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 491);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(895, 50);
            tableLayoutPanel1.TabIndex = 50;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(95, 0);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 50);
            btnEliminar.TabIndex = 16;
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Dock = DockStyle.Fill;
            btnRegistrar.Image = (Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.Location = new Point(0, 0);
            btnRegistrar.Margin = new Padding(0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(95, 50);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // btnRegresar
            // 
            btnRegresar.Dock = DockStyle.Fill;
            btnRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(680, 2);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(212, 46);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // panelHijoPagos
            // 
            panelHijoPagos.Controls.Add(lstRetiros);
            panelHijoPagos.Controls.Add(label18);
            panelHijoPagos.Dock = DockStyle.Fill;
            panelHijoPagos.Location = new Point(0, 0);
            panelHijoPagos.Name = "panelHijoPagos";
            panelHijoPagos.Size = new Size(895, 541);
            panelHijoPagos.TabIndex = 45;
            // 
            // lstRetiros
            // 
            lstRetiros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstRetiros.Columns.AddRange(new ColumnHeader[] { columnCantidad, columnHeader1, columnHeader2 });
            lstRetiros.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstRetiros.Location = new Point(152, 105);
            lstRetiros.Margin = new Padding(3, 2, 3, 2);
            lstRetiros.Name = "lstRetiros";
            lstRetiros.Size = new Size(590, 325);
            lstRetiros.TabIndex = 50;
            lstRetiros.UseCompatibleStateImageBehavior = false;
            lstRetiros.View = View.Details;
            // 
            // columnCantidad
            // 
            columnCantidad.Text = "Cantidad de Retiro";
            columnCantidad.Width = 140;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Estado";
            columnHeader2.Width = 120;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(393, 43);
            label18.Name = "label18";
            label18.Size = new Size(109, 32);
            label18.TabIndex = 44;
            label18.Text = "Retiros";
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
            tableLayoutPanelContrato.Dock = DockStyle.Bottom;
            tableLayoutPanelContrato.Location = new Point(0, 0);
            tableLayoutPanelContrato.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanelContrato.Name = "tableLayoutPanelContrato";
            tableLayoutPanelContrato.RowCount = 1;
            tableLayoutPanelContrato.Size = new Size(200, 100);
            tableLayoutPanelContrato.TabIndex = 0;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Dock = DockStyle.Fill;
            buttonRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(153, 2);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(44, 96);
            buttonRegresar.TabIndex = 5;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            // 
            // FormRetiros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(panelFormularioHijo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRetiros";
            Text = "Inventario";
            panelFormularioHijo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelHijoPagos.ResumeLayout(false);
            panelHijoPagos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelFormularioHijo;
        private Panel panelHijoPagos;
        private Label label18;
        private TableLayoutPanel tableLayoutPanelContrato;
        private Button buttonRegresar;
        private ListView lstRetiros;
        private ColumnHeader columnCantidad;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEliminar;
        private Button btnRegistrar;
        private Button btnRegresar;
    }
}