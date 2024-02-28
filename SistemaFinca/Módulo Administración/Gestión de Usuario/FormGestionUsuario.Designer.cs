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
            buttonBuscar = new Button();
            buttonEliminar = new Button();
            buttonRegistrar = new Button();
            buttonInforme = new Button();
            buttonActualizar = new Button();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            listUsuarios = new ListView();
            columnID = new ColumnHeader();
            columnNombre = new ColumnHeader();
            columnApellidos = new ColumnHeader();
            columnTelefono = new ColumnHeader();
            columnCorreo = new ColumnHeader();
            columnRol = new ColumnHeader();
            columnUsuario = new ColumnHeader();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tableLayoutPanel1.Controls.Add(buttonBuscar, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonEliminar, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonRegistrar, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonInforme, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonActualizar, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonRegresar, 6, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 541);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(895, 50);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Dock = DockStyle.Fill;
            buttonBuscar.Image = (Image)resources.GetObject("buttonBuscar.Image");
            buttonBuscar.Location = new Point(80, 0);
            buttonBuscar.Margin = new Padding(0);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(80, 50);
            buttonBuscar.TabIndex = 12;
            buttonBuscar.TextAlign = ContentAlignment.BottomCenter;
            buttonBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            buttonBuscar.MouseHover += buttonBuscar_MouseHover;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Dock = DockStyle.Fill;
            buttonEliminar.Image = (Image)resources.GetObject("buttonEliminar.Image");
            buttonEliminar.Location = new Point(160, 0);
            buttonEliminar.Margin = new Padding(0);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(80, 50);
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
            buttonRegistrar.Size = new Size(80, 50);
            buttonRegistrar.TabIndex = 6;
            buttonRegistrar.TextAlign = ContentAlignment.BottomCenter;
            buttonRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click_1;
            buttonRegistrar.MouseHover += buttonRegistrar_MouseHover;
            // 
            // buttonInforme
            // 
            buttonInforme.Dock = DockStyle.Fill;
            buttonInforme.Image = (Image)resources.GetObject("buttonInforme.Image");
            buttonInforme.Location = new Point(324, 0);
            buttonInforme.Margin = new Padding(0);
            buttonInforme.Name = "buttonInforme";
            buttonInforme.Size = new Size(87, 50);
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
            buttonActualizar.Location = new Point(240, 0);
            buttonActualizar.Margin = new Padding(0);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(84, 50);
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
            buttonRegresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(762, 2);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(130, 46);
            buttonRegresar.TabIndex = 10;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(listUsuarios);
            panelFormularioHijo.Controls.Add(label1);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Margin = new Padding(3, 2, 3, 2);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(895, 541);
            panelFormularioHijo.TabIndex = 8;
            // 
            // listUsuarios
            // 
            listUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listUsuarios.Columns.AddRange(new ColumnHeader[] { columnID, columnNombre, columnApellidos, columnTelefono, columnCorreo, columnRol, columnUsuario });
            listUsuarios.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listUsuarios.Location = new Point(51, 84);
            listUsuarios.Margin = new Padding(3, 2, 3, 2);
            listUsuarios.Name = "listUsuarios";
            listUsuarios.Size = new Size(785, 385);
            listUsuarios.TabIndex = 7;
            listUsuarios.UseCompatibleStateImageBehavior = false;
            listUsuarios.View = View.Details;
            listUsuarios.SelectedIndexChanged += listUsuarios_SelectedIndexChanged;
            // 
            // columnID
            // 
            columnID.Text = "CI";
            columnID.Width = 80;
            // 
            // columnNombre
            // 
            columnNombre.Text = "Nombre";
            columnNombre.Width = 120;
            // 
            // columnApellidos
            // 
            columnApellidos.Text = "Apellidos";
            columnApellidos.Width = 120;
            // 
            // columnTelefono
            // 
            columnTelefono.Text = "Teléfono";
            columnTelefono.Width = 120;
            // 
            // columnCorreo
            // 
            columnCorreo.Text = "Correo Electrónico";
            columnCorreo.Width = 150;
            // 
            // columnRol
            // 
            columnRol.Text = "Rol";
            columnRol.Width = 80;
            // 
            // columnUsuario
            // 
            columnUsuario.Text = "Nombre de usuario";
            columnUsuario.Width = 150;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 20);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 5;
            label1.Text = "Usuarios";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormGestionUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 591);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button buttonInforme;
        private Button buttonActualizar;
        private Button buttonRegistrar;
        private Panel panelFormularioHijo;
        private Label label1;
        private Label label2;
        private TextBox textBuscarCliente;
        private Button buttonEliminar;
        private Button buttonRegresar;
        private ListView listUsuarios;
        private ColumnHeader columnID;
        private ColumnHeader columnNombre;
        private ColumnHeader columnApellidos;
        private ColumnHeader columnTelefono;
        private ColumnHeader columnCorreo;
        private ColumnHeader columnRol;
        private Button buttonBuscar;
        private ColumnHeader columnUsuario;
    }
}