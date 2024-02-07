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
            panelFormularioHijo = new Panel();
            buttonRegresar = new Button();
            label1 = new Label();
            PanelMenuHerAgrGan = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            buttonRegistrar = new Button();
            panelFormularioHijo.SuspendLayout();
            PanelMenuHerAgrGan.SuspendLayout();
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
            panelFormularioHijo.Controls.Add(buttonRegresar);
            panelFormularioHijo.Controls.Add(label1);
            panelFormularioHijo.Controls.Add(PanelMenuHerAgrGan);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(650, 504);
            panelFormularioHijo.TabIndex = 0;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRegresar.Location = new Point(544, 463);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(94, 29);
            buttonRegresar.TabIndex = 5;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 14);
            label1.Name = "label1";
            label1.Size = new Size(579, 27);
            label1.TabIndex = 4;
            label1.Text = "Inventario de Herramientas Agrícolas y Ganaderas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // PanelMenuHerAgrGan
            // 
            PanelMenuHerAgrGan.Anchor = AnchorStyles.None;
            PanelMenuHerAgrGan.ColumnCount = 2;
            PanelMenuHerAgrGan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelMenuHerAgrGan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelMenuHerAgrGan.Controls.Add(button4, 1, 1);
            PanelMenuHerAgrGan.Controls.Add(button3, 0, 1);
            PanelMenuHerAgrGan.Controls.Add(button2, 1, 0);
            PanelMenuHerAgrGan.Controls.Add(buttonRegistrar, 0, 0);
            PanelMenuHerAgrGan.Location = new Point(50, 57);
            PanelMenuHerAgrGan.Name = "PanelMenuHerAgrGan";
            PanelMenuHerAgrGan.RowCount = 2;
            PanelMenuHerAgrGan.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelMenuHerAgrGan.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelMenuHerAgrGan.Size = new Size(550, 390);
            PanelMenuHerAgrGan.TabIndex = 3;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(278, 198);
            button4.Name = "button4";
            button4.Size = new Size(269, 189);
            button4.TabIndex = 3;
            button4.Text = "Eliminar";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(3, 198);
            button3.Name = "button3";
            button3.Size = new Size(269, 189);
            button3.TabIndex = 2;
            button3.Text = "Actualizar";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(278, 3);
            button2.Name = "button2";
            button2.Size = new Size(269, 189);
            button2.TabIndex = 1;
            button2.Text = "Consultar";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Dock = DockStyle.Fill;
            buttonRegistrar.Image = (Image)resources.GetObject("buttonRegistrar.Image");
            buttonRegistrar.Location = new Point(3, 3);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(269, 189);
            buttonRegistrar.TabIndex = 0;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.TextAlign = ContentAlignment.BottomCenter;
            buttonRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // FormHerramientasAgricolasGanaderas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 504);
            Controls.Add(panelFormularioHijo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHerramientasAgricolasGanaderas";
            Text = "Inventario";
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            PanelMenuHerAgrGan.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelFormularioHijo;
        private TableLayoutPanel PanelMenuHerAgrGan;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button buttonRegistrar;
        private Button buttonRegresar;
        private Label label1;
    }
}