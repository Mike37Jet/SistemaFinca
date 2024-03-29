﻿namespace SistemaFinca
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
            buttonAuditoria = new Button();
            panel3 = new Panel();
            subPanelZonasPastoreo = new Panel();
            buttonArriendoZona = new Button();
            buttonRiegoZona = new Button();
            buttonFumigarZona = new Button();
            buttonRegistrarZonas = new Button();
            buttonZonasPastoreo = new Button();
            subPanelInventario = new Panel();
            buttonAliBov = new Button();
            buttonMedBov = new Button();
            buttonIndPers = new Button();
            buttonHerrAgrGan = new Button();
            buttonInventario = new Button();
            subPanelVenta = new Panel();
            buttonDeudores = new Button();
            buttonInformeAnalisis = new Button();
            buttonGestionPagos = new Button();
            buttonNotaVentas = new Button();
            buttonContratos = new Button();
            buttonVentas = new Button();
            subPanelGestionGanadera = new Panel();
            subPanelGanadoCarne = new Panel();
            buttonProcesoFaenamiento = new Button();
            buttonGanadoCarne = new Button();
            subPanelGanadoLechero = new Panel();
            buttonRegistroDeOrdeño = new Button();
            buttonProduccionDeLeche = new Button();
            buttonGanadoDeLeche = new Button();
            buttonGestionGanadera = new Button();
            buttonClientes = new Button();
            subPanelAdministracion = new Panel();
            buttonParametrosSistema = new Button();
            buttonGestionUsuario = new Button();
            buttonAdministracion = new Button();
            panel2 = new Panel();
            labelApellidos = new Label();
            labelNombres = new Label();
            labelUsuario = new Label();
            label4 = new Label();
            labelRol = new Label();
            pictureBox1 = new PictureBox();
            buttonSalir = new Button();
            panelFormularioHijo = new Panel();
            pictureLogo = new PictureBox();
            panelEncabezado.SuspendLayout();
            panelMenu.SuspendLayout();
            subPanelZonasPastoreo.SuspendLayout();
            subPanelInventario.SuspendLayout();
            subPanelVenta.SuspendLayout();
            subPanelGestionGanadera.SuspendLayout();
            subPanelGanadoCarne.SuspendLayout();
            subPanelGanadoLechero.SuspendLayout();
            subPanelAdministracion.SuspendLayout();
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
            panelEncabezado.Margin = new Padding(3, 2, 3, 2);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(1164, 40);
            panelEncabezado.TabIndex = 0;
            panelEncabezado.MouseDown += panelEncabezado_MouseDown;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrar.FlatAppearance.BorderSize = 0;
            buttonCerrar.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonCerrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonCerrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Image = (Image)resources.GetObject("buttonCerrar.Image");
            buttonCerrar.Location = new Point(1132, 7);
            buttonCerrar.Margin = new Padding(0);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(27, 25);
            buttonCerrar.TabIndex = 3;
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // buttonMaximizar
            // 
            buttonMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximizar.FlatAppearance.BorderSize = 0;
            buttonMaximizar.FlatAppearance.CheckedBackColor = Color.Transparent;
            buttonMaximizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMaximizar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMaximizar.FlatStyle = FlatStyle.Flat;
            buttonMaximizar.Image = (Image)resources.GetObject("buttonMaximizar.Image");
            buttonMaximizar.Location = new Point(1096, 5);
            buttonMaximizar.Margin = new Padding(3, 2, 3, 2);
            buttonMaximizar.Name = "buttonMaximizar";
            buttonMaximizar.Size = new Size(30, 28);
            buttonMaximizar.TabIndex = 2;
            buttonMaximizar.UseVisualStyleBackColor = true;
            buttonMaximizar.Click += buttonMaximizar_Click;
            // 
            // labelMenuPrincipal
            // 
            labelMenuPrincipal.AutoSize = true;
            labelMenuPrincipal.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMenuPrincipal.Location = new Point(12, 14);
            labelMenuPrincipal.Name = "labelMenuPrincipal";
            labelMenuPrincipal.Size = new Size(123, 16);
            labelMenuPrincipal.TabIndex = 0;
            labelMenuPrincipal.Text = "Finca San Rafael";
            // 
            // buttonMinimizar
            // 
            buttonMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimizar.FlatAppearance.BorderSize = 0;
            buttonMinimizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMinimizar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMinimizar.FlatStyle = FlatStyle.Flat;
            buttonMinimizar.Image = (Image)resources.GetObject("buttonMinimizar.Image");
            buttonMinimizar.Location = new Point(1060, 5);
            buttonMinimizar.Margin = new Padding(3, 2, 3, 2);
            buttonMinimizar.Name = "buttonMinimizar";
            buttonMinimizar.Size = new Size(30, 29);
            buttonMinimizar.TabIndex = 1;
            buttonMinimizar.UseVisualStyleBackColor = true;
            buttonMinimizar.Click += buttonMinimizar_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 591);
            panel1.TabIndex = 1;
            // 
            // panelMenu
            // 
            panelMenu.AccessibleRole = AccessibleRole.Document;
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(15, 15, 15);
            panelMenu.Controls.Add(buttonAuditoria);
            panelMenu.Controls.Add(panel3);
            panelMenu.Controls.Add(subPanelZonasPastoreo);
            panelMenu.Controls.Add(buttonZonasPastoreo);
            panelMenu.Controls.Add(subPanelInventario);
            panelMenu.Controls.Add(buttonInventario);
            panelMenu.Controls.Add(subPanelVenta);
            panelMenu.Controls.Add(buttonVentas);
            panelMenu.Controls.Add(subPanelGestionGanadera);
            panelMenu.Controls.Add(buttonGestionGanadera);
            panelMenu.Controls.Add(buttonClientes);
            panelMenu.Controls.Add(subPanelAdministracion);
            panelMenu.Controls.Add(buttonAdministracion);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(buttonSalir);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(269, 591);
            panelMenu.TabIndex = 2;
            // 
            // buttonAuditoria
            // 
            buttonAuditoria.Dock = DockStyle.Top;
            buttonAuditoria.FlatAppearance.BorderSize = 0;
            buttonAuditoria.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonAuditoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonAuditoria.FlatStyle = FlatStyle.Flat;
            buttonAuditoria.Font = new Font("Arial Rounded MT Bold", 10.2F);
            buttonAuditoria.ForeColor = Color.Silver;
            buttonAuditoria.Image = (Image)resources.GetObject("buttonAuditoria.Image");
            buttonAuditoria.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAuditoria.Location = new Point(0, 1010);
            buttonAuditoria.Margin = new Padding(3, 2, 3, 2);
            buttonAuditoria.Name = "buttonAuditoria";
            buttonAuditoria.Padding = new Padding(4, 0, 0, 0);
            buttonAuditoria.Size = new Size(252, 50);
            buttonAuditoria.TabIndex = 29;
            buttonAuditoria.Text = "Auditoría";
            buttonAuditoria.TextAlign = ContentAlignment.MiddleLeft;
            buttonAuditoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAuditoria.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 1060);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(252, 2);
            panel3.TabIndex = 28;
            // 
            // subPanelZonasPastoreo
            // 
            subPanelZonasPastoreo.BackColor = Color.FromArgb(25, 25, 25);
            subPanelZonasPastoreo.Controls.Add(buttonArriendoZona);
            subPanelZonasPastoreo.Controls.Add(buttonRiegoZona);
            subPanelZonasPastoreo.Controls.Add(buttonFumigarZona);
            subPanelZonasPastoreo.Controls.Add(buttonRegistrarZonas);
            subPanelZonasPastoreo.Dock = DockStyle.Top;
            subPanelZonasPastoreo.Location = new Point(0, 888);
            subPanelZonasPastoreo.Margin = new Padding(3, 2, 3, 2);
            subPanelZonasPastoreo.Name = "subPanelZonasPastoreo";
            subPanelZonasPastoreo.Size = new Size(252, 122);
            subPanelZonasPastoreo.TabIndex = 10;
            // 
            // buttonArriendoZona
            // 
            buttonArriendoZona.Dock = DockStyle.Top;
            buttonArriendoZona.FlatAppearance.BorderSize = 0;
            buttonArriendoZona.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonArriendoZona.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonArriendoZona.FlatStyle = FlatStyle.Flat;
            buttonArriendoZona.Font = new Font("Arial", 10.2F);
            buttonArriendoZona.ForeColor = Color.Silver;
            buttonArriendoZona.Location = new Point(0, 90);
            buttonArriendoZona.Margin = new Padding(3, 2, 3, 2);
            buttonArriendoZona.Name = "buttonArriendoZona";
            buttonArriendoZona.Padding = new Padding(18, 0, 0, 0);
            buttonArriendoZona.Size = new Size(252, 30);
            buttonArriendoZona.TabIndex = 24;
            buttonArriendoZona.Text = "Arriendo ";
            buttonArriendoZona.TextAlign = ContentAlignment.MiddleLeft;
            buttonArriendoZona.UseVisualStyleBackColor = true;
            buttonArriendoZona.Click += buttonArriendoZona_Click;
            // 
            // buttonRiegoZona
            // 
            buttonRiegoZona.Dock = DockStyle.Top;
            buttonRiegoZona.FlatAppearance.BorderSize = 0;
            buttonRiegoZona.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonRiegoZona.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonRiegoZona.FlatStyle = FlatStyle.Flat;
            buttonRiegoZona.Font = new Font("Arial", 10.2F);
            buttonRiegoZona.ForeColor = Color.Silver;
            buttonRiegoZona.Location = new Point(0, 60);
            buttonRiegoZona.Margin = new Padding(3, 2, 3, 2);
            buttonRiegoZona.Name = "buttonRiegoZona";
            buttonRiegoZona.Padding = new Padding(18, 0, 0, 0);
            buttonRiegoZona.Size = new Size(252, 30);
            buttonRiegoZona.TabIndex = 23;
            buttonRiegoZona.Text = "Riego";
            buttonRiegoZona.TextAlign = ContentAlignment.MiddleLeft;
            buttonRiegoZona.UseVisualStyleBackColor = true;
            buttonRiegoZona.Click += buttonRiegoZona_Click;
            // 
            // buttonFumigarZona
            // 
            buttonFumigarZona.Dock = DockStyle.Top;
            buttonFumigarZona.FlatAppearance.BorderSize = 0;
            buttonFumigarZona.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonFumigarZona.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonFumigarZona.FlatStyle = FlatStyle.Flat;
            buttonFumigarZona.Font = new Font("Arial", 10.2F);
            buttonFumigarZona.ForeColor = Color.Silver;
            buttonFumigarZona.Location = new Point(0, 30);
            buttonFumigarZona.Margin = new Padding(3, 2, 3, 2);
            buttonFumigarZona.Name = "buttonFumigarZona";
            buttonFumigarZona.Padding = new Padding(18, 0, 0, 0);
            buttonFumigarZona.Size = new Size(252, 30);
            buttonFumigarZona.TabIndex = 21;
            buttonFumigarZona.Text = "Fumigación";
            buttonFumigarZona.TextAlign = ContentAlignment.MiddleLeft;
            buttonFumigarZona.UseVisualStyleBackColor = true;
            buttonFumigarZona.Click += buttonSeguimientoActividad_Click;
            // 
            // buttonRegistrarZonas
            // 
            buttonRegistrarZonas.Dock = DockStyle.Top;
            buttonRegistrarZonas.FlatAppearance.BorderSize = 0;
            buttonRegistrarZonas.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonRegistrarZonas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonRegistrarZonas.FlatStyle = FlatStyle.Flat;
            buttonRegistrarZonas.Font = new Font("Arial", 10.2F);
            buttonRegistrarZonas.ForeColor = Color.Silver;
            buttonRegistrarZonas.Location = new Point(0, 0);
            buttonRegistrarZonas.Margin = new Padding(3, 2, 3, 2);
            buttonRegistrarZonas.Name = "buttonRegistrarZonas";
            buttonRegistrarZonas.Padding = new Padding(18, 0, 0, 0);
            buttonRegistrarZonas.Size = new Size(252, 30);
            buttonRegistrarZonas.TabIndex = 20;
            buttonRegistrarZonas.Text = "Registro";
            buttonRegistrarZonas.TextAlign = ContentAlignment.MiddleLeft;
            buttonRegistrarZonas.UseVisualStyleBackColor = true;
            buttonRegistrarZonas.Click += buttonGesZonPast_Click;
            // 
            // buttonZonasPastoreo
            // 
            buttonZonasPastoreo.Dock = DockStyle.Top;
            buttonZonasPastoreo.FlatAppearance.BorderSize = 0;
            buttonZonasPastoreo.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonZonasPastoreo.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonZonasPastoreo.FlatStyle = FlatStyle.Flat;
            buttonZonasPastoreo.Font = new Font("Arial Rounded MT Bold", 10.2F);
            buttonZonasPastoreo.ForeColor = Color.Silver;
            buttonZonasPastoreo.Image = (Image)resources.GetObject("buttonZonasPastoreo.Image");
            buttonZonasPastoreo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonZonasPastoreo.Location = new Point(0, 838);
            buttonZonasPastoreo.Margin = new Padding(3, 2, 3, 2);
            buttonZonasPastoreo.Name = "buttonZonasPastoreo";
            buttonZonasPastoreo.Padding = new Padding(4, 0, 0, 0);
            buttonZonasPastoreo.Size = new Size(252, 50);
            buttonZonasPastoreo.TabIndex = 19;
            buttonZonasPastoreo.Text = "Zonas de Pastoreo";
            buttonZonasPastoreo.TextAlign = ContentAlignment.MiddleLeft;
            buttonZonasPastoreo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonZonasPastoreo.UseVisualStyleBackColor = true;
            buttonZonasPastoreo.Click += buttonZonasPastoreo_Click;
            // 
            // subPanelInventario
            // 
            subPanelInventario.BackColor = Color.FromArgb(25, 25, 25);
            subPanelInventario.Controls.Add(buttonAliBov);
            subPanelInventario.Controls.Add(buttonMedBov);
            subPanelInventario.Controls.Add(buttonIndPers);
            subPanelInventario.Controls.Add(buttonHerrAgrGan);
            subPanelInventario.Dock = DockStyle.Top;
            subPanelInventario.Location = new Point(0, 716);
            subPanelInventario.Margin = new Padding(3, 2, 3, 2);
            subPanelInventario.Name = "subPanelInventario";
            subPanelInventario.Size = new Size(252, 122);
            subPanelInventario.TabIndex = 8;
            // 
            // buttonAliBov
            // 
            buttonAliBov.Dock = DockStyle.Top;
            buttonAliBov.FlatAppearance.BorderSize = 0;
            buttonAliBov.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonAliBov.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonAliBov.FlatStyle = FlatStyle.Flat;
            buttonAliBov.Font = new Font("Arial", 10.2F);
            buttonAliBov.ForeColor = Color.Silver;
            buttonAliBov.Location = new Point(0, 90);
            buttonAliBov.Margin = new Padding(3, 2, 3, 2);
            buttonAliBov.Name = "buttonAliBov";
            buttonAliBov.Padding = new Padding(18, 0, 0, 0);
            buttonAliBov.Size = new Size(252, 30);
            buttonAliBov.TabIndex = 18;
            buttonAliBov.Text = "Alimentos";
            buttonAliBov.TextAlign = ContentAlignment.MiddleLeft;
            buttonAliBov.UseVisualStyleBackColor = true;
            buttonAliBov.Click += buttonAliBov_Click;
            // 
            // buttonMedBov
            // 
            buttonMedBov.Dock = DockStyle.Top;
            buttonMedBov.FlatAppearance.BorderSize = 0;
            buttonMedBov.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonMedBov.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonMedBov.FlatStyle = FlatStyle.Flat;
            buttonMedBov.Font = new Font("Arial", 10.2F);
            buttonMedBov.ForeColor = Color.Silver;
            buttonMedBov.Location = new Point(0, 60);
            buttonMedBov.Margin = new Padding(3, 2, 3, 2);
            buttonMedBov.Name = "buttonMedBov";
            buttonMedBov.Padding = new Padding(18, 0, 0, 0);
            buttonMedBov.Size = new Size(252, 30);
            buttonMedBov.TabIndex = 17;
            buttonMedBov.Text = "Medicinas";
            buttonMedBov.TextAlign = ContentAlignment.MiddleLeft;
            buttonMedBov.UseVisualStyleBackColor = true;
            buttonMedBov.Click += buttonMedBov_Click;
            // 
            // buttonIndPers
            // 
            buttonIndPers.Dock = DockStyle.Top;
            buttonIndPers.FlatAppearance.BorderSize = 0;
            buttonIndPers.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonIndPers.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonIndPers.FlatStyle = FlatStyle.Flat;
            buttonIndPers.Font = new Font("Arial", 10.2F);
            buttonIndPers.ForeColor = Color.Silver;
            buttonIndPers.Location = new Point(0, 30);
            buttonIndPers.Margin = new Padding(3, 2, 3, 2);
            buttonIndPers.Name = "buttonIndPers";
            buttonIndPers.Padding = new Padding(18, 0, 0, 0);
            buttonIndPers.Size = new Size(252, 30);
            buttonIndPers.TabIndex = 16;
            buttonIndPers.Text = "Indumentarias";
            buttonIndPers.TextAlign = ContentAlignment.MiddleLeft;
            buttonIndPers.UseVisualStyleBackColor = true;
            buttonIndPers.Click += buttonIndPers_Click;
            // 
            // buttonHerrAgrGan
            // 
            buttonHerrAgrGan.Dock = DockStyle.Top;
            buttonHerrAgrGan.FlatAppearance.BorderSize = 0;
            buttonHerrAgrGan.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonHerrAgrGan.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonHerrAgrGan.FlatStyle = FlatStyle.Flat;
            buttonHerrAgrGan.Font = new Font("Arial", 10.2F);
            buttonHerrAgrGan.ForeColor = Color.Silver;
            buttonHerrAgrGan.Location = new Point(0, 0);
            buttonHerrAgrGan.Margin = new Padding(0);
            buttonHerrAgrGan.Name = "buttonHerrAgrGan";
            buttonHerrAgrGan.Padding = new Padding(18, 0, 0, 0);
            buttonHerrAgrGan.Size = new Size(252, 30);
            buttonHerrAgrGan.TabIndex = 15;
            buttonHerrAgrGan.Text = "Herramientas";
            buttonHerrAgrGan.TextAlign = ContentAlignment.MiddleLeft;
            buttonHerrAgrGan.UseVisualStyleBackColor = true;
            buttonHerrAgrGan.Click += buttonHerrAgrGan_Click;
            // 
            // buttonInventario
            // 
            buttonInventario.Dock = DockStyle.Top;
            buttonInventario.FlatAppearance.BorderSize = 0;
            buttonInventario.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonInventario.FlatStyle = FlatStyle.Flat;
            buttonInventario.Font = new Font("Arial Rounded MT Bold", 10.2F);
            buttonInventario.ForeColor = Color.Silver;
            buttonInventario.Image = (Image)resources.GetObject("buttonInventario.Image");
            buttonInventario.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInventario.Location = new Point(0, 666);
            buttonInventario.Margin = new Padding(3, 2, 3, 2);
            buttonInventario.Name = "buttonInventario";
            buttonInventario.Padding = new Padding(4, 0, 0, 0);
            buttonInventario.Size = new Size(252, 50);
            buttonInventario.TabIndex = 14;
            buttonInventario.Text = "Inventario";
            buttonInventario.TextAlign = ContentAlignment.MiddleLeft;
            buttonInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInventario.UseVisualStyleBackColor = true;
            buttonInventario.Click += buttonInventario_Click;
            // 
            // subPanelVenta
            // 
            subPanelVenta.BackColor = Color.FromArgb(25, 25, 25);
            subPanelVenta.Controls.Add(buttonDeudores);
            subPanelVenta.Controls.Add(buttonInformeAnalisis);
            subPanelVenta.Controls.Add(buttonGestionPagos);
            subPanelVenta.Controls.Add(buttonNotaVentas);
            subPanelVenta.Controls.Add(buttonContratos);
            subPanelVenta.Dock = DockStyle.Top;
            subPanelVenta.Location = new Point(0, 514);
            subPanelVenta.Margin = new Padding(3, 2, 3, 2);
            subPanelVenta.Name = "subPanelVenta";
            subPanelVenta.Size = new Size(252, 152);
            subPanelVenta.TabIndex = 9;
            // 
            // buttonDeudores
            // 
            buttonDeudores.Dock = DockStyle.Top;
            buttonDeudores.FlatAppearance.BorderSize = 0;
            buttonDeudores.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonDeudores.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonDeudores.FlatStyle = FlatStyle.Flat;
            buttonDeudores.Font = new Font("Arial", 10.2F);
            buttonDeudores.ForeColor = Color.Silver;
            buttonDeudores.Location = new Point(0, 120);
            buttonDeudores.Margin = new Padding(3, 2, 3, 2);
            buttonDeudores.Name = "buttonDeudores";
            buttonDeudores.Padding = new Padding(18, 0, 0, 0);
            buttonDeudores.Size = new Size(252, 30);
            buttonDeudores.TabIndex = 13;
            buttonDeudores.Text = "Clientes Morosos";
            buttonDeudores.TextAlign = ContentAlignment.MiddleLeft;
            buttonDeudores.UseVisualStyleBackColor = true;
            buttonDeudores.Click += buttonAlertas_Click;
            // 
            // buttonInformeAnalisis
            // 
            buttonInformeAnalisis.Dock = DockStyle.Top;
            buttonInformeAnalisis.FlatAppearance.BorderSize = 0;
            buttonInformeAnalisis.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonInformeAnalisis.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonInformeAnalisis.FlatStyle = FlatStyle.Flat;
            buttonInformeAnalisis.Font = new Font("Arial", 10.2F);
            buttonInformeAnalisis.ForeColor = Color.Silver;
            buttonInformeAnalisis.Location = new Point(0, 90);
            buttonInformeAnalisis.Margin = new Padding(3, 2, 3, 2);
            buttonInformeAnalisis.Name = "buttonInformeAnalisis";
            buttonInformeAnalisis.Padding = new Padding(18, 0, 0, 0);
            buttonInformeAnalisis.Size = new Size(252, 30);
            buttonInformeAnalisis.TabIndex = 11;
            buttonInformeAnalisis.Text = "Reportes y Análisis";
            buttonInformeAnalisis.TextAlign = ContentAlignment.MiddleLeft;
            buttonInformeAnalisis.UseVisualStyleBackColor = true;
            buttonInformeAnalisis.Click += buttonInformeAnalisis_Click;
            // 
            // buttonGestionPagos
            // 
            buttonGestionPagos.Dock = DockStyle.Top;
            buttonGestionPagos.FlatAppearance.BorderSize = 0;
            buttonGestionPagos.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonGestionPagos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonGestionPagos.FlatStyle = FlatStyle.Flat;
            buttonGestionPagos.Font = new Font("Arial", 10.2F);
            buttonGestionPagos.ForeColor = Color.Silver;
            buttonGestionPagos.Location = new Point(0, 60);
            buttonGestionPagos.Margin = new Padding(3, 2, 3, 2);
            buttonGestionPagos.Name = "buttonGestionPagos";
            buttonGestionPagos.Padding = new Padding(18, 0, 0, 0);
            buttonGestionPagos.Size = new Size(252, 30);
            buttonGestionPagos.TabIndex = 12;
            buttonGestionPagos.Text = "Retiros";
            buttonGestionPagos.TextAlign = ContentAlignment.MiddleLeft;
            buttonGestionPagos.UseVisualStyleBackColor = true;
            buttonGestionPagos.Click += buttonGestionPagos_Click;
            // 
            // buttonNotaVentas
            // 
            buttonNotaVentas.Dock = DockStyle.Top;
            buttonNotaVentas.FlatAppearance.BorderSize = 0;
            buttonNotaVentas.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonNotaVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonNotaVentas.FlatStyle = FlatStyle.Flat;
            buttonNotaVentas.Font = new Font("Arial", 10.2F);
            buttonNotaVentas.ForeColor = Color.Silver;
            buttonNotaVentas.Location = new Point(0, 30);
            buttonNotaVentas.Margin = new Padding(3, 2, 3, 2);
            buttonNotaVentas.Name = "buttonNotaVentas";
            buttonNotaVentas.Padding = new Padding(18, 0, 0, 0);
            buttonNotaVentas.Size = new Size(252, 30);
            buttonNotaVentas.TabIndex = 10;
            buttonNotaVentas.Text = "Notas de Venta";
            buttonNotaVentas.TextAlign = ContentAlignment.MiddleLeft;
            buttonNotaVentas.UseVisualStyleBackColor = true;
            buttonNotaVentas.Click += buttonNotaVentas_Click;
            // 
            // buttonContratos
            // 
            buttonContratos.Dock = DockStyle.Top;
            buttonContratos.FlatAppearance.BorderSize = 0;
            buttonContratos.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonContratos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonContratos.FlatStyle = FlatStyle.Flat;
            buttonContratos.Font = new Font("Arial", 10.2F);
            buttonContratos.ForeColor = Color.Silver;
            buttonContratos.Location = new Point(0, 0);
            buttonContratos.Margin = new Padding(3, 2, 3, 2);
            buttonContratos.Name = "buttonContratos";
            buttonContratos.Padding = new Padding(18, 0, 0, 0);
            buttonContratos.Size = new Size(252, 30);
            buttonContratos.TabIndex = 15;
            buttonContratos.Text = "Contratos";
            buttonContratos.TextAlign = ContentAlignment.MiddleLeft;
            buttonContratos.UseVisualStyleBackColor = true;
            buttonContratos.Click += buttonContratos_Click;
            // 
            // buttonVentas
            // 
            buttonVentas.Dock = DockStyle.Top;
            buttonVentas.FlatAppearance.BorderSize = 0;
            buttonVentas.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonVentas.FlatStyle = FlatStyle.Flat;
            buttonVentas.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVentas.ForeColor = Color.Silver;
            buttonVentas.Image = (Image)resources.GetObject("buttonVentas.Image");
            buttonVentas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonVentas.Location = new Point(0, 464);
            buttonVentas.Margin = new Padding(3, 2, 3, 2);
            buttonVentas.Name = "buttonVentas";
            buttonVentas.Padding = new Padding(4, 0, 0, 0);
            buttonVentas.Size = new Size(252, 50);
            buttonVentas.TabIndex = 9;
            buttonVentas.Text = "Ventas";
            buttonVentas.TextAlign = ContentAlignment.MiddleLeft;
            buttonVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVentas.UseVisualStyleBackColor = true;
            buttonVentas.Click += buttonVentas_Click;
            // 
            // subPanelGestionGanadera
            // 
            subPanelGestionGanadera.BackColor = Color.FromArgb(25, 25, 25);
            subPanelGestionGanadera.Controls.Add(subPanelGanadoCarne);
            subPanelGestionGanadera.Controls.Add(buttonGanadoCarne);
            subPanelGestionGanadera.Controls.Add(subPanelGanadoLechero);
            subPanelGestionGanadera.Controls.Add(buttonGanadoDeLeche);
            subPanelGestionGanadera.Dock = DockStyle.Top;
            subPanelGestionGanadera.Location = new Point(0, 312);
            subPanelGestionGanadera.Margin = new Padding(3, 2, 3, 2);
            subPanelGestionGanadera.Name = "subPanelGestionGanadera";
            subPanelGestionGanadera.Size = new Size(252, 152);
            subPanelGestionGanadera.TabIndex = 7;
            // 
            // subPanelGanadoCarne
            // 
            subPanelGanadoCarne.BackColor = Color.FromArgb(35, 35, 35);
            subPanelGanadoCarne.Controls.Add(buttonProcesoFaenamiento);
            subPanelGanadoCarne.Dock = DockStyle.Top;
            subPanelGanadoCarne.Location = new Point(0, 122);
            subPanelGanadoCarne.Margin = new Padding(3, 2, 3, 2);
            subPanelGanadoCarne.Name = "subPanelGanadoCarne";
            subPanelGanadoCarne.Size = new Size(252, 32);
            subPanelGanadoCarne.TabIndex = 10;
            // 
            // buttonProcesoFaenamiento
            // 
            buttonProcesoFaenamiento.Dock = DockStyle.Top;
            buttonProcesoFaenamiento.FlatAppearance.BorderSize = 0;
            buttonProcesoFaenamiento.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonProcesoFaenamiento.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonProcesoFaenamiento.FlatStyle = FlatStyle.Flat;
            buttonProcesoFaenamiento.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProcesoFaenamiento.ForeColor = Color.Silver;
            buttonProcesoFaenamiento.Location = new Point(0, 0);
            buttonProcesoFaenamiento.Margin = new Padding(3, 2, 3, 2);
            buttonProcesoFaenamiento.Name = "buttonProcesoFaenamiento";
            buttonProcesoFaenamiento.Padding = new Padding(44, 0, 0, 0);
            buttonProcesoFaenamiento.Size = new Size(252, 30);
            buttonProcesoFaenamiento.TabIndex = 7;
            buttonProcesoFaenamiento.Text = "Proceso de Faenamiento";
            buttonProcesoFaenamiento.TextAlign = ContentAlignment.MiddleLeft;
            buttonProcesoFaenamiento.UseVisualStyleBackColor = true;
            buttonProcesoFaenamiento.Click += buttonProcesoFaenamiento_Click;
            // 
            // buttonGanadoCarne
            // 
            buttonGanadoCarne.Dock = DockStyle.Top;
            buttonGanadoCarne.FlatAppearance.BorderSize = 0;
            buttonGanadoCarne.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonGanadoCarne.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonGanadoCarne.FlatStyle = FlatStyle.Flat;
            buttonGanadoCarne.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGanadoCarne.ForeColor = Color.Silver;
            buttonGanadoCarne.Location = new Point(0, 92);
            buttonGanadoCarne.Margin = new Padding(3, 2, 3, 2);
            buttonGanadoCarne.Name = "buttonGanadoCarne";
            buttonGanadoCarne.Padding = new Padding(18, 0, 0, 0);
            buttonGanadoCarne.Size = new Size(252, 30);
            buttonGanadoCarne.TabIndex = 8;
            buttonGanadoCarne.Text = "Ganado seco";
            buttonGanadoCarne.TextAlign = ContentAlignment.MiddleLeft;
            buttonGanadoCarne.UseVisualStyleBackColor = true;
            buttonGanadoCarne.Click += buttonGanadoCarne_Click;
            // 
            // subPanelGanadoLechero
            // 
            subPanelGanadoLechero.BackColor = Color.FromArgb(35, 35, 35);
            subPanelGanadoLechero.Controls.Add(buttonRegistroDeOrdeño);
            subPanelGanadoLechero.Controls.Add(buttonProduccionDeLeche);
            subPanelGanadoLechero.Dock = DockStyle.Top;
            subPanelGanadoLechero.Location = new Point(0, 30);
            subPanelGanadoLechero.Margin = new Padding(3, 2, 3, 2);
            subPanelGanadoLechero.Name = "subPanelGanadoLechero";
            subPanelGanadoLechero.Size = new Size(252, 62);
            subPanelGanadoLechero.TabIndex = 9;
            // 
            // buttonRegistroDeOrdeño
            // 
            buttonRegistroDeOrdeño.Dock = DockStyle.Top;
            buttonRegistroDeOrdeño.FlatAppearance.BorderSize = 0;
            buttonRegistroDeOrdeño.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonRegistroDeOrdeño.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonRegistroDeOrdeño.FlatStyle = FlatStyle.Flat;
            buttonRegistroDeOrdeño.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegistroDeOrdeño.ForeColor = Color.Silver;
            buttonRegistroDeOrdeño.Location = new Point(0, 30);
            buttonRegistroDeOrdeño.Margin = new Padding(3, 2, 3, 2);
            buttonRegistroDeOrdeño.Name = "buttonRegistroDeOrdeño";
            buttonRegistroDeOrdeño.Padding = new Padding(44, 0, 0, 0);
            buttonRegistroDeOrdeño.Size = new Size(252, 30);
            buttonRegistroDeOrdeño.TabIndex = 8;
            buttonRegistroDeOrdeño.Text = "Registro de ordeño";
            buttonRegistroDeOrdeño.TextAlign = ContentAlignment.MiddleLeft;
            buttonRegistroDeOrdeño.UseVisualStyleBackColor = true;
            buttonRegistroDeOrdeño.Click += buttonRegistroDeOrdeño_Click;
            // 
            // buttonProduccionDeLeche
            // 
            buttonProduccionDeLeche.Dock = DockStyle.Top;
            buttonProduccionDeLeche.FlatAppearance.BorderSize = 0;
            buttonProduccionDeLeche.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonProduccionDeLeche.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonProduccionDeLeche.FlatStyle = FlatStyle.Flat;
            buttonProduccionDeLeche.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProduccionDeLeche.ForeColor = Color.Silver;
            buttonProduccionDeLeche.Location = new Point(0, 0);
            buttonProduccionDeLeche.Margin = new Padding(3, 2, 3, 2);
            buttonProduccionDeLeche.Name = "buttonProduccionDeLeche";
            buttonProduccionDeLeche.Padding = new Padding(44, 0, 0, 0);
            buttonProduccionDeLeche.Size = new Size(252, 30);
            buttonProduccionDeLeche.TabIndex = 7;
            buttonProduccionDeLeche.Text = "Producción lechero";
            buttonProduccionDeLeche.TextAlign = ContentAlignment.MiddleLeft;
            buttonProduccionDeLeche.UseVisualStyleBackColor = true;
            buttonProduccionDeLeche.Click += buttonProduccionDeLeche_Click;
            // 
            // buttonGanadoDeLeche
            // 
            buttonGanadoDeLeche.Dock = DockStyle.Top;
            buttonGanadoDeLeche.FlatAppearance.BorderSize = 0;
            buttonGanadoDeLeche.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonGanadoDeLeche.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonGanadoDeLeche.FlatStyle = FlatStyle.Flat;
            buttonGanadoDeLeche.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGanadoDeLeche.ForeColor = Color.Silver;
            buttonGanadoDeLeche.Location = new Point(0, 0);
            buttonGanadoDeLeche.Margin = new Padding(3, 2, 3, 2);
            buttonGanadoDeLeche.Name = "buttonGanadoDeLeche";
            buttonGanadoDeLeche.Padding = new Padding(18, 0, 0, 0);
            buttonGanadoDeLeche.Size = new Size(252, 30);
            buttonGanadoDeLeche.TabIndex = 5;
            buttonGanadoDeLeche.Text = "Ganado de leche";
            buttonGanadoDeLeche.TextAlign = ContentAlignment.MiddleLeft;
            buttonGanadoDeLeche.UseVisualStyleBackColor = true;
            buttonGanadoDeLeche.Click += buttonGanadoBovino_Click;
            // 
            // buttonGestionGanadera
            // 
            buttonGestionGanadera.Dock = DockStyle.Top;
            buttonGestionGanadera.FlatAppearance.BorderSize = 0;
            buttonGestionGanadera.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonGestionGanadera.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonGestionGanadera.FlatStyle = FlatStyle.Flat;
            buttonGestionGanadera.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGestionGanadera.ForeColor = Color.Silver;
            buttonGestionGanadera.Image = (Image)resources.GetObject("buttonGestionGanadera.Image");
            buttonGestionGanadera.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGestionGanadera.Location = new Point(0, 262);
            buttonGestionGanadera.Margin = new Padding(3, 2, 3, 2);
            buttonGestionGanadera.Name = "buttonGestionGanadera";
            buttonGestionGanadera.Padding = new Padding(4, 0, 0, 0);
            buttonGestionGanadera.Size = new Size(252, 50);
            buttonGestionGanadera.TabIndex = 4;
            buttonGestionGanadera.Text = "Reses";
            buttonGestionGanadera.TextAlign = ContentAlignment.MiddleLeft;
            buttonGestionGanadera.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGestionGanadera.UseVisualStyleBackColor = true;
            buttonGestionGanadera.Click += buttonGestionGanadera_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.Dock = DockStyle.Top;
            buttonClientes.FlatAppearance.BorderSize = 0;
            buttonClientes.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonClientes.FlatStyle = FlatStyle.Flat;
            buttonClientes.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClientes.ForeColor = Color.Silver;
            buttonClientes.Image = (Image)resources.GetObject("buttonClientes.Image");
            buttonClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClientes.Location = new Point(0, 212);
            buttonClientes.Margin = new Padding(0);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Padding = new Padding(4, 2, 3, 0);
            buttonClientes.Size = new Size(252, 50);
            buttonClientes.TabIndex = 25;
            buttonClientes.Text = "Clientes";
            buttonClientes.TextAlign = ContentAlignment.MiddleLeft;
            buttonClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // subPanelAdministracion
            // 
            subPanelAdministracion.BackColor = Color.FromArgb(25, 25, 25);
            subPanelAdministracion.Controls.Add(buttonParametrosSistema);
            subPanelAdministracion.Controls.Add(buttonGestionUsuario);
            subPanelAdministracion.Dock = DockStyle.Top;
            subPanelAdministracion.Location = new Point(0, 150);
            subPanelAdministracion.Margin = new Padding(3, 2, 3, 2);
            subPanelAdministracion.Name = "subPanelAdministracion";
            subPanelAdministracion.Size = new Size(252, 62);
            subPanelAdministracion.TabIndex = 1;
            // 
            // buttonParametrosSistema
            // 
            buttonParametrosSistema.Dock = DockStyle.Top;
            buttonParametrosSistema.FlatAppearance.BorderSize = 0;
            buttonParametrosSistema.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonParametrosSistema.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonParametrosSistema.FlatStyle = FlatStyle.Flat;
            buttonParametrosSistema.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonParametrosSistema.ForeColor = Color.Silver;
            buttonParametrosSistema.Location = new Point(0, 30);
            buttonParametrosSistema.Margin = new Padding(3, 2, 3, 2);
            buttonParametrosSistema.Name = "buttonParametrosSistema";
            buttonParametrosSistema.Padding = new Padding(18, 0, 0, 0);
            buttonParametrosSistema.Size = new Size(252, 30);
            buttonParametrosSistema.TabIndex = 2;
            buttonParametrosSistema.Text = "Parámetros del Sistema";
            buttonParametrosSistema.TextAlign = ContentAlignment.MiddleLeft;
            buttonParametrosSistema.UseVisualStyleBackColor = true;
            buttonParametrosSistema.Click += buttonParametrosSistema_Click;
            // 
            // buttonGestionUsuario
            // 
            buttonGestionUsuario.Dock = DockStyle.Top;
            buttonGestionUsuario.FlatAppearance.BorderSize = 0;
            buttonGestionUsuario.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonGestionUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonGestionUsuario.FlatStyle = FlatStyle.Flat;
            buttonGestionUsuario.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGestionUsuario.ForeColor = Color.Silver;
            buttonGestionUsuario.Location = new Point(0, 0);
            buttonGestionUsuario.Margin = new Padding(3, 2, 3, 2);
            buttonGestionUsuario.Name = "buttonGestionUsuario";
            buttonGestionUsuario.Padding = new Padding(18, 0, 0, 0);
            buttonGestionUsuario.Size = new Size(252, 30);
            buttonGestionUsuario.TabIndex = 1;
            buttonGestionUsuario.Text = "Gestión de Usuarios";
            buttonGestionUsuario.TextAlign = ContentAlignment.MiddleLeft;
            buttonGestionUsuario.UseVisualStyleBackColor = true;
            buttonGestionUsuario.Click += buttonGestionUsuario_Click;
            // 
            // buttonAdministracion
            // 
            buttonAdministracion.Dock = DockStyle.Top;
            buttonAdministracion.FlatAppearance.BorderSize = 0;
            buttonAdministracion.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonAdministracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonAdministracion.FlatStyle = FlatStyle.Flat;
            buttonAdministracion.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdministracion.ForeColor = Color.Silver;
            buttonAdministracion.Image = (Image)resources.GetObject("buttonAdministracion.Image");
            buttonAdministracion.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdministracion.Location = new Point(0, 100);
            buttonAdministracion.Margin = new Padding(0);
            buttonAdministracion.Name = "buttonAdministracion";
            buttonAdministracion.Padding = new Padding(4, 0, 0, 0);
            buttonAdministracion.Size = new Size(252, 50);
            buttonAdministracion.TabIndex = 0;
            buttonAdministracion.Text = "Administración del Sistema";
            buttonAdministracion.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdministracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdministracion.UseVisualStyleBackColor = true;
            buttonAdministracion.Click += buttonAdministracion_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelApellidos);
            panel2.Controls.Add(labelNombres);
            panel2.Controls.Add(labelUsuario);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(labelRol);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 100);
            panel2.TabIndex = 6;
            // 
            // labelApellidos
            // 
            labelApellidos.AutoSize = true;
            labelApellidos.ForeColor = SystemColors.ButtonFace;
            labelApellidos.Location = new Point(114, 31);
            labelApellidos.Name = "labelApellidos";
            labelApellidos.Size = new Size(12, 15);
            labelApellidos.TabIndex = 7;
            labelApellidos.Text = "-";
            // 
            // labelNombres
            // 
            labelNombres.AutoSize = true;
            labelNombres.ForeColor = SystemColors.ButtonFace;
            labelNombres.Location = new Point(114, 14);
            labelNombres.Name = "labelNombres";
            labelNombres.Size = new Size(12, 15);
            labelNombres.TabIndex = 6;
            labelNombres.Text = "-";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = SystemColors.ButtonFace;
            labelUsuario.Location = new Point(108, 20);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(0, 19);
            labelUsuario.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(114, 70);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 4;
            label4.Text = "     Online";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRol.ForeColor = SystemColors.ButtonFace;
            labelRol.Location = new Point(114, 53);
            labelRol.Margin = new Padding(0);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(96, 19);
            labelRol.TabIndex = 2;
            labelRol.Text = "Administrador";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
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
            buttonSalir.Font = new Font("Arial Rounded MT Bold", 10.2F);
            buttonSalir.ForeColor = Color.Silver;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalir.Location = new Point(0, 1062);
            buttonSalir.Margin = new Padding(3, 2, 3, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Padding = new Padding(9, 0, 0, 0);
            buttonSalir.Size = new Size(252, 50);
            buttonSalir.TabIndex = 27;
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
            panelFormularioHijo.Location = new Point(269, 40);
            panelFormularioHijo.Margin = new Padding(3, 2, 3, 2);
            panelFormularioHijo.MinimumSize = new Size(895, 591);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(895, 591);
            panelFormularioHijo.TabIndex = 4;
            // 
            // pictureLogo
            // 
            pictureLogo.Anchor = AnchorStyles.None;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(321, 174);
            pictureLogo.Margin = new Padding(3, 2, 3, 2);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(260, 260);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 4;
            pictureLogo.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 631);
            Controls.Add(panelFormularioHijo);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Controls.Add(panelEncabezado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Resize += FormMenu_Resize;
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            panelMenu.ResumeLayout(false);
            subPanelZonasPastoreo.ResumeLayout(false);
            subPanelInventario.ResumeLayout(false);
            subPanelVenta.ResumeLayout(false);
            subPanelGestionGanadera.ResumeLayout(false);
            subPanelGanadoCarne.ResumeLayout(false);
            subPanelGanadoLechero.ResumeLayout(false);
            subPanelAdministracion.ResumeLayout(false);
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
        private Panel subPanelAdministracion;
        private Panel panel2;
        private Button buttonSalir;
        private Button buttonZonasPastoreo;
        private Panel panelFormularioHijo;
        private PictureBox pictureLogo;
        private PictureBox pictureBox1;
        private Label labelRol;
        private Label label4;
        private Panel subPanelGestionGanadera;
        private Panel subPanelInventario;
        private Panel subPanelVenta;
        private Panel subPanelZonasPastoreo;
        private Button buttonMedBov;
        private Button buttonIndPers;
        private Button buttonAliBov;
        private Button buttonHerrAgrGan;
        private Button buttonFumigarZona;
        private Button buttonRegistrarZonas;
        private Button buttonInformeAnalisis;
        private Button buttonGanadoDeLeche;
        private Button buttonGestionUsuario;
        private Button buttonGestionPagos;
        private Button buttonDeudores;
        private Button buttonNotaVentas;
        private Button buttonRiegoZona;
        private Button buttonClientes;
        private Panel panel3;
        private Panel subPanelGanadoLechero;
        private Panel subPanelGanadoCarne;
        private Button buttonProcesoFaenamiento;
        private Button buttonGanadoCarne;
        private Button buttonRegistroDeOrdeño;
        private Button buttonProduccionDeLeche;
        private Button buttonAuditoria;
        private Button buttonParametrosSistema;
        private Button buttonArriendoZona;
        private Button buttonContratos;
        private Label labelUsuario;
        private Label labelApellidos;
        private Label labelNombres;
    }
}