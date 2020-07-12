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
	public partial class frmFichasFATD : Form {
		private bool isComboLoaded = false;
		public frmFichasFATD() {
			InitializeComponent();
			Dados.populateCmbFATD(cmbFicha);
			isComboLoaded = true;

			Dados.populateListBoxFATD(lstbxFATDs, ((FichaDeFATDs)cmbFicha.SelectedItem).Fatds);
		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			var form = new frmMilitar();
			form.Show();
			this.Hide();
		}

		private void btnAdicionar_Click(object sender, EventArgs e) {
			Dados.FichaFATDSelecionada = (FichaDeFATDs)cmbFicha.SelectedItem;
			var form = new frmAdicionarFATD();
			form.Show();
			this.Hide();
		}

		private void cmbFicha_SelectedIndexChanged(object sender, EventArgs e) {
			if (isComboLoaded) {
				//lstbxFATDs.Items.Clear();
				Dados.populateListBoxFATD(lstbxFATDs, ((FichaDeFATDs)cmbFicha.SelectedItem).Fatds);
			}
		}

		private void btnImprimirFicha_Click(object sender, EventArgs e) {
			String fichaFATD = cmbFicha.SelectedItem != null ? cmbFicha.SelectedItem.ToString() : "";
			if (Dados.verificarPreenchimento(new List<string> { fichaFATD })) {
				((FichaDeFATDs)cmbFicha.SelectedItem).imprimirDados();
			}
		}

		private void btnImprimirFATD_Click(object sender, EventArgs e) {
			String fatd = lstbxFATDs.SelectedItem != null ? lstbxFATDs.SelectedItem.ToString() : "";
			if (Dados.verificarPreenchimento(new List<string> { fatd })) {
				((FATD)lstbxFATDs.SelectedItem).imprimirDados();
			}
		}

		private void btnApurar_Click(object sender, EventArgs e) {
			String fatd = lstbxFATDs.SelectedItem != null ? lstbxFATDs.SelectedItem.ToString() : "";
			if (Dados.verificarPreenchimento(new List<string> { fatd })) {
				((FATD)lstbxFATDs.SelectedItem).apurarJustificativa();
			}
		}

		private void btnCalcPontuacao_Click(object sender, EventArgs e) {
			String fichaFATD = cmbFicha.SelectedItem != null ? cmbFicha.SelectedItem.ToString() : "";
			int pontuacao;
			if (Dados.verificarPreenchimento(new List<string> { fichaFATD })) {
				pontuacao = ((FichaDeFATDs)cmbFicha.SelectedItem).calcularPontuacao();
				txtPontuacao.Text = pontuacao.ToString();
			}
		}

		private void btnGerarPunicao_Click(object sender, EventArgs e) {
			Dados.MilitarSelecionado.Punicao = true;
		}
	}
}
