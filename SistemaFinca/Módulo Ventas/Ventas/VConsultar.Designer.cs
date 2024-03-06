namespace SistemaFinca
{
    partial class FormVConsultar
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
            panel1 = new Panel();
            buttonVer = new Button();
            lstNotasVenta = new DataGridView();
            ColumnCantRetiro = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnEstado = new DataGridViewTextBoxColumn();
            ColumnID = new DataGridViewTextBoxColumn();
            txtCedula = new TextBox();
            label4 = new Label();
            btnConsultar = new Button();
            label18 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lstNotasVenta).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonVer);
            panel1.Controls.Add(lstNotasVenta);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(label18);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 541);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonVer
            // 
            buttonVer.Anchor = AnchorStyles.Bottom;
            buttonVer.Font = new Font("Segoe UI", 11.25F);
            buttonVer.Location = new Point(416, 494);
            buttonVer.Margin = new Padding(3, 2, 3, 2);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(103, 27);
            buttonVer.TabIndex = 138;
            buttonVer.Text = "Ver";
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += buttonVer_Click;
            // 
            // lstNotasVenta
            // 
            lstNotasVenta.AllowUserToAddRows = false;
            lstNotasVenta.AllowUserToDeleteRows = false;
            lstNotasVenta.AllowUserToResizeColumns = false;
            lstNotasVenta.AllowUserToResizeRows = false;
            lstNotasVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstNotasVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lstNotasVenta.BackgroundColor = Color.FromArgb(45, 66, 91);
            lstNotasVenta.BorderStyle = BorderStyle.None;
            lstNotasVenta.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lstNotasVenta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            lstNotasVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            lstNotasVenta.ColumnHeadersHeight = 30;
            lstNotasVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            lstNotasVenta.Columns.AddRange(new DataGridViewColumn[] { ColumnCantRetiro, ColumnFecha, ColumnEstado, ColumnID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            lstNotasVenta.DefaultCellStyle = dataGridViewCellStyle2;
            lstNotasVenta.EnableHeadersVisualStyles = false;
            lstNotasVenta.GridColor = Color.SteelBlue;
            lstNotasVenta.Location = new Point(66, 177);
            lstNotasVenta.Name = "lstNotasVenta";
            lstNotasVenta.ReadOnly = true;
            lstNotasVenta.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            lstNotasVenta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            lstNotasVenta.RowTemplate.Height = 25;
            lstNotasVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lstNotasVenta.Size = new Size(762, 282);
            lstNotasVenta.TabIndex = 137;
            lstNotasVenta.CellClick += lstNotasVenta_CellClick;
            // 
            // ColumnCantRetiro
            // 
            ColumnCantRetiro.HeaderText = "Cantidad de leche";
            ColumnCantRetiro.Name = "ColumnCantRetiro";
            ColumnCantRetiro.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            ColumnFecha.HeaderText = "Monto";
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.ReadOnly = true;
            // 
            // ColumnEstado
            // 
            ColumnEstado.HeaderText = "Fecha de emisión";
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
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCedula.Cursor = Cursors.IBeam;
            txtCedula.Font = new Font("Segoe UI", 11.25F);
            txtCedula.Location = new Point(263, 117);
            txtCedula.Margin = new Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(178, 27);
            txtCedula.TabIndex = 136;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(347, 86);
            label4.Name = "label4";
            label4.Size = new Size(221, 20);
            label4.TabIndex = 135;
            label4.Text = "Número de cédula de identidad";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.Font = new Font("Segoe UI", 11.25F);
            btnConsultar.Location = new Point(465, 117);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(103, 27);
            btnConsultar.TabIndex = 134;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(274, 36);
            label18.Name = "label18";
            label18.Size = new Size(351, 32);
            label18.TabIndex = 58;
            label18.Text = "Consultar Notas de Venta";
            // 
            // FormVConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVConsultar";
            Text = "Administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lstNotasVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private Label label17;
        private Label label16;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label8;
        private Label label18;
        private TextBox txtCedula;
        private Label label4;
        private Button btnConsultar;
        private DataGridView lstNotasVenta;
        private DataGridViewTextBoxColumn ColumnCantRetiro;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnEstado;
        private DataGridViewTextBoxColumn ColumnID;
        private Button buttonVer;
    }
}