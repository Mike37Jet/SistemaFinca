namespace SistemaFinca
{
    partial class FormHerramientasAgricolasGanaderas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHerramientasAgricolasGanaderas));
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonEliminar = new Button();
            buttonBuscar = new Button();
            buttonActualizar = new Button();
            buttonRegistrar = new Button();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            Herramientas = new ListBox();
            label1 = new Label();
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
            tableLayoutPanel1.Controls.Add(buttonEliminar, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonBuscar, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonActualizar, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonRegistrar, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonRegresar, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 459);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(650, 45);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Dock = DockStyle.Fill;
            buttonEliminar.Image = (Image)resources.GetObject("buttonEliminar.Image");
            buttonEliminar.Location = new Point(207, 0);
            buttonEliminar.Margin = new Padding(0);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(72, 45);
            buttonEliminar.TabIndex = 9;
            buttonEliminar.TextAlign = ContentAlignment.BottomCenter;
            buttonEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Dock = DockStyle.Fill;
            buttonBuscar.Image = (Image)resources.GetObject("buttonBuscar.Image");
            buttonBuscar.Location = new Point(138, 0);
            buttonBuscar.Margin = new Padding(0);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(69, 45);
            buttonBuscar.TabIndex = 8;
            buttonBuscar.TextAlign = ContentAlignment.BottomCenter;
            buttonBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Dock = DockStyle.Fill;
            buttonActualizar.Image = (Image)resources.GetObject("buttonActualizar.Image");
            buttonActualizar.Location = new Point(69, 0);
            buttonActualizar.Margin = new Padding(0);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(69, 45);
            buttonActualizar.TabIndex = 7;
            buttonActualizar.TextAlign = ContentAlignment.BottomCenter;
            buttonActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Dock = DockStyle.Fill;
            buttonRegistrar.Image = (Image)resources.GetObject("buttonRegistrar.Image");
            buttonRegistrar.Location = new Point(0, 0);
            buttonRegistrar.Margin = new Padding(0);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(69, 45);
            buttonRegistrar.TabIndex = 6;
            buttonRegistrar.TextAlign = ContentAlignment.BottomCenter;
            buttonRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click_1;
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
            panelFormularioHijo.Controls.Add(Herramientas);
            panelFormularioHijo.Controls.Add(label1);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(650, 459);
            panelFormularioHijo.TabIndex = 8;
            // 
            // Herramientas
            // 
            Herramientas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Herramientas.FormattingEnabled = true;
            Herramientas.Location = new Point(69, 78);
            Herramientas.Name = "Herramientas";
            Herramientas.Size = new Size(500, 344);
            Herramientas.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 28);
            label1.Name = "label1";
            label1.Size = new Size(426, 27);
            label1.TabIndex = 5;
            label1.Text = "Herramientas Agrícolas y Ganaderas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormHerramientasAgricolasGanaderas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 504);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHerramientasAgricolasGanaderas";
            Text = "Inventario";
            tableLayoutPanel1.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonEliminar;
        private Button buttonBuscar;
        private Button buttonActualizar;
        private Button buttonRegistrar;
        private Button buttonRegresar;
        private Panel panelFormularioHijo;
        private ListBox Herramientas;
        private Label label1;
    }
}