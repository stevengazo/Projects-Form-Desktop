﻿namespace Interfaz
{
    partial class Configuracion
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnContrasena = new Button();
            btnActualizarUsuario = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(479, 162);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnContrasena);
            tabPage1.Controls.Add(btnActualizarUsuario);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtUsuario);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(471, 134);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Usuario";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnContrasena
            // 
            btnContrasena.Location = new Point(35, 97);
            btnContrasena.Name = "btnContrasena";
            btnContrasena.Size = new Size(146, 23);
            btnContrasena.TabIndex = 6;
            btnContrasena.Text = "Cambiar Contraseña";
            btnContrasena.UseVisualStyleBackColor = true;
            btnContrasena.Click += button5_Click;
            // 
            // btnActualizarUsuario
            // 
            btnActualizarUsuario.Location = new Point(187, 97);
            btnActualizarUsuario.Name = "btnActualizarUsuario";
            btnActualizarUsuario.Size = new Size(117, 23);
            btnActualizarUsuario.TabIndex = 4;
            btnActualizarUsuario.Text = "Actualizar Datos";
            btnActualizarUsuario.UseVisualStyleBackColor = true;
            btnActualizarUsuario.Click += btnActualizarUsuario_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(293, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 66);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre y Apellido";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(155, 19);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(293, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 27);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario";
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 186);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Configuracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuracion";
            Load += Configuracion_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtUsuario;
        private Label label1;
        private Button btnActualizarUsuario;
        private TextBox txtNombre;
        private Label label2;
        private Button btnContrasena;
    }
}