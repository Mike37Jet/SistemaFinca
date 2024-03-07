namespace SistemaFinca
{
    partial class FormC_Consultar
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
            label1 = new Label();
            txtNumeroC = new TextBox();
            label2 = new Label();
            btnConsultar = new Button();
            labelApellido = new Label();
            labelNombre = new Label();
            labelDireccion = new Label();
            labeltele = new Label();
            labelCorreo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 60);
            label1.Name = "label1";
            label1.Size = new Size(164, 22);
            label1.TabIndex = 0;
            label1.Text = "Consultar cliente";
            label1.Click += label1_Click;
            // 
            // txtNumeroC
            // 
            txtNumeroC.Cursor = Cursors.IBeam;
            txtNumeroC.Font = new Font("Segoe UI", 12F);
            txtNumeroC.Location = new Point(326, 135);
            txtNumeroC.Margin = new Padding(3, 2, 3, 2);
            txtNumeroC.Name = "txtNumeroC";
            txtNumeroC.Size = new Size(244, 29);
            txtNumeroC.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(326, 103);
            label2.Name = "label2";
            label2.Size = new Size(228, 21);
            label2.TabIndex = 3;
            label2.Text = "Número de cédula de identidad";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConsultar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(404, 177);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(82, 30);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // labelApellido
            // 
            labelApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelApellido.Location = new Point(324, 284);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(75, 20);
            labelApellido.TabIndex = 21;
            labelApellido.Text = "Apellidos:";
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(326, 240);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(73, 20);
            labelNombre.TabIndex = 20;
            labelNombre.Text = "Nombres:";
            // 
            // labelDireccion
            // 
            labelDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDireccion.Location = new Point(241, 372);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(158, 20);
            labelDireccion.TabIndex = 19;
            labelDireccion.Text = "Dirección domiciliaria:";
            // 
            // labeltele
            // 
            labeltele.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labeltele.AutoSize = true;
            labeltele.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltele.Location = new Point(329, 328);
            labeltele.Name = "labeltele";
            labeltele.Size = new Size(70, 20);
            labeltele.TabIndex = 18;
            labeltele.Text = "Teléfono:";
            // 
            // labelCorreo
            // 
            labelCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCorreo.Location = new Point(264, 416);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(135, 20);
            labelCorreo.TabIndex = 22;
            labelCorreo.Text = "Correo electrónico:";
            // 
            // FormC_Consultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(labelCorreo);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(labelDireccion);
            Controls.Add(labeltele);
            Controls.Add(btnConsultar);
            Controls.Add(label2);
            Controls.Add(txtNumeroC);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormC_Consultar";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeroC;
        private Label label2;
        private Button btnConsultar;
        private Label labelApellido;
        private Label labelNombre;
        private Label labelDireccion;
        private Label labeltele;
        private Label labelCorreo;
    }
}