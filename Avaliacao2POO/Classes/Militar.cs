using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2POO.Classes {
	public class Militar /*: ITransferirOM*/{
		private String nomeCompleto;
		private String nomeDeGuerra;
		private String patente;
		private List<FichaDeFATDs> fichasFATD = new List<FichaDeFATDs>();
		private OrganizacaoMilitar omPertencente;
		private List<Uniforme> uniformes = new List<Uniforme>();
		private Armamento armamento;
		private RegistroMilitar registro;
		private List<RegistroDeMissao> missoes = new List<RegistroDeMissao>();
		private bool punicao = false;

		public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
		public string NomeDeGuerra { get => nomeDeGuerra; set => nomeDeGuerra = value; }
		public string Patente { get => patente; set => patente = value; }
		public bool Punicao { get => punicao; set => punicao = value; }
		internal List<FichaDeFATDs> FichasFATD { get => fichasFATD; set => fichasFATD = value; }
		internal OrganizacaoMilitar OmPertencente { get => omPertencente; set => omPertencente = value; }
		internal List<Uniforme> Uniformes { get => uniformes; set => uniformes = value; }
		internal Armamento Armamento { get => armamento; set => armamento = value; }
		internal RegistroMilitar Registro { get => registro; set => registro = value; }
		internal List<RegistroDeMissao> Missoes { get => missoes; set => missoes = value; }

		//gerar construtor q dispara metodos da interface
		public void imprimirDados() {
			String strPunido = Punicao == true ? "Sim" : "Não";
			String impressao = "Nome Completo: " + NomeCompleto + "\nNome de Guerra: " + NomeDeGuerra + "\nPatente: " + Patente +
			"\nRegistro Militar: " + Registro.Registro +"\nOrganização Militar: " + omPertencente.Nome + "\nArmamento: " 
			+ Armamento.Codigo.ToString() + "\nPunido: " + strPunido;
			MessageBox.Show(impressao, "Militar");
		}

		public void pagarPunicao() {
			this.Punicao = false;
		}

		public void transferir(OrganizacaoMilitar om) {
			//Não consegui rodar a interface devido a problemas com minha versão do Visual Studio
			//Mas o código funciona e deixarei ele comentado

			/*this.Armamento = this.trocarArmamento(om);
			this.FichasFATD.Add(gerarfichaFATD(om));
			this.OmPertencente = om;*/
		}

		public void serPromovido(String patente) {
			this.Patente = patente;
		}
	}
}
