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
	public partial class frmCadastrarOM : Form {
		public frmCadastrarOM() {
			InitializeComponent();
			Dados.populateCmbRegiaoMilitar(cmbRegiao);
		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			var form = new frmInicio();
			form.Show();
			this.Hide();
		}

		private void btnCadastrar_Click(object sender, EventArgs e) {
			String nome = txtNome.Text;
			String regiao = cmbRegiao.SelectedItem != null ? cmbRegiao.SelectedItem.ToString() : "";
			String cidade = txtCidade.Text;

			if (Dados.verificarPreenchimento(new List<String> { nome, regiao, cidade })) {
				OrganizacaoMilitar om = new OrganizacaoMilitar();
				om.Nome = nome;
				om.RegiaoMilitar = regiao;
				om.Cidade = cidade;
				Dados.ListaOMs.Add(om);

				var form = new frmInicio();
				form.Show();
				this.Hide();
			}
			
		}
	}
}
