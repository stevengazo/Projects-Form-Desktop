﻿namespace Interfaz
{
	partial class AgregarUsuario
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.txtContrasenaConfirmacion = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Login";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contraseña ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Confirmar Contraseña";
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(163, 18);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.PlaceholderText = "Admin";
			this.txtLogin.Size = new System.Drawing.Size(234, 23);
			this.txtLogin.TabIndex = 4;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(163, 53);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.PlaceholderText = "Administrador";
			this.txtNombre.Size = new System.Drawing.Size(234, 23);
			this.txtNombre.TabIndex = 5;
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(163, 89);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.PasswordChar = '*';
			this.txtContrasena.PlaceholderText = "Contraseña";
			this.txtContrasena.Size = new System.Drawing.Size(234, 23);
			this.txtContrasena.TabIndex = 6;
			// 
			// txtContrasenaConfirmacion
			// 
			this.txtContrasenaConfirmacion.Location = new System.Drawing.Point(163, 127);
			this.txtContrasenaConfirmacion.Name = "txtContrasenaConfirmacion";
			this.txtContrasenaConfirmacion.PasswordChar = '*';
			this.txtContrasenaConfirmacion.PlaceholderText = "Contraseña";
			this.txtContrasenaConfirmacion.Size = new System.Drawing.Size(234, 23);
			this.txtContrasenaConfirmacion.TabIndex = 7;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(98, 168);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 8;
			this.btnAgregar.Text = "Agregar ";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(205, 168);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 9;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// AgregarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 203);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtContrasenaConfirmacion);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AgregarUsuario";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Usuario";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txtLogin;
		private TextBox txtNombre;
		private TextBox txtContrasena;
		private TextBox txtContrasenaConfirmacion;
		private Button btnAgregar;
		private Button btnCancelar;
	}
}