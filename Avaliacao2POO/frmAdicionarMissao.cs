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
	public partial class frmAdicionarMissao : Form {
		public frmAdicionarMissao() {
			InitializeComponent();

			Dados.populateCmbMissoes(cmbMissoes);
			Dados.populateCmbFuncoes(cmbFuncoes);
		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			var form = new frmRegMissoes();
			form.Show();
			this.Hide();
		}

		private void btnAdicionar_Click(object sender, EventArgs e) {
			String strMissao = cmbMissoes.SelectedItem != null ? cmbMissoes.SelectedItem.ToString() : "";
			String funcao = cmbFuncoes.SelectedItem != null ? cmbFuncoes.SelectedItem.ToString() : "";
			Missao missao = (Missao)cmbMissoes.SelectedItem;

			if (Dados.verificarPreenchimento(new List<String> {strMissao , funcao })) {
				RegistroDeMissao reg = new RegistroDeMissao();
				reg.Missao = missao;
				reg.Militar = Dados.MilitarSelecionado;
				reg.Funcao = funcao;

				Dados.MilitarSelecionado.Missoes.Add(reg);

				missao.inserirRegistro(reg);

				var form = new frmRegMissoes();
				form.Show();
				this.Hide();
			}
		}
	}
}
