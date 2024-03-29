﻿namespace SistemaFinca
{
    partial class FormGestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionClientes));
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonConsultar = new Button();
            buttonRegistrar = new Button();
            buttonDarDeAlta = new Button();
            buttonDarDeBaja = new Button();
            buttonActualizar = new Button();
            buttonRegresar = new Button();
            panelFormularioHijo = new Panel();
            label3 = new Label();
            label2 = new Label();
            lstClientesInactivos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listClientes = new ListView();
            columnID = new ColumnHeader();
            columnNombre = new ColumnHeader();
            columnApellidos = new ColumnHeader();
            columnTelefono = new ColumnHeader();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9939756F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.3855438F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 228F));
            tableLayoutPanel1.Controls.Add(buttonConsultar, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonRegistrar, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonDarDeAlta, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonDarDeBaja, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonActualizar, 1, 0);
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
            // buttonConsultar
            // 
            buttonConsultar.Dock = DockStyle.Fill;
            buttonConsultar.Image = (Image)resources.GetObject("buttonConsultar.Image");
            buttonConsultar.Location = new Point(70, 0);
            buttonConsultar.Margin = new Padding(0);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(70, 50);
            buttonConsultar.TabIndex = 13;
            buttonConsultar.TextAlign = ContentAlignment.BottomCenter;
            buttonConsultar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            buttonConsultar.MouseMove += buttonConsultar_MouseMove;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Dock = DockStyle.Fill;
            buttonRegistrar.Image = (Image)resources.GetObject("buttonRegistrar.Image");
            buttonRegistrar.Location = new Point(0, 0);
            buttonRegistrar.Margin = new Padding(0);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(70, 50);
            buttonRegistrar.TabIndex = 6;
            buttonRegistrar.TextAlign = ContentAlignment.BottomCenter;
            buttonRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click_1;
            buttonRegistrar.MouseMove += buttonRegistrar_MouseMove;
            // 
            // buttonDarDeAlta
            // 
            buttonDarDeAlta.Dock = DockStyle.Fill;
            buttonDarDeAlta.Image = (Image)resources.GetObject("buttonDarDeAlta.Image");
            buttonDarDeAlta.Location = new Point(283, 0);
            buttonDarDeAlta.Margin = new Padding(0);
            buttonDarDeAlta.Name = "buttonDarDeAlta";
            buttonDarDeAlta.Size = new Size(73, 50);
            buttonDarDeAlta.TabIndex = 9;
            buttonDarDeAlta.TextAlign = ContentAlignment.BottomCenter;
            buttonDarDeAlta.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonDarDeAlta.UseVisualStyleBackColor = true;
            buttonDarDeAlta.Click += buttonDarDeAlta_Click;
            buttonDarDeAlta.MouseMove += buttonDarDeAlta_MouseMove;
            // 
            // buttonDarDeBaja
            // 
            buttonDarDeBaja.Dock = DockStyle.Fill;
            buttonDarDeBaja.Image = (Image)resources.GetObject("buttonDarDeBaja.Image");
            buttonDarDeBaja.Location = new Point(210, 0);
            buttonDarDeBaja.Margin = new Padding(0);
            buttonDarDeBaja.Name = "buttonDarDeBaja";
            buttonDarDeBaja.Size = new Size(73, 50);
            buttonDarDeBaja.TabIndex = 8;
            buttonDarDeBaja.TextAlign = ContentAlignment.BottomCenter;
            buttonDarDeBaja.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonDarDeBaja.UseVisualStyleBackColor = true;
            buttonDarDeBaja.Click += buttonDarDeBaja_Click;
            buttonDarDeBaja.MouseMove += buttonDarDeBaja_MouseMove;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Dock = DockStyle.Fill;
            buttonActualizar.Image = (Image)resources.GetObject("buttonActualizar.Image");
            buttonActualizar.Location = new Point(140, 0);
            buttonActualizar.Margin = new Padding(0);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(70, 50);
            buttonActualizar.TabIndex = 7;
            buttonActualizar.TextAlign = ContentAlignment.BottomCenter;
            buttonActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            buttonActualizar.MouseMove += buttonActualizar_MouseMove;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Dock = DockStyle.Fill;
            buttonRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(667, 2);
            buttonRegresar.Margin = new Padding(3, 2, 3, 2);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(225, 46);
            buttonRegresar.TabIndex = 10;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.AutoScroll = true;
            panelFormularioHijo.Controls.Add(label3);
            panelFormularioHijo.Controls.Add(label2);
            panelFormularioHijo.Controls.Add(lstClientesInactivos);
            panelFormularioHijo.Controls.Add(listClientes);
            panelFormularioHijo.Controls.Add(label1);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(0, 0);
            panelFormularioHijo.Margin = new Padding(3, 2, 3, 2);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(895, 541);
            panelFormularioHijo.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(95, 47);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 9;
            label3.Text = "Clientes Activos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(95, 302);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 8;
            label2.Text = "Clientes Inactivos";
            // 
            // lstClientesInactivos
            // 
            lstClientesInactivos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstClientesInactivos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstClientesInactivos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstClientesInactivos.Location = new Point(95, 334);
            lstClientesInactivos.Margin = new Padding(3, 2, 3, 2);
            lstClientesInactivos.Name = "lstClientesInactivos";
            lstClientesInactivos.Size = new Size(689, 169);
            lstClientesInactivos.TabIndex = 7;
            lstClientesInactivos.UseCompatibleStateImageBehavior = false;
            lstClientesInactivos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "CI";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombres";
            columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apellidos";
            columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Teléfono";
            columnHeader4.Width = 170;
            // 
            // listClientes
            // 
            listClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listClientes.Columns.AddRange(new ColumnHeader[] { columnID, columnNombre, columnApellidos, columnTelefono });
            listClientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listClientes.Location = new Point(95, 80);
            listClientes.Margin = new Padding(3, 2, 3, 2);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(689, 177);
            listClientes.TabIndex = 6;
            listClientes.UseCompatibleStateImageBehavior = false;
            listClientes.View = View.Details;
            // 
            // columnID
            // 
            columnID.Text = "CI";
            columnID.Width = 160;
            // 
            // columnNombre
            // 
            columnNombre.Text = "Nombres";
            columnNombre.Width = 170;
            // 
            // columnApellidos
            // 
            columnApellidos.Text = "Apellidos";
            columnApellidos.Width = 170;
            // 
            // columnTelefono
            // 
            columnTelefono.Text = "Teléfono";
            columnTelefono.Width = 170;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 18);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 5;
            label1.Text = "Clientes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormGestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 591);
            Controls.Add(panelFormularioHijo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGestionClientes";
            Text = "Inventario";
            tableLayoutPanel1.ResumeLayout(false);
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonDarDeAlta;
        private Button buttonDarDeBaja;
        private Button buttonActualizar;
        private Button buttonRegistrar;
        private Button buttonRegresar;
        private Panel panelFormularioHijo;
        private Label label1;
        private ListView listClientes;
        private ColumnHeader columnID;
        private ColumnHeader columnNombre;
        private ColumnHeader columnApellidos;
        private ColumnHeader columnTelefono;
        private Button buttonConsultar;
        private Label label3;
        private Label label2;
        private ListView lstClientesInactivos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}