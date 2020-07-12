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
	public partial class frmAdicionarUniforme : Form {
		public frmAdicionarUniforme() {
			InitializeComponent();
			Dados.populateCmbTamanhosUniforme(cmbTamanho);
			Dados.populateCmbTiposUniforme(cmbTipo);
			Dados.populateCmbdeRala(cmbDeRala);
		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			var form = new frmUniformes();
			form.Show();
			this.Hide();
		}

		private void btnAdicionar_Click(object sender, EventArgs e) {
			String tamanho = cmbTamanho.SelectedItem != null ? cmbTamanho.SelectedItem.ToString() : "";
			String tipo = cmbTipo.SelectedItem != null ? cmbTipo.SelectedItem.ToString() : "";
			String deRala = cmbDeRala.SelectedItem != null ? cmbDeRala.SelectedItem.ToString() : "";

			if (Dados.verificarPreenchimento(new List<string> { tamanho, tipo, deRala })) {
				Uniforme uniforme = new Uniforme();
				uniforme.Tamanho = tamanho;
				uniforme.Tipo = tipo;
				if (deRala.Equals("Sim")){
					uniforme.DeRala = true;
				}
				else {
					uniforme.DeRala = false;
				}
				
				Dados.MilitarSelecionado.Uniformes.Add(uniforme);
				
				var form = new frmUniformes();
				form.Show();
				this.Hide();
			}
		}
	}
}
