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
            listView1 = new ListView();
            columnID = new ColumnHeader();
            columnNombre = new ColumnHeader();
            columnApellidos = new ColumnHeader();
            columnTelefono = new ColumnHeader();
            columnEmail = new ColumnHeader();
            columnRol = new ColumnHeader();
            label2 = new Label();
            textBuscarCliente = new TextBox();
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
            buttonEliminar.MouseHover += buttonEliminar_MouseHover;
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
            buttonRegistrar.MouseHover += buttonRegistrar_MouseHover;
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
            buttonRestablecerContraseña.MouseHover += buttonRestablecerContraseña_MouseHover;
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
            buttonInforme.MouseHover += buttonInforme_MouseHover;
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
            buttonActualizar.MouseHover += buttonActualizar_MouseHover;
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
            panelFormularioHijo.Controls.Add(listView1);
            panelFormularioHijo.Controls.Add(label2);
            panelFormularioHijo.Controls.Add(textBuscarCliente);
            panelFormularioHijo.Controls.Add(label1);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(650, 459);
            panelFormularioHijo.TabIndex = 8;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnID, columnNombre, columnApellidos, columnTelefono, columnEmail, columnRol });
            listView1.Location = new Point(63, 175);
            listView1.Name = "listView1";
            listView1.Size = new Size(524, 249);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnID
            // 
            columnID.Text = "CI";
            columnID.Width = 80;
            // 
            // columnNombre
            // 
            columnNombre.Text = "Nombre";
            columnNombre.Width = 80;
            // 
            // columnApellidos
            // 
            columnApellidos.Text = "Apellidos";
            columnApellidos.Width = 80;
            // 
            // columnTelefono
            // 
            columnTelefono.Text = "Teléfono";
            columnTelefono.Width = 80;
            // 
            // columnEmail
            // 
            columnEmail.Text = "E - mail";
            columnEmail.Width = 80;
            // 
            // columnRol
            // 
            columnRol.Text = "Rol";
            columnRol.Width = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 91);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Buscar usuario";
            // 
            // textBuscarCliente
            // 
            textBuscarCliente.Location = new Point(63, 114);
            textBuscarCliente.Name = "textBuscarCliente";
            textBuscarCliente.Size = new Size(351, 27);
            textBuscarCliente.TabIndex = 4;
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
        private Label label2;
        private TextBox textBuscarCliente;
        private Button buttonEliminar;
        private Button buttonRegresar;
        private ListView listView1;
        private ColumnHeader columnID;
        private ColumnHeader columnNombre;
        private ColumnHeader columnApellidos;
        private ColumnHeader columnTelefono;
        private ColumnHeader columnEmail;
        private ColumnHeader columnRol;
    }
}