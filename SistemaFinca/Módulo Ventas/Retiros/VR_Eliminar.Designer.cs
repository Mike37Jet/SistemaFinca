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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnEliminar = new Button();
            btnBuscar = new Button();
            label18 = new Label();
            label6 = new Label();
            txtCedula = new TextBox();
            lstRetiros = new DataGridView();
            ColumnCantRetiro = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnEstado = new DataGridViewTextBoxColumn();
            ColumnID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)lstRetiros).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminar.Font = new Font("Segoe UI", 11.25F);
            btnEliminar.Location = new Point(388, 476);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 41);
            btnEliminar.TabIndex = 103;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
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
            lstRetiros.AllowUserToAddRows = false;
            lstRetiros.AllowUserToDeleteRows = false;
            lstRetiros.AllowUserToResizeColumns = false;
            lstRetiros.AllowUserToResizeRows = false;
            lstRetiros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstRetiros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lstRetiros.BackgroundColor = Color.FromArgb(45, 66, 91);
            lstRetiros.BorderStyle = BorderStyle.None;
            lstRetiros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lstRetiros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            lstRetiros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            lstRetiros.ColumnHeadersHeight = 30;
            lstRetiros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            lstRetiros.Columns.AddRange(new DataGridViewColumn[] { ColumnCantRetiro, ColumnFecha, ColumnEstado, ColumnID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            lstRetiros.DefaultCellStyle = dataGridViewCellStyle2;
            lstRetiros.EnableHeadersVisualStyles = false;
            lstRetiros.GridColor = Color.SteelBlue;
            lstRetiros.Location = new Point(68, 174);
            lstRetiros.Name = "lstRetiros";
            lstRetiros.ReadOnly = true;
            lstRetiros.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            lstRetiros.RowsDefaultCellStyle = dataGridViewCellStyle3;
            lstRetiros.RowTemplate.Height = 25;
            lstRetiros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lstRetiros.Size = new Size(762, 282);
            lstRetiros.TabIndex = 110;
            lstRetiros.CellClick += lstRetiros_CellClick;
            // 
            // ColumnCantRetiro
            // 
            ColumnCantRetiro.HeaderText = "Cantidad de retiro";
            ColumnCantRetiro.Name = "ColumnCantRetiro";
            ColumnCantRetiro.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            ColumnFecha.HeaderText = "Fecha";
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.ReadOnly = true;
            // 
            // ColumnEstado
            // 
            ColumnEstado.HeaderText = "Estado";
            ColumnEstado.Name = "ColumnEstado";
            ColumnEstado.ReadOnly = true;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "Id";
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)lstRetiros).EndInit();
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
        private DataGridView lstRetiros;
        private DataGridViewTextBoxColumn ColumnCantRetiro;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnEstado;
        private DataGridViewTextBoxColumn ColumnID;
    }
}