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
	public partial class frmCadastrarMilitar : Form {
		public frmCadastrarMilitar() {
			InitializeComponent();

			Dados.populateCmbOM(cmbOM);
			Dados.populateCmbPatente(cmbPatente);
		}
		private void btnVoltar_Click(object sender, EventArgs e) {
			var form = new frmInicio();
			form.Show();
			this.Hide();
		}

		private void btnCadastrar_Click(object sender, EventArgs e) {
			String om = cmbOM.SelectedItem != null ? cmbOM.SelectedItem.ToString() : "";
			String nomeCompleto = txtNomeCompleto.Text;
			String nomeGuerra = txtNomeGuerra.Text;
			String patente = cmbPatente.SelectedItem != null ? cmbPatente.SelectedItem.ToString() : "";
			String registro = txtRegistro.Text;

			if (Dados.verificarPreenchimento(new List<String> { om, nomeCompleto, nomeGuerra, patente, registro })) {
				Militar mil = new Militar();
				mil.NomeCompleto = nomeCompleto;
				mil.NomeDeGuerra = nomeGuerra;
				mil.Patente = patente;
				mil.Registro = new RegistroMilitar();
				mil.Registro.Registro = registro;
				mil.Registro.Militar = mil;
				mil.Registro.Patente = patente;
				mil.OmPertencente = (OrganizacaoMilitar)cmbOM.SelectedItem;
				mil.OmPertencente.Militares.Add(mil);
				mil.Punicao = false;
				Armamento armamento = new Armamento();
				armamento.Codigo = (new Random()).Next();
				armamento.OmPertencente = ((OrganizacaoMilitar)cmbOM.SelectedItem).Nome;
				armamento.EmUso = false;
				mil.Armamento = armamento;
				FichaDeFATDs fichaFATD = new FichaDeFATDs();
				fichaFATD.Militar = mil;
				fichaFATD.OmPertencente = ((OrganizacaoMilitar)cmbOM.SelectedItem).Nome;

				mil.FichasFATD.Add(fichaFATD);
				//dataNascimento
				
				Dados.ListaMilitares.Add(mil);

				var form = new frmInicio();
				form.Show();
				this.Hide();
			}
		}
	}
}
