﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Modelos;
using Negocios;

namespace Interfaz
{
	public partial class EditarOferta : Form
	{
		public int idOferta { get; set; } = -1;
		private List<Usuario> usuarios;
		private Oferta Ofertatmp;
		public EditarOferta()
		{
			InitializeComponent();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			try
			{

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}
		private bool ValidarCampos()
		{
			try
			{
				if (string.IsNullOrEmpty(txtCliente.Text))
				{
					MessageBox.Show($"Nombre del Cliente no digitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
				int.TryParse(txtMonto.Text, out int val);
				if (val == 0)
				{
					var resultado = MessageBox.Show($"Monto No digitado\n¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (resultado == DialogResult.Yes)
					{

					}
					else
					{
						return false;
					}
				}
				if (string.IsNullOrEmpty(txtNotas.Text))
				{
					var resultado = MessageBox.Show($"Monto notas de la cotización\n¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (resultado == DialogResult.Yes)
					{

					}
					else
					{
						return false;
					}
				}
				if (string.IsNullOrEmpty(txtObservaciones.Text))
				{
					MessageBox.Show("Descripcion del trabajo no mencionada", "Adventencia", MessageBoxButtons.OK);
				}
				if (string.IsNullOrEmpty(cbEncargado.Text))
				{
					MessageBox.Show($"No selecciono un vendedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
				if (string.IsNullOrEmpty(txtEncargado.Text))
				{
					MessageBox.Show($"No ingreso un encargado de la realizacion de la cotizacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return false;
			}
		}

		private void EditarOferta_Load(object sender, EventArgs e)
		{
			try
			{
				UsuarioNegocio tmpNegocioUsuario = new();
				usuarios = tmpNegocioUsuario.ListarVendedores().Distinct().ToList();
				foreach (var item in usuarios)
				{
					cbEncargado.Items.Add(item.Nombre);
				}
				if(idOferta != -1)
				{
					OfertaNegocio ofertaNegocio = new();
					Ofertatmp = ofertaNegocio.ObtenerOferta(idOferta);
					if(Ofertatmp == null)
					{
						MessageBox.Show($"Error interno: el id de oferta no fue especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();
					}
					else
					{
						dateTimePickerFecha.Value = Ofertatmp.Fecha;
						checkBoxSellador.Checked = Ofertatmp.Sellador;
						checkBoxAsfalto.Checked = Ofertatmp.Asfalto;
						checkBoxBase.Checked = Ofertatmp.Base;
						checkBoxSubbase.Checked = Ofertatmp.SubBase;
						checkBoxExcavacion.Checked = Ofertatmp.Excavacion;
						txtCliente.Text = Ofertatmp.Cliente;
						txtMonto.Text = Ofertatmp.Monto.ToString();
						txtNotas.Text = Ofertatmp.Notas;
						txtObservaciones.Text = Ofertatmp.Observaciones;
						cbEncargado.SelectedText = Ofertatmp.Encargado.Nombre;
						txtEncargado.Text = Ofertatmp.EncargadoCotizador;
					}
				}
				else
				{
					MessageBox.Show($"Error interno: el id de oferta no fue especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				bool valido = ValidarCampos();
				if (valido)
				{
					Oferta ofertaTemporal = new();
					ofertaTemporal.AutorPrespuesto = Temporal.UsuarioActivo.Nombre;
					ofertaTemporal.UltimaModificacion = DateTime.Now;
					ofertaTemporal.Fecha = dateTimePickerFecha.Value;
					ofertaTemporal.Sellador = checkBoxSellador.Checked;
					ofertaTemporal.Asfalto = checkBoxAsfalto.Checked;
					ofertaTemporal.Base = checkBoxBase.Checked;
					ofertaTemporal.SubBase = checkBoxSubbase.Checked;
					ofertaTemporal.Excavacion = checkBoxExcavacion.Checked;
					ofertaTemporal.Cliente = txtCliente.Text;
					float.TryParse(txtMonto.Text, out float tmpNumero);
					ofertaTemporal.Monto = tmpNumero;
					ofertaTemporal.Notas = txtNotas.Text;
					ofertaTemporal.Observaciones = txtObservaciones.Text;
					ofertaTemporal.UsuarioId = (from i in usuarios
												where i.Nombre == cbEncargado.Text
												select i.UsuarioId).FirstOrDefault();
					ofertaTemporal.EncargadoCotizador = txtEncargado.Text;
					OfertaNegocio negocioOferta = new();
					bool Resultado = negocioOferta.ActualizarOferta(ofertaTemporal, out int idOferta);
					if (Resultado)
					{
						MessageBox.Show($"Oferta Actualizada exitosamente \n\nOferta Id= {idOferta}\nCliente= {ofertaTemporal.Cliente}\nMonto= {ofertaTemporal.Monto}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
					else
					{
						MessageBox.Show($"Error interno, no fue posible guardar la informacion", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error interno, no fue posible guardar la informacion. {ex.Message}", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}