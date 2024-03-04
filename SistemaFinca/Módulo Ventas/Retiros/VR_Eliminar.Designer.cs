namespace SistemaFinca
{
    partial class FormVR_Eliminar : Form
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
            btnEliminar = new Button();
            btnBuscar = new Button();
            label18 = new Label();
            label6 = new Label();
            txtCedula = new TextBox();
            lstRetiros = new ListView();
            columnCantidad = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminar.Font = new Font("Segoe UI", 11.25F);
            btnEliminar.Location = new Point(404, 444);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 36);
            btnEliminar.TabIndex = 103;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnRegistrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Font = new Font("Segoe UI", 11.25F);
            btnBuscar.Location = new Point(510, 113);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(103, 27);
            btnBuscar.TabIndex = 84;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(324, 35);
            label18.Name = "label18";
            label18.Size = new Size(208, 32);
            label18.TabIndex = 81;
            label18.Text = "Eliminar Retiro";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(308, 82);
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
            txtCedula.Location = new Point(308, 113);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(178, 27);
            txtCedula.TabIndex = 109;
            // 
            // lstRetiros
            // 
            lstRetiros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstRetiros.Columns.AddRange(new ColumnHeader[] { columnCantidad, columnHeader1, columnHeader2 });
            lstRetiros.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstRetiros.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstRetiros.Location = new Point(212, 168);
            lstRetiros.Margin = new Padding(3, 2, 3, 2);
            lstRetiros.MultiSelect = false;
            lstRetiros.Name = "lstRetiros";
            lstRetiros.Size = new Size(454, 261);
            lstRetiros.TabIndex = 110;
            lstRetiros.UseCompatibleStateImageBehavior = false;
            lstRetiros.View = View.Details;
            lstRetiros.ItemSelectionChanged += lstRetiros_ItemSelectionChanged;
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
            // FormVR_Eliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(lstRetiros);
            Controls.Add(txtCedula);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(label18);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVR_Eliminar";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnEliminar;
        private Label label15;
        private Button button1;
        private DataGridView dataGridNotaVenta;
        private Button btnBuscar;
        private Label label18;
        private Label label6;
        private TextBox txtCedula;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ListView lstRetiros;
        private ColumnHeader columnCantidad;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}