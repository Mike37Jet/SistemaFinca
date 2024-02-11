namespace SistemaFinca
{
    partial class FormGestionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionUsuario));
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonEliminar = new Button();
            buttonRegistrar = new Button();
            buttonRestablecerContraseña = new Button();
            buttonInforme = new Button();
            buttonActualizar = new Button();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            label2 = new Label();
            textBuscarCliente = new TextBox();
            Usuarios = new ListBox();
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
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6153851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.0769234F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.4228458F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.6913834F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(buttonEliminar, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonRegistrar, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonRestablecerContraseña, 4, 0);
            tableLayoutPanel1.Controls.Add(buttonInforme, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonActualizar, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonRegresar, 6, 0);
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
            buttonEliminar.Location = new Point(53, 0);
            buttonEliminar.Margin = new Padding(0);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(53, 45);
            buttonEliminar.TabIndex = 11;
            buttonEliminar.TextAlign = ContentAlignment.BottomCenter;
            buttonEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Dock = DockStyle.Fill;
            buttonRegistrar.Image = (Image)resources.GetObject("buttonRegistrar.Image");
            buttonRegistrar.Location = new Point(0, 0);
            buttonRegistrar.Margin = new Padding(0);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(53, 45);
            buttonRegistrar.TabIndex = 6;
            buttonRegistrar.TextAlign = ContentAlignment.BottomCenter;
            buttonRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click_1;
            // 
            // buttonRestablecerContraseña
            // 
            buttonRestablecerContraseña.Dock = DockStyle.Fill;
            buttonRestablecerContraseña.Image = (Image)resources.GetObject("buttonRestablecerContraseña.Image");
            buttonRestablecerContraseña.Location = new Point(214, 0);
            buttonRestablecerContraseña.Margin = new Padding(0);
            buttonRestablecerContraseña.Name = "buttonRestablecerContraseña";
            buttonRestablecerContraseña.Size = new Size(57, 45);
            buttonRestablecerContraseña.TabIndex = 9;
            buttonRestablecerContraseña.TextAlign = ContentAlignment.BottomCenter;
            buttonRestablecerContraseña.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRestablecerContraseña.UseVisualStyleBackColor = true;
            buttonRestablecerContraseña.Click += buttonRestablecerContraseña_Click;
            // 
            // buttonInforme
            // 
            buttonInforme.Dock = DockStyle.Fill;
            buttonInforme.Image = (Image)resources.GetObject("buttonInforme.Image");
            buttonInforme.Location = new Point(159, 0);
            buttonInforme.Margin = new Padding(0);
            buttonInforme.Name = "buttonInforme";
            buttonInforme.Size = new Size(55, 45);
            buttonInforme.TabIndex = 8;
            buttonInforme.TextAlign = ContentAlignment.BottomCenter;
            buttonInforme.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonInforme.UseVisualStyleBackColor = true;
            buttonInforme.Click += buttonGenerarInforme_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Dock = DockStyle.Fill;
            buttonActualizar.Image = (Image)resources.GetObject("buttonActualizar.Image");
            buttonActualizar.Location = new Point(106, 0);
            buttonActualizar.Margin = new Padding(0);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(53, 45);
            buttonActualizar.TabIndex = 7;
            buttonActualizar.TextAlign = ContentAlignment.BottomCenter;
            buttonActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Dock = DockStyle.Fill;
            buttonRegresar.Location = new Point(502, 3);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(145, 39);
            buttonRegresar.TabIndex = 10;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(label2);
            panelFormularioHijo.Controls.Add(textBuscarCliente);
            panelFormularioHijo.Controls.Add(Usuarios);
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
            label2.Location = new Point(69, 91);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Buscar usuario";
            // 
            // textBuscarCliente
            // 
            textBuscarCliente.Location = new Point(69, 114);
            textBuscarCliente.Name = "textBuscarCliente";
            textBuscarCliente.Size = new Size(351, 27);
            textBuscarCliente.TabIndex = 4;
            // 
            // Usuarios
            // 
            Usuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Usuarios.FormattingEnabled = true;
            Usuarios.Location = new Point(69, 178);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(512, 244);
            Usuarios.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 26);
            label1.Name = "label1";
            label1.Size = new Size(111, 27);
            label1.TabIndex = 5;
            label1.Text = "Usuarios";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormGestionUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 504);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionUsuario";
            Text = "Inventario";
            tableLayoutPanel1.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonRestablecerContraseña;
        private Button buttonInforme;
        private Button buttonActualizar;
        private Button buttonRegistrar;
        private Panel panelFormularioHijo;
        private Label label1;
        private ListBox Usuarios;
        private Label label2;
        private TextBox textBuscarCliente;
        private Button buttonEliminar;
        private Button buttonRegresar;
    }
}