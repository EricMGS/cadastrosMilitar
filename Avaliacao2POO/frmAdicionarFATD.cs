using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avaliacao2POO.Classes;

namespace Avaliacao2POO {
	public partial class frmAdicionarFATD : Form {
		public frmAdicionarFATD() {
			InitializeComponent();
			Dados.populateCmbGravidadesFATD(cmbGravidade);
			Dados.populateCmbPontosFATD(cmbPontos);
		}

		private void btnAdicionar_Click(object sender, EventArgs e) {
			String gravidade = cmbGravidade.SelectedItem != null ? cmbGravidade.SelectedItem.ToString() : "";
			String pontos = cmbPontos.SelectedItem != null ? cmbPontos.SelectedItem.ToString() : "";
			String descricao = txtDescricao.Text;
			String justificativa = txtJustificativa.Text;

			if (Dados.verificarPreenchimento(new List<String> { gravidade, pontos, descricao, justificativa })) {
				//cadastrar
				FATD fatd = new FATD();
				fatd.Gravidade = gravidade;
				fatd.Pontos = Int32.Parse(pontos);
				fatd.Descricao = descricao;
				fatd.Justificativa = justificativa;
				fatd.Ficha = Dados.FichaFATDSelecionada;
				Dados.FichaFATDSelecionada.Fatds.Add(fatd);

				var form = new frmFichasFATD();
				form.Show();
				this.Hide();
			}
		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			var form = new frmFichasFATD();
			form.Show();
			this.Hide();
		}

		private void frmAdicionarFATD_Load(object sender, EventArgs e) {

		}
	}
}
