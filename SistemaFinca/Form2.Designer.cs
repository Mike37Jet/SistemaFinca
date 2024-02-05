namespace SistemaFinca
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelEncabezado = new Panel();
            buttonCerrar = new Button();
            buttonMaximizar = new Button();
            labelMenuPrincipal = new Label();
            buttonMinimizar = new Button();
            panel1 = new Panel();
            panelMenu = new Panel();
            buttonZonasPastoreo = new Button();
            buttonInventario = new Button();
            buttonVentas = new Button();
            buttonGestionGanadera = new Button();
            buttonAdministracion = new Button();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonSalir = new Button();
            panelFormularioHijo = new Panel();
            pictureLogo = new PictureBox();
            panelEncabezado.SuspendLayout();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFormularioHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panelEncabezado
            // 
            panelEncabezado.BackColor = Color.FromArgb(0, 122, 204);
            panelEncabezado.Controls.Add(buttonCerrar);
            panelEncabezado.Controls.Add(buttonMaximizar);
            panelEncabezado.Controls.Add(labelMenuPrincipal);
            panelEncabezado.Controls.Add(buttonMinimizar);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(900, 46);
            panelEncabezado.TabIndex = 0;
            panelEncabezado.MouseDown += panelEncabezado_MouseDown;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrar.FlatAppearance.BorderSize = 0;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Image = (Image)resources.GetObject("buttonCerrar.Image");
            buttonCerrar.Location = new Point(858, 7);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(31, 31);
            buttonCerrar.TabIndex = 2;
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // buttonMaximizar
            // 
            buttonMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximizar.FlatAppearance.BorderSize = 0;
            buttonMaximizar.FlatStyle = FlatStyle.Flat;
            buttonMaximizar.Image = (Image)resources.GetObject("buttonMaximizar.Image");
            buttonMaximizar.Location = new Point(821, 7);
            buttonMaximizar.Name = "buttonMaximizar";
            buttonMaximizar.Size = new Size(31, 31);
            buttonMaximizar.TabIndex = 3;
            buttonMaximizar.UseVisualStyleBackColor = true;
            buttonMaximizar.Click += buttonMaximizar_Click;
            // 
            // labelMenuPrincipal
            // 
            labelMenuPrincipal.AutoSize = true;
            labelMenuPrincipal.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMenuPrincipal.Location = new Point(12, 12);
            labelMenuPrincipal.Name = "labelMenuPrincipal";
            labelMenuPrincipal.Size = new Size(114, 18);
            labelMenuPrincipal.TabIndex = 0;
            labelMenuPrincipal.Text = "Menu Principal";
            labelMenuPrincipal.Click += label1_Click;
            // 
            // buttonMinimizar
            // 
            buttonMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimizar.FlatAppearance.BorderSize = 0;
            buttonMinimizar.FlatStyle = FlatStyle.Flat;
            buttonMinimizar.Image = (Image)resources.GetObject("buttonMinimizar.Image");
            buttonMinimizar.Location = new Point(784, 7);
            buttonMinimizar.Name = "buttonMinimizar";
            buttonMinimizar.Size = new Size(31, 31);
            buttonMinimizar.TabIndex = 1;
            buttonMinimizar.UseVisualStyleBackColor = true;
            buttonMinimizar.Click += buttonMinimizar_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 504);
            panel1.TabIndex = 1;
            // 
            // panelMenu
            // 
            panelMenu.AccessibleRole = AccessibleRole.Document;
            panelMenu.BackColor = Color.FromArgb(15, 15, 15);
            panelMenu.Controls.Add(buttonZonasPastoreo);
            panelMenu.Controls.Add(buttonInventario);
            panelMenu.Controls.Add(buttonVentas);
            panelMenu.Controls.Add(buttonGestionGanadera);
            panelMenu.Controls.Add(buttonAdministracion);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(buttonSalir);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 46);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 504);
            panelMenu.TabIndex = 2;
            // 
            // buttonZonasPastoreo
            // 
            buttonZonasPastoreo.Dock = DockStyle.Top;
            buttonZonasPastoreo.FlatAppearance.BorderSize = 0;
            buttonZonasPastoreo.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonZonasPastoreo.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonZonasPastoreo.FlatStyle = FlatStyle.Flat;
            buttonZonasPastoreo.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonZonasPastoreo.ForeColor = Color.Silver;
            buttonZonasPastoreo.Image = (Image)resources.GetObject("buttonZonasPastoreo.Image");
            buttonZonasPastoreo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonZonasPastoreo.Location = new Point(0, 325);
            buttonZonasPastoreo.Name = "buttonZonasPastoreo";
            buttonZonasPastoreo.Padding = new Padding(10, 0, 0, 0);
            buttonZonasPastoreo.Size = new Size(250, 50);
            buttonZonasPastoreo.TabIndex = 4;
            buttonZonasPastoreo.Text = "Zonas de Pastoreo";
            buttonZonasPastoreo.TextAlign = ContentAlignment.MiddleLeft;
            buttonZonasPastoreo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonZonasPastoreo.UseVisualStyleBackColor = true;
            buttonZonasPastoreo.Click += buttonZonasPastoreo_Click;
            // 
            // buttonInventario
            // 
            buttonInventario.Dock = DockStyle.Top;
            buttonInventario.FlatAppearance.BorderSize = 0;
            buttonInventario.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonInventario.FlatStyle = FlatStyle.Flat;
            buttonInventario.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInventario.ForeColor = Color.Silver;
            buttonInventario.Image = (Image)resources.GetObject("buttonInventario.Image");
            buttonInventario.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInventario.Location = new Point(0, 275);
            buttonInventario.Name = "buttonInventario";
            buttonInventario.Padding = new Padding(10, 0, 0, 0);
            buttonInventario.Size = new Size(250, 50);
            buttonInventario.TabIndex = 3;
            buttonInventario.Text = "Inventario";
            buttonInventario.TextAlign = ContentAlignment.MiddleLeft;
            buttonInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInventario.UseVisualStyleBackColor = true;
            buttonInventario.Click += buttonInventario_Click;
            // 
            // buttonVentas
            // 
            buttonVentas.Dock = DockStyle.Top;
            buttonVentas.FlatAppearance.BorderSize = 0;
            buttonVentas.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonVentas.FlatStyle = FlatStyle.Flat;
            buttonVentas.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVentas.ForeColor = Color.Silver;
            buttonVentas.Image = (Image)resources.GetObject("buttonVentas.Image");
            buttonVentas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonVentas.Location = new Point(0, 225);
            buttonVentas.Name = "buttonVentas";
            buttonVentas.Padding = new Padding(10, 0, 0, 0);
            buttonVentas.Size = new Size(250, 50);
            buttonVentas.TabIndex = 2;
            buttonVentas.Text = "Ventas";
            buttonVentas.TextAlign = ContentAlignment.MiddleLeft;
            buttonVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVentas.UseVisualStyleBackColor = true;
            buttonVentas.Click += buttonVentas_Click;
            // 
            // buttonGestionGanadera
            // 
            buttonGestionGanadera.Dock = DockStyle.Top;
            buttonGestionGanadera.FlatAppearance.BorderSize = 0;
            buttonGestionGanadera.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonGestionGanadera.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonGestionGanadera.FlatStyle = FlatStyle.Flat;
            buttonGestionGanadera.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGestionGanadera.ForeColor = Color.Silver;
            buttonGestionGanadera.Image = (Image)resources.GetObject("buttonGestionGanadera.Image");
            buttonGestionGanadera.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGestionGanadera.Location = new Point(0, 175);
            buttonGestionGanadera.Name = "buttonGestionGanadera";
            buttonGestionGanadera.Padding = new Padding(10, 0, 0, 0);
            buttonGestionGanadera.Size = new Size(250, 50);
            buttonGestionGanadera.TabIndex = 1;
            buttonGestionGanadera.Text = "Gestión Ganadera";
            buttonGestionGanadera.TextAlign = ContentAlignment.MiddleLeft;
            buttonGestionGanadera.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGestionGanadera.UseVisualStyleBackColor = true;
            buttonGestionGanadera.Click += buttonGestionGanadera_Click;
            // 
            // buttonAdministracion
            // 
            buttonAdministracion.Dock = DockStyle.Top;
            buttonAdministracion.FlatAppearance.BorderSize = 0;
            buttonAdministracion.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonAdministracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonAdministracion.FlatStyle = FlatStyle.Flat;
            buttonAdministracion.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdministracion.ForeColor = Color.Silver;
            buttonAdministracion.Image = (Image)resources.GetObject("buttonAdministracion.Image");
            buttonAdministracion.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdministracion.Location = new Point(0, 125);
            buttonAdministracion.Name = "buttonAdministracion";
            buttonAdministracion.Padding = new Padding(10, 0, 0, 0);
            buttonAdministracion.Size = new Size(250, 50);
            buttonAdministracion.TabIndex = 0;
            buttonAdministracion.Text = "Administración";
            buttonAdministracion.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdministracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdministracion.UseVisualStyleBackColor = true;
            buttonAdministracion.Click += buttonAdministracion_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(109, 98);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 4;
            label4.Text = "     Online";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(112, 72);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "20 Años";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(112, 25);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Administrador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(112, 51);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Miguel Mendosa";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonSalir
            // 
            buttonSalir.Dock = DockStyle.Bottom;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalir.ForeColor = Color.Silver;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalir.Location = new Point(0, 454);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Padding = new Padding(10, 0, 0, 0);
            buttonSalir.Size = new Size(250, 50);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Cerrar Sesión";
            buttonSalir.TextAlign = ContentAlignment.MiddleLeft;
            buttonSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.BackColor = SystemColors.ActiveCaption;
            panelFormularioHijo.Controls.Add(pictureLogo);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(250, 46);
            panelFormularioHijo.MinimumSize = new Size(650, 504);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(650, 504);
            panelFormularioHijo.TabIndex = 4;
            // 
            // pictureLogo
            // 
            pictureLogo.Anchor = AnchorStyles.None;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(183, 95);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(300, 300);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 4;
            pictureLogo.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(panelFormularioHijo);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Controls.Add(panelEncabezado);
            Name = "FormMenu";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FormMenu_Load;
            Resize += FormMenu_Resize;
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFormularioHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEncabezado;
        private Label labelMenuPrincipal;
        private Button buttonCerrar;
        private Button buttonMaximizar;
        private Button buttonMinimizar;
        private Panel panel1;
        private Panel panelMenu;
        private Button buttonInventario;
        private Button buttonVentas;
        private Button buttonGestionGanadera;
        private Button buttonAdministracion;
        private Panel panel2;
        private Button buttonSalir;
        private Button buttonZonasPastoreo;
        private Panel panelFormularioHijo;
        private PictureBox pictureLogo;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}