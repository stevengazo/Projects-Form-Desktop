﻿namespace Interfaz
{
	partial class CambiarContrasena
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
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.txtVerificarContrasena = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCambiar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(155, 12);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(193, 23);
			this.txtContrasena.TabIndex = 0;
			// 
			// txtVerificarContrasena
			// 
			this.txtVerificarContrasena.Location = new System.Drawing.Point(155, 41);
			this.txtVerificarContrasena.Name = "txtVerificarContrasena";
			this.txtVerificarContrasena.Size = new System.Drawing.Size(193, 23);
			this.txtVerificarContrasena.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nueva Contraseña";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Confirmar Contraseña";
			// 
			// btnCambiar
			// 
			this.btnCambiar.Location = new System.Drawing.Point(12, 70);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(141, 23);
			this.btnCambiar.TabIndex = 4;
			this.btnCambiar.Text = "Cambiar Contraseña";
			this.btnCambiar.UseVisualStyleBackColor = true;
			this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(172, 70);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Cancelar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// CambiarContrasena
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 101);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnCambiar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtVerificarContrasena);
			this.Controls.Add(this.txtContrasena);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CambiarContrasena";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambio Contraseña";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtContrasena;
		private TextBox txtVerificarContrasena;
		private Label label1;
		private Label label2;
		private Button btnCambiar;
		private Button button1;
	}
}