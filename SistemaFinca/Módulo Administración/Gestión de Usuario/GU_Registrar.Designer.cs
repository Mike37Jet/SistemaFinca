﻿namespace SistemaFinca
{
    partial class FormGU_Registrar
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
            btnRegistrar = new Button();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            label4 = new Label();
            label5 = new Label();
            radioAd = new RadioButton();
            radioJor = new RadioButton();
            label7 = new Label();
            label3 = new Label();
            txtTelefono = new TextBox();
            txtNombreU = new TextBox();
            txtContrasena = new TextBox();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtCorreo = new TextBox();
            labelEjCedula = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(313, 20);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 0;
            label1.Text = "Registrar nuevo usuario";
            // 
            // txtNumeroC
            // 
            txtNumeroC.Cursor = Cursors.IBeam;
            txtNumeroC.Font = new Font("Segoe UI", 12F);
            txtNumeroC.Location = new Point(102, 88);
            txtNumeroC.Margin = new Padding(3, 2, 3, 2);
            txtNumeroC.Name = "txtNumeroC";
            txtNumeroC.Size = new Size(244, 29);
            txtNumeroC.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(102, 65);
            label2.Name = "label2";
            label2.Size = new Size(231, 21);
            label2.TabIndex = 3;
            label2.Text = "Número de Cédula de identidad";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.Location = new Point(346, 450);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(98, 44);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button2_Click;
            // 
            // txtNombres
            // 
            txtNombres.Cursor = Cursors.IBeam;
            txtNombres.Font = new Font("Segoe UI", 12F);
            txtNombres.Location = new Point(102, 172);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(244, 29);
            txtNombres.TabIndex = 11;
            // 
            // txtApellidos
            // 
            txtApellidos.Cursor = Cursors.IBeam;
            txtApellidos.Font = new Font("Segoe UI", 12F);
            txtApellidos.Location = new Point(456, 172);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(244, 29);
            txtApellidos.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(102, 152);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 14;
            label4.Text = "Nombres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(456, 152);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 15;
            label5.Text = "Apellidos";
            // 
            // radioAd
            // 
            radioAd.AutoSize = true;
            radioAd.Font = new Font("Segoe UI", 12F);
            radioAd.Location = new Point(108, 369);
            radioAd.Margin = new Padding(3, 2, 3, 2);
            radioAd.Name = "radioAd";
            radioAd.Size = new Size(128, 25);
            radioAd.TabIndex = 17;
            radioAd.TabStop = true;
            radioAd.Text = "Administrador";
            radioAd.UseVisualStyleBackColor = true;
            // 
            // radioJor
            // 
            radioJor.AutoSize = true;
            radioJor.Font = new Font("Segoe UI", 12F);
            radioJor.Location = new Point(108, 391);
            radioJor.Margin = new Padding(3, 2, 3, 2);
            radioJor.Name = "radioJor";
            radioJor.Size = new Size(93, 25);
            radioJor.TabIndex = 18;
            radioJor.TabStop = true;
            radioJor.Text = "Jornalero";
            radioJor.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(99, 344);
            label7.Name = "label7";
            label7.Size = new Size(33, 21);
            label7.TabIndex = 19;
            label7.Text = "Rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(456, 65);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 5;
            label3.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(456, 88);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(244, 29);
            txtTelefono.TabIndex = 4;
            // 
            // txtNombreU
            // 
            txtNombreU.Cursor = Cursors.IBeam;
            txtNombreU.Font = new Font("Segoe UI", 12F);
            txtNombreU.Location = new Point(102, 262);
            txtNombreU.Margin = new Padding(3, 2, 3, 2);
            txtNombreU.Name = "txtNombreU";
            txtNombreU.Size = new Size(244, 29);
            txtNombreU.TabIndex = 22;
            // 
            // txtContrasena
            // 
            txtContrasena.Cursor = Cursors.IBeam;
            txtContrasena.Font = new Font("Segoe UI", 12F);
            txtContrasena.Location = new Point(456, 262);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(244, 29);
            txtContrasena.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(102, 239);
            label6.Name = "label6";
            label6.Size = new Size(145, 21);
            label6.TabIndex = 24;
            label6.Text = "Nombre de usuario";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(456, 239);
            label9.Name = "label9";
            label9.Size = new Size(89, 21);
            label9.TabIndex = 25;
            label9.Text = "Contraseña";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(456, 342);
            label8.Name = "label8";
            label8.Size = new Size(225, 21);
            label8.TabIndex = 26;
            label8.Text = "Dirección de correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Font = new Font("Segoe UI", 12F);
            txtCorreo.Location = new Point(456, 365);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(321, 29);
            txtCorreo.TabIndex = 27;
            // 
            // labelEjCedula
            // 
            labelEjCedula.AutoSize = true;
            labelEjCedula.Location = new Point(102, 119);
            labelEjCedula.Name = "labelEjCedula";
            labelEjCedula.Size = new Size(82, 15);
            labelEjCedula.TabIndex = 28;
            labelEjCedula.Text = "Ej: 1600830705";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(102, 203);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 29;
            label10.Text = "Ej: Juan Pablo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(102, 293);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 30;
            label11.Text = "Ej: Admin";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(456, 293);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 31;
            label12.Text = "Ej: pA$sWord";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(456, 203);
            label13.Name = "label13";
            label13.Size = new Size(123, 15);
            label13.TabIndex = 32;
            label13.Text = "Ej: Sánchez Zambrano";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(456, 119);
            label14.Name = "label14";
            label14.Size = new Size(82, 15);
            label14.TabIndex = 33;
            label14.Text = "Ej: 0987654321";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(456, 394);
            label15.Name = "label15";
            label15.Size = new Size(124, 15);
            label15.TabIndex = 34;
            label15.Text = "Ej: correo@gmail.com";
            // 
            // FormGU_Registrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 541);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(labelEjCedula);
            Controls.Add(txtCorreo);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombreU);
            Controls.Add(label7);
            Controls.Add(radioJor);
            Controls.Add(radioAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNumeroC);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormGU_Registrar";
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeroC;
        private Label label2;
        private Button btnRegistrar;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private Label label4;
        private Label label5;
        private RadioButton radioAd;
        private RadioButton radioJor;
        private Label label7;
        private Label label3;
        private TextBox txtTelefono;
        private TextBox txtNombreU;
        private TextBox txtContrasena;
        private Label label6;
        private Label label9;
        private Label label8;
        private TextBox txtCorreo;
        private Label labelEjCedula;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}