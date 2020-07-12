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
	public partial class frmMilitar : Form {
		Militar mil;

		public Militar Mil { get => mil; set => mil = value; }

		public frmMilitar() {
			InitializeComponent();
			Mil = Dados.MilitarSelecionado;

			Dados.populateCmbPatente(cmbPatente);
			Dados.populateCmbOM(cmbOM);
			Dados.populateCmbPunicao(cmbPunicao);
			Dados.populateCmbOM(cmbListaOM);
			txtNomeCompleto.Text = Mil.NomeCompleto;
			txtNomeGuerra.Text = Mil.NomeDeGuerra;
			cmbOM.SelectedItem = Mil.OmPertencente;
			txtRegistro.Text = Mil.Registro.Registro;
			cmbPatente.SelectedItem = Mil.Patente;
			txtArmamento.Text = Mil.Armamento.Codigo.ToString();
			if (Mil.Punicao == false) {
				cmbPunicao.SelectedItem = "Não";
			}
			else {
				cmbPunicao.SelectedItem = "Sim";
			}
		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			var form = new frmInicio();
			form.Show();
			this.Hide();
		}

		private void btnVerFichasFATD_Click(object sender, EventArgs e) {
			var form = new frmFichasFATD();
			form.Show();
			this.Hide();
		}

		private void btnVerUniformes_Click(object sender, EventArgs e) {
			var form = new frmUniformes();
			form.Show();
			this.Hide();
		}

		private void btnVerMissoes_Click(object sender, EventArgs e) {
			var form = new frmRegMissoes();
			form.Show();
			this.Hide();
		}

		private void btnimprimirRegistro_Click(object sender, EventArgs e) {
			Dados.MilitarSelecionado.Registro.imprimirDados();
		}

		private void btnImprimirMilitar_Click(object sender, EventArgs e) {
			Dados.MilitarSelecionado.imprimirDados();
		}

		private void btnImprimirArmamento_Click(object sender, EventArgs e) {
			Dados.MilitarSelecionado.Armamento.imprimirDados();
		}

		private void btnImprimirOM_Click(object sender, EventArgs e) {
			Dados.MilitarSelecionado.OmPertencente.imprimirDados();
		}

		private void btnTransferir_Click(object sender, EventArgs e) {
			//Não consegui rodar a interface devido a problemas com minha versão do Visual Studio
			//Mas o código funciona e deixarei ele comentado

			/*String om = cmbListaOM.SelectedItem != null ? cmbListaOM.SelectedItem.ToString() : "";

			if (Dados.verificarPreenchimento(new List<String> { om })) {
				Dados.MilitarSelecionado.OmPertencente.transferirMilitar();
				Dados.MilitarSelecionado.transferir((OrganizacaoMilitar)cmbListaOM.SelectedItem);
				Dados.MilitarSelecionado.OmPertencente.Militares.Add(Dados.MilitarSelecionado);

				cmbOM.SelectedItem = Mil.OmPertencente;
			}*/
		}

		private void btnPegarArmamento_Click(object sender, EventArgs e) {
			Dados.MilitarSelecionado.Armamento.retirarDaReserva();
		}

		private void btnDevolverArmamento_Click(object sender, EventArgs e) {
			Dados.MilitarSelecionado.Armamento.devolverAReserva();
		}

		private void btnPromover_Click(object sender, EventArgs e) {
			String patenteAtual = Dados.MilitarSelecionado.Patente;
			String promocao;
			if (patenteAtual.Equals("Marechal") == false) {
				promocao = Dados.Patentes[Dados.buscaIndexPatente(patenteAtual) + 1];
				Dados.MilitarSelecionado.serPromovido(promocao);
				Dados.MilitarSelecionado.Registro.alterarPatente(promocao);
			}
			else {
				//msgbox
			}
			cmbPatente.SelectedItem = Mil.Patente;
		}

		private void btnPagarPunicao_Click(object sender, EventArgs e) {
			Mil.pagarPunicao();
			if (Mil.Punicao == false) {
				cmbPunicao.SelectedItem = "Não";
			}
			else {
				cmbPunicao.SelectedItem = "Sim";
			}
		}
	}
}
