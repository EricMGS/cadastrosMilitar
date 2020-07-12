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
	public partial class frmUniformes : Form {
		public frmUniformes() {
			InitializeComponent();
			Dados.populateListBoxUniforme(lstbxUniformes, Dados.MilitarSelecionado.Uniformes);
		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			var form = new frmMilitar();
			form.Show();
			this.Hide();
		}

		private void btnAdicionar_Click(object sender, EventArgs e) {
			var form = new frmAdicionarUniforme();
			form.Show();
			this.Hide();
		}

		private void btnImprimir_Click(object sender, EventArgs e) {
			String uniforme = lstbxUniformes.SelectedItem != null ? lstbxUniformes.SelectedItem.ToString() : "";
			if (Dados.verificarPreenchimento(new List<string> { uniforme })) {
				((Uniforme)lstbxUniformes.SelectedItem).imprimirDados();
			}
		}

		private void btnMudarParaRala_Click(object sender, EventArgs e) {
			String uniforme = lstbxUniformes.SelectedItem != null ? lstbxUniformes.SelectedItem.ToString() : "";
			if (Dados.verificarPreenchimento(new List<string> { uniforme })) {
				((Uniforme)lstbxUniformes.SelectedItem).mudarParaRala();
			}
		}

		private void btnMudarParaUso_Click(object sender, EventArgs e) {
			String uniforme = lstbxUniformes.SelectedItem != null ? lstbxUniformes.SelectedItem.ToString() : "";
			if (Dados.verificarPreenchimento(new List<string> { uniforme })) {
				((Uniforme)lstbxUniformes.SelectedItem).mudarParaUso();
			}
		}
	}
}
