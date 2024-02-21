namespace SistemaFinca
{
    partial class FormC_Registrar
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
            textCedula = new TextBox();
            label2 = new Label();
            textTelefono = new TextBox();
            label3 = new Label();
            button2 = new Button();
            textNombres = new TextBox();
            textApellidos = new TextBox();
            textDireccionDom = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            textCantidaLeche = new TextBox();
            textEmail = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 30);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "Registrar nuevo cliente";
            // 
            // textCedula
            // 
            textCedula.Cursor = Cursors.IBeam;
            textCedula.Location = new Point(45, 93);
            textCedula.Name = "textCedula";
            textCedula.Size = new Size(278, 27);
            textCedula.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 70);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 3;
            label2.Text = "Número de Cédula";
            // 
            // textTelefono
            // 
            textTelefono.Cursor = Cursors.IBeam;
            textTelefono.Location = new Point(330, 93);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(278, 27);
            textTelefono.TabIndex = 4;
            textTelefono.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 70);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "Teléfono";
            // 
            // button2
            // 
            button2.Location = new Point(277, 399);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textNombres
            // 
            textNombres.Cursor = Cursors.IBeam;
            textNombres.Location = new Point(45, 150);
            textNombres.Name = "textNombres";
            textNombres.Size = new Size(278, 27);
            textNombres.TabIndex = 11;
            // 
            // textApellidos
            // 
            textApellidos.Cursor = Cursors.IBeam;
            textApellidos.Location = new Point(329, 150);
            textApellidos.Name = "textApellidos";
            textApellidos.Size = new Size(278, 27);
            textApellidos.TabIndex = 12;
            // 
            // textDireccionDom
            // 
            textDireccionDom.Cursor = Cursors.IBeam;
            textDireccionDom.Location = new Point(45, 211);
            textDireccionDom.Name = "textDireccionDom";
            textDireccionDom.Size = new Size(572, 27);
            textDireccionDom.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 127);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 14;
            label4.Text = "Nombres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 127);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 15;
            label5.Text = "Apellidos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 188);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 16;
            label6.Text = "Dirección domiciliaria";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(55, 351);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 24);
            radioButton1.TabIndex = 17;
            radioButton1.TabStop = true;
            radioButton1.Text = "Formal";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(55, 381);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 24);
            radioButton2.TabIndex = 18;
            radioButton2.TabStop = true;
            radioButton2.Text = "Informal";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 318);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 19;
            label7.Text = "Tipo de contrato";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 318);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 20;
            label8.Text = "Cantidad de Leche";
            // 
            // textCantidaLeche
            // 
            textCantidaLeche.Cursor = Cursors.IBeam;
            textCantidaLeche.Location = new Point(339, 350);
            textCantidaLeche.Name = "textCantidaLeche";
            textCantidaLeche.Size = new Size(278, 27);
            textCantidaLeche.TabIndex = 21;
            // 
            // textEmail
            // 
            textEmail.Cursor = Cursors.IBeam;
            textEmail.Location = new Point(45, 271);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(572, 27);
            textEmail.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 248);
            label9.Name = "label9";
            label9.Size = new Size(218, 20);
            label9.TabIndex = 23;
            label9.Text = "Dirección de correo electrónico";
            // 
            // FormC_Registrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 459);
            Controls.Add(label9);
            Controls.Add(textEmail);
            Controls.Add(textCantidaLeche);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textDireccionDom);
            Controls.Add(textApellidos);
            Controls.Add(textNombres);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textTelefono);
            Controls.Add(label2);
            Controls.Add(textCedula);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormC_Registrar";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textCedula;
        private Label label2;
        private TextBox textTelefono;
        private Label label3;
        private Button button2;
        private TextBox textNombres;
        private TextBox textApellidos;
        private TextBox textDireccionDom;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private Label label8;
        private TextBox textCantidaLeche;
        private TextBox textEmail;
        private Label label9;
    }
}