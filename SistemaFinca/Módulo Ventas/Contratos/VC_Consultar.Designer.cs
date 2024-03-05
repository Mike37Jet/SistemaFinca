namespace SistemaFinca
{
    partial class FormVC_Consultar : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVC_Consultar));
            btnConsultar = new Button();
            label18 = new Label();
            label6 = new Label();
            txtCedula = new TextBox();
            panelContrato = new Panel();
            picturePagado = new PictureBox();
            labelCantidadRetirada = new Label();
            label11 = new Label();
            labelApellidos1 = new Label();
            labelNombres1 = new Label();
            label9 = new Label();
            label5 = new Label();
            labelDireccionDomiciliaria = new Label();
            label40 = new Label();
            labelCedula = new Label();
            label42 = new Label();
            labelApellidos = new Label();
            labelNombres = new Label();
            label45 = new Label();
            label16 = new Label();
            label38 = new Label();
            label37 = new Label();
            label13 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelFechaFinalizacion = new Label();
            labelFechaInicio = new Label();
            label36 = new Label();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            labelCantidadLeche = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label12 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label17 = new Label();
            label15 = new Label();
            label10 = new Label();
            labelFechaEmision = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            panelContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePagado).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.Font = new Font("Segoe UI", 11.25F);
            btnConsultar.Location = new Point(425, 113);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(103, 27);
            btnConsultar.TabIndex = 84;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnBuscar_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(324, 34);
            label18.Name = "label18";
            label18.Size = new Size(265, 32);
            label18.TabIndex = 81;
            label18.Text = "Consultar Contrato";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(341, 82);
            label6.Name = "label6";
            label6.Size = new Size(221, 20);
            label6.TabIndex = 108;
            label6.Text = "Número de cédula de identidad";
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCedula.Cursor = Cursors.IBeam;
            txtCedula.Font = new Font("Segoe UI", 11.25F);
            txtCedula.Location = new Point(223, 113);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(178, 27);
            txtCedula.TabIndex = 109;
            // 
            // panelContrato
            // 
            panelContrato.AutoScroll = true;
            panelContrato.BackColor = SystemColors.ButtonHighlight;
            panelContrato.Controls.Add(picturePagado);
            panelContrato.Controls.Add(labelCantidadRetirada);
            panelContrato.Controls.Add(label11);
            panelContrato.Controls.Add(labelApellidos1);
            panelContrato.Controls.Add(labelNombres1);
            panelContrato.Controls.Add(label9);
            panelContrato.Controls.Add(label5);
            panelContrato.Controls.Add(labelDireccionDomiciliaria);
            panelContrato.Controls.Add(label40);
            panelContrato.Controls.Add(labelCedula);
            panelContrato.Controls.Add(label42);
            panelContrato.Controls.Add(labelApellidos);
            panelContrato.Controls.Add(labelNombres);
            panelContrato.Controls.Add(label45);
            panelContrato.Controls.Add(label16);
            panelContrato.Controls.Add(label38);
            panelContrato.Controls.Add(label37);
            panelContrato.Controls.Add(label13);
            panelContrato.Controls.Add(label4);
            panelContrato.Controls.Add(label2);
            panelContrato.Controls.Add(label1);
            panelContrato.Controls.Add(labelFechaFinalizacion);
            panelContrato.Controls.Add(labelFechaInicio);
            panelContrato.Controls.Add(label36);
            panelContrato.Controls.Add(label35);
            panelContrato.Controls.Add(label34);
            panelContrato.Controls.Add(label33);
            panelContrato.Controls.Add(labelCantidadLeche);
            panelContrato.Controls.Add(label32);
            panelContrato.Controls.Add(label31);
            panelContrato.Controls.Add(label30);
            panelContrato.Controls.Add(label12);
            panelContrato.Controls.Add(label29);
            panelContrato.Controls.Add(label28);
            panelContrato.Controls.Add(label27);
            panelContrato.Controls.Add(label26);
            panelContrato.Controls.Add(label25);
            panelContrato.Controls.Add(label24);
            panelContrato.Controls.Add(label23);
            panelContrato.Controls.Add(label22);
            panelContrato.Controls.Add(label21);
            panelContrato.Controls.Add(label20);
            panelContrato.Controls.Add(label19);
            panelContrato.Controls.Add(label17);
            panelContrato.Controls.Add(label15);
            panelContrato.Controls.Add(label10);
            panelContrato.Controls.Add(labelFechaEmision);
            panelContrato.Controls.Add(label8);
            panelContrato.Controls.Add(label7);
            panelContrato.Controls.Add(label3);
            panelContrato.Location = new Point(56, 156);
            panelContrato.Name = "panelContrato";
            panelContrato.Size = new Size(783, 846);
            panelContrato.TabIndex = 110;
            // 
            // picturePagado
            // 
            picturePagado.Image = (Image)resources.GetObject("picturePagado.Image");
            picturePagado.Location = new Point(578, 20);
            picturePagado.Name = "picturePagado";
            picturePagado.Size = new Size(185, 107);
            picturePagado.SizeMode = PictureBoxSizeMode.Zoom;
            picturePagado.TabIndex = 194;
            picturePagado.TabStop = false;
            // 
            // labelCantidadRetirada
            // 
            labelCantidadRetirada.AutoSize = true;
            labelCantidadRetirada.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCantidadRetirada.Location = new Point(179, 506);
            labelCantidadRetirada.Name = "labelCantidadRetirada";
            labelCantidadRetirada.Size = new Size(12, 15);
            labelCantidadRetirada.TabIndex = 193;
            labelCantidadRetirada.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(48, 506);
            label11.Name = "label11";
            label11.Size = new Size(113, 15);
            label11.TabIndex = 192;
            label11.Text = "Cantidad entregada:";
            // 
            // labelApellidos1
            // 
            labelApellidos1.AutoSize = true;
            labelApellidos1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApellidos1.Location = new Point(451, 794);
            labelApellidos1.Name = "labelApellidos1";
            labelApellidos1.Size = new Size(12, 15);
            labelApellidos1.TabIndex = 191;
            labelApellidos1.Text = "-";
            // 
            // labelNombres1
            // 
            labelNombres1.AutoSize = true;
            labelNombres1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombres1.Location = new Point(451, 777);
            labelNombres1.Name = "labelNombres1";
            labelNombres1.Size = new Size(12, 15);
            labelNombres1.TabIndex = 190;
            labelNombres1.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(100, 794);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 189;
            label9.Text = "Almeida Morillo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(100, 779);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 188;
            label5.Text = "Rolando José";
            // 
            // labelDireccionDomiciliaria
            // 
            labelDireccionDomiciliaria.AutoSize = true;
            labelDireccionDomiciliaria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDireccionDomiciliaria.Location = new Point(516, 209);
            labelDireccionDomiciliaria.Name = "labelDireccionDomiciliaria";
            labelDireccionDomiciliaria.Size = new Size(12, 15);
            labelDireccionDomiciliaria.TabIndex = 187;
            labelDireccionDomiciliaria.Text = "-";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label40.Location = new Point(451, 209);
            label40.Name = "label40";
            label40.Size = new Size(60, 15);
            label40.TabIndex = 186;
            label40.Text = "Dirección:";
            // 
            // labelCedula
            // 
            labelCedula.AutoSize = true;
            labelCedula.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCedula.Location = new Point(559, 181);
            labelCedula.Name = "labelCedula";
            labelCedula.Size = new Size(12, 15);
            labelCedula.TabIndex = 185;
            labelCedula.Text = "-";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label42.Location = new Point(452, 181);
            label42.Name = "label42";
            label42.Size = new Size(108, 15);
            label42.TabIndex = 184;
            label42.Text = "Número de cédula:";
            // 
            // labelApellidos
            // 
            labelApellidos.AutoSize = true;
            labelApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApellidos.Location = new Point(512, 158);
            labelApellidos.Name = "labelApellidos";
            labelApellidos.Size = new Size(12, 15);
            labelApellidos.TabIndex = 183;
            labelApellidos.Text = "-";
            // 
            // labelNombres
            // 
            labelNombres.AutoSize = true;
            labelNombres.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombres.Location = new Point(512, 141);
            labelNombres.Name = "labelNombres";
            labelNombres.Size = new Size(12, 15);
            labelNombres.TabIndex = 182;
            labelNombres.Text = "-";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label45.Location = new Point(452, 141);
            label45.Name = "label45";
            label45.Size = new Size(54, 15);
            label45.TabIndex = 181;
            label45.Text = "Nombre:";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(362, 779);
            label16.Name = "label16";
            label16.Size = new Size(78, 14);
            label16.TabIndex = 180;
            label16.Text = "Comprador:";
            // 
            // label38
            // 
            label38.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label38.AutoSize = true;
            label38.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label38.Location = new Point(16, 749);
            label38.Name = "label38";
            label38.Size = new Size(158, 17);
            label38.TabIndex = 179;
            label38.Text = "Leído por las partes:";
            // 
            // label37
            // 
            label37.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label37.AutoSize = true;
            label37.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label37.Location = new Point(26, 779);
            label37.Name = "label37";
            label37.Size = new Size(68, 14);
            label37.TabIndex = 178;
            label37.Text = "Vendedor:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(48, 697);
            label13.Name = "label13";
            label13.Size = new Size(664, 30);
            label13.TabIndex = 176;
            label13.Text = "Para la resolución de cualquier controversia derivada de este contrato, las partes se someten a la jurisdicción de los tribunales\r\nde la provincia del Carchi, Ecuador.";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 680);
            label4.Name = "label4";
            label4.Size = new Size(82, 14);
            label4.TabIndex = 175;
            label4.Text = "Jurisdicción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 662);
            label2.Name = "label2";
            label2.Size = new Size(656, 15);
            label2.TabIndex = 174;
            label2.Text = "Cualquiera de las partes podrá rescindir este contrato en caso de incumplimiento grave de las obligaciones de la otra parte. \r\n";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 645);
            label1.Name = "label1";
            label1.Size = new Size(140, 14);
            label1.TabIndex = 173;
            label1.Text = "Rescisión del contrato:";
            // 
            // labelFechaFinalizacion
            // 
            labelFechaFinalizacion.AutoSize = true;
            labelFechaFinalizacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaFinalizacion.Location = new Point(179, 613);
            labelFechaFinalizacion.Name = "labelFechaFinalizacion";
            labelFechaFinalizacion.Size = new Size(12, 15);
            labelFechaFinalizacion.TabIndex = 172;
            labelFechaFinalizacion.Text = "-";
            // 
            // labelFechaInicio
            // 
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaInicio.Location = new Point(179, 589);
            labelFechaInicio.Name = "labelFechaInicio";
            labelFechaInicio.Size = new Size(12, 15);
            labelFechaInicio.TabIndex = 171;
            labelFechaInicio.Text = "-";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(48, 613);
            label36.Name = "label36";
            label36.Size = new Size(121, 15);
            label36.TabIndex = 170;
            label36.Text = "Fecha de finalización:";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.Location = new Point(48, 589);
            label35.Name = "label35";
            label35.Size = new Size(89, 15);
            label35.TabIndex = 169;
            label35.Text = "Fecha de inicio:";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(48, 565);
            label34.Name = "label34";
            label34.Size = new Size(642, 15);
            label34.TabIndex = 168;
            label34.Text = "Este contrato estará vigente desde la fecha de inicio hasta la fecha de finalización que determina la duración del acuerdo.";
            // 
            // label33
            // 
            label33.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label33.AutoSize = true;
            label33.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label33.Location = new Point(26, 538);
            label33.Name = "label33";
            label33.Size = new Size(135, 14);
            label33.TabIndex = 167;
            label33.Text = "Duración del contrato:";
            // 
            // labelCantidadLeche
            // 
            labelCantidadLeche.AutoSize = true;
            labelCantidadLeche.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCantidadLeche.Location = new Point(179, 486);
            labelCantidadLeche.Name = "labelCantidadLeche";
            labelCantidadLeche.Size = new Size(12, 15);
            labelCantidadLeche.TabIndex = 166;
            labelCantidadLeche.Text = "-";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(48, 486);
            label32.Name = "label32";
            label32.Size = new Size(109, 15);
            label32.TabIndex = 165;
            label32.Text = "Cantidad acordada:";
            label32.Click += label32_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(153, 466);
            label31.Name = "label31";
            label31.Size = new Size(590, 15);
            label31.TabIndex = 164;
            label31.Text = "Carretera Panamericana E35, sentido sur, primera entrada a la derecha, situada cerca de la localidad Ejido Norte";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(48, 466);
            label30.Name = "label30";
            label30.Size = new Size(99, 15);
            label30.TabIndex = 163;
            label30.Text = "Lugar de entrega:";
            label30.Click += label30_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(26, 441);
            label12.Name = "label12";
            label12.Size = new Size(57, 14);
            label12.TabIndex = 162;
            label12.Text = "Entrega:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(26, 365);
            label29.Name = "label29";
            label29.Size = new Size(725, 75);
            label29.TabIndex = 161;
            label29.Text = resources.GetString("label29.Text");
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label28.AutoSize = true;
            label28.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(16, 338);
            label28.Name = "label28";
            label28.Size = new Size(84, 17);
            label28.TabIndex = 160;
            label28.Text = "Cláusulas:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(26, 297);
            label27.Name = "label27";
            label27.Size = new Size(546, 30);
            label27.TabIndex = 159;
            label27.Text = "1. El vendedor declara ser productor y/o distribuidor de leche fresca. \r\n2. El comprador declara estar interesado en la compra de leche fresca para su consumo o distribución. \r\n";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(16, 267);
            label26.Name = "label26";
            label26.Size = new Size(119, 17);
            label26.TabIndex = 158;
            label26.Text = "Declaraciones:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(145, 209);
            label25.Name = "label25";
            label25.Size = new Size(134, 30);
            label25.TabIndex = 157;
            label25.Text = "Km5, a 2 Kilometros del \r\naeropuerto de Túlcan";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(80, 209);
            label24.Name = "label24";
            label24.Size = new Size(60, 15);
            label24.TabIndex = 156;
            label24.Text = "Dirección:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(188, 181);
            label23.Name = "label23";
            label23.Size = new Size(67, 15);
            label23.TabIndex = 155;
            label23.Text = "1700163678";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(81, 181);
            label22.Name = "label22";
            label22.Size = new Size(108, 15);
            label22.TabIndex = 154;
            label22.Text = "Número de cédula:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(141, 158);
            label21.Name = "label21";
            label21.Size = new Size(92, 15);
            label21.TabIndex = 153;
            label21.Text = "Almeida Morillo";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(141, 141);
            label20.Name = "label20";
            label20.Size = new Size(79, 15);
            label20.TabIndex = 152;
            label20.Text = " Ronaldo José";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(81, 141);
            label19.Name = "label19";
            label19.Size = new Size(54, 15);
            label19.TabIndex = 151;
            label19.Text = "Nombre:";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(375, 110);
            label17.Name = "label17";
            label17.Size = new Size(96, 17);
            label17.TabIndex = 150;
            label17.Text = "Comprador:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(16, 110);
            label15.Name = "label15";
            label15.Size = new Size(84, 17);
            label15.TabIndex = 149;
            label15.Text = "Vendedor:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(16, 59);
            label10.Name = "label10";
            label10.Size = new Size(131, 15);
            label10.TabIndex = 147;
            label10.Text = "Tulcán, Carchi, Ecuador";
            // 
            // labelFechaEmision
            // 
            labelFechaEmision.AutoSize = true;
            labelFechaEmision.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaEmision.Location = new Point(16, 39);
            labelFechaEmision.Name = "labelFechaEmision";
            labelFechaEmision.Size = new Size(13, 17);
            labelFechaEmision.TabIndex = 146;
            labelFechaEmision.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 44);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 145;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 11);
            label7.Name = "label7";
            label7.Size = new Size(230, 18);
            label7.TabIndex = 144;
            label7.Text = "Contrato de venta de Leche";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 85);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 126;
            label3.Text = "Comparecen:";
            // 
            // FormVC_Consultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(895, 788);
            Controls.Add(panelContrato);
            Controls.Add(txtCedula);
            Controls.Add(label6);
            Controls.Add(btnConsultar);
            Controls.Add(label18);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVC_Consultar";
            Text = "Administrador";
            panelContrato.ResumeLayout(false);
            panelContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePagado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label15;
        private Button button1;
        private DataGridView dataGridNotaVenta;
        private Button btnConsultar;
        private Label label18;
        private Label label6;
        private TextBox txtCedula;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panelContrato;
        private Label labelFechaEmision;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label17;
        private Label label10;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label30;
        private Label label12;
        private Label labelCantidadLeche;
        private Label label32;
        private Label label31;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label2;
        private Label label1;
        private Label labelFechaFinalizacion;
        private Label labelFechaInicio;
        private Label label36;
        private Label label16;
        private Label label38;
        private Label label37;
        private Label label13;
        private Label label4;
        private Label labelApellidos1;
        private Label labelNombres1;
        private Label label9;
        private Label label5;
        private Label labelDireccionDomiciliaria;
        private Label label40;
        private Label labelCedula;
        private Label label42;
        private Label labelApellidos;
        private Label labelNombres;
        private Label label45;
        private Label labelCantidadRetirada;
        private Label label11;
        private PictureBox picturePagado;
    }
}