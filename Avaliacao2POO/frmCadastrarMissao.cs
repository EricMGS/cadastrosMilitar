using Avaliacao2POO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2POO {
	public partial class frmCadastrarMissao : Form {
		public frmCadastrarMissao() {
			InitializeComponent();
			Dados.populateCmbTiposMissao(cmbTipo);
		}

		private void btnAdicionar_Click(object sender, EventArgs e) {
			String tipo = cmbTipo.SelectedItem != null ? cmbTipo.SelectedItem.ToString() : "";
			String objetivo = txtObjetivo.Text;

			if (Dados.verificarPreenchimento(new List<string> {tipo, objetivo })) {
				Missao missao = new Missao();
				missao.Tipo = tipo;
				missao.Objetivo = objetivo;
				Dados.ListaMissoes.Add(missao);

				var form = new frmInicio();
				form.Show();
				this.Hide();
			}
		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			var form = new frmInicio();
			form.Show();
			this.Hide();
		}
	}
}
