using Avaliacao2POO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2POO {
	public partial class frmInicio : Form {
		public frmInicio() {
			InitializeComponent();
			Dados.populateCmbOM(cmbOM_Inicio);
			Dados.populateCmbMilitar(cmbMilitar_Inicio);
			Dados.populateCmbMissoes(cmbMissao);
	}


		private void btnVerFicha_Click(object sender, EventArgs e) {
			String om = cmbOM_Inicio.SelectedItem != null ? cmbOM_Inicio.SelectedItem.ToString() : "";
			String mil = cmbMilitar_Inicio.SelectedItem != null ? cmbMilitar_Inicio.SelectedItem.ToString() : "";

			if (Dados.verificarPreenchimento(new List<String> { om, mil})) {
				Militar militarSelecionado = Dados.buscaMilitar(cmbMilitar_Inicio.SelectedValue.ToString());
				if (militarSelecionado != null) {
					Dados.MilitarSelecionado = militarSelecionado;
					var form = new frmMilitar();
					form.Show();
					this.Hide();
				}
				else {
					MessageBox.Show("Militar não encontrado!", "Erro interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnCadastrarOM_Click(object sender, EventArgs e) {
			var form = new frmCadastrarOM();
			form.Show();
			this.Hide();
		}

		private void btnCadastrarMilitar_Click(object sender, EventArgs e) {
			var form = new frmCadastrarMilitar();
			form.Show();
			this.Hide();
		}

		private void btnImprimirOM_Click(object sender, EventArgs e) {
			String om = cmbOM_Inicio.SelectedItem != null ? cmbOM_Inicio.SelectedItem.ToString() : "";
			if(Dados.verificarPreenchimento(new List<string> {om})) {
				((OrganizacaoMilitar)cmbOM_Inicio.SelectedItem).imprimirDados();
			}
		}

		private void btnCadastrarMissao_Click(object sender, EventArgs e) {
			var form = new frmCadastrarMissao();
			form.Show();
			this.Hide();
		}

		private void btnImprimirMissao_Click(object sender, EventArgs e) {
			String missao = cmbMissao.SelectedItem != null ? cmbMissao.SelectedItem.ToString() : "";
			if (Dados.verificarPreenchimento(new List<string> { missao })) {
				((Missao)cmbMissao.SelectedItem).imprimirDados();
			}
		}

		private void btnImprimirRegistros_Click(object sender, EventArgs e) {
			Dados.TotalRegistros.imprimirDados();
		}
	}
}
