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
	public partial class frmRegMissoes : Form {
		public frmRegMissoes() {
			InitializeComponent();

			List<Missao> listaMissoes = new List<Missao>();
			foreach(RegistroDeMissao m in Dados.MilitarSelecionado.Missoes) {
				listaMissoes.Add(m.Missao);
			}
			Dados.populateListBoxMissoes(lstbxMissoes, listaMissoes);
			Dados.populateCmbFuncoes(cmbFuncao);
		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			var form = new frmMilitar();
			form.Show();
			this.Hide();
		}

		private void btnParticipar_Click(object sender, EventArgs e) {
			var form = new frmAdicionarMissao();
			form.Show();
			this.Hide();
		}

		private void btnImprimir_Click(object sender, EventArgs e) {
			String strMissao = lstbxMissoes.SelectedItem != null ? lstbxMissoes.SelectedItem.ToString() : "";
			Missao missao = (Missao)lstbxMissoes.SelectedItem;
			RegistroDeMissao reg;
			if (Dados.verificarPreenchimento(new List<string> { strMissao })) {
				reg = Dados.buscaRegMissao(missao.Objetivo);
				if (reg != null) {
					reg.imprimirDados();
				}
				else {
					MessageBox.Show("Missão não encontrada!", "Erro interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnAlterarFunção_Click(object sender, EventArgs e) {
			String strFuncao = cmbFuncao.SelectedItem != null ? cmbFuncao.SelectedItem.ToString() : "";
			String strMissao = lstbxMissoes.SelectedItem != null ? lstbxMissoes.SelectedItem.ToString() : "";
			Missao missao = (Missao)lstbxMissoes.SelectedItem;
			RegistroDeMissao reg;
			if (Dados.verificarPreenchimento(new List<string> { strFuncao, strMissao })) {
				reg = Dados.buscaRegMissao(missao);
				if (reg != null) {
					reg.alterarFuncao(strFuncao);
				}
				else {
					MessageBox.Show("Registro de Missão não encontrado!", "Erro Interno");
				}
			}
		}
	}
}
