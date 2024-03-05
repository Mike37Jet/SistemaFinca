namespace SistemaFinca
{
    partial class FormIFGenerarInforme
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnGenerar = new Button();
            cmbMes = new ComboBox();
            txtAnio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelReporte = new Panel();
            lstRetiros = new DataGridView();
            ColumnCantRetiro = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnEstado = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lstRetiros).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 36);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 24);
            label1.TabIndex = 0;
            label1.Text = "Reporte";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGenerar);
            panel2.Controls.Add(cmbMes);
            panel2.Controls.Add(txtAnio);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 91);
            panel2.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(523, 43);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(109, 35);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += buttonBuscar_Click;
            // 
            // cmbMes
            // 
            cmbMes.FormattingEnabled = true;
            cmbMes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abrir", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            cmbMes.Location = new Point(285, 52);
            cmbMes.Name = "cmbMes";
            cmbMes.Size = new Size(121, 23);
            cmbMes.TabIndex = 4;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(92, 52);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(48, 52);
            label4.Name = "label4";
            label4.Size = new Size(38, 21);
            label4.TabIndex = 2;
            label4.Text = "Año";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(240, 52);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 1;
            label3.Text = "Mes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(48, 13);
            label2.Name = "label2";
            label2.Size = new Size(503, 21);
            label2.TabIndex = 0;
            label2.Text = "Ingrese el año y seleccione el para el cual se requiere generar el reporte";
            // 
            // panelReporte
            // 
            panelReporte.Controls.Add(lstRetiros);
            panelReporte.Dock = DockStyle.Fill;
            panelReporte.Location = new Point(0, 127);
            panelReporte.Name = "panelReporte";
            panelReporte.Size = new Size(895, 369);
            panelReporte.TabIndex = 2;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            lstRetiros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            lstRetiros.ColumnHeadersHeight = 30;
            lstRetiros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            lstRetiros.Columns.AddRange(new DataGridViewColumn[] { ColumnCantRetiro, ColumnFecha, ColumnEstado, Column1, Column2 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            lstRetiros.DefaultCellStyle = dataGridViewCellStyle5;
            lstRetiros.EnableHeadersVisualStyles = false;
            lstRetiros.GridColor = Color.SteelBlue;
            lstRetiros.Location = new Point(48, 68);
            lstRetiros.Name = "lstRetiros";
            lstRetiros.ReadOnly = true;
            lstRetiros.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            lstRetiros.RowsDefaultCellStyle = dataGridViewCellStyle6;
            lstRetiros.RowTemplate.Height = 25;
            lstRetiros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lstRetiros.Size = new Size(774, 242);
            lstRetiros.TabIndex = 111;
            // 
            // ColumnCantRetiro
            // 
            ColumnCantRetiro.HeaderText = "Nombres";
            ColumnCantRetiro.Name = "ColumnCantRetiro";
            ColumnCantRetiro.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            ColumnFecha.HeaderText = "Apellidos";
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.ReadOnly = true;
            // 
            // ColumnEstado
            // 
            ColumnEstado.HeaderText = "Monto";
            ColumnEstado.Name = "ColumnEstado";
            ColumnEstado.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Cantidad de leche";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha de emisión";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // FormIFGenerarInforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 496);
            Controls.Add(panelReporte);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormIFGenerarInforme";
            Text = "Administrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lstRetiros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelReporte;
        private Label label1;
        private TextBox txtAnio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnGenerar;
        private ComboBox cmbMes;
        private DataGridView lstRetiros;
        private DataGridViewTextBoxColumn ColumnCantRetiro;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnEstado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}