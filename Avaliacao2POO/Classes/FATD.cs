using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2POO.Classes {
	class FATD : Registro{
		private String descricao;
		private String gravidade;
		private FichaDeFATDs ficha;
		private int pontos;
		private String justificativa;

		public string Descricao { get => descricao; set => descricao = value; }
		public string Gravidade { get => gravidade; set => gravidade = value; }
		public int Pontos { get => pontos; set => pontos = value; }
		public string Justificativa { get => justificativa; set => justificativa = value; }
		internal FichaDeFATDs Ficha { get => ficha; set => ficha = value; }

		public FATD() {
			this.ObterCodigo();
		}

		public void imprimirDados() {
			String impressao = "Código da FATD: " + this.Codigo + "\nGravidade: " + Gravidade + "\nPontos: " + Pontos.ToString() + 
				"\nOrganização Militar: " + Ficha.OmPertencente + "\nDescrição: " + Descricao + "\nJustificativa: " + Justificativa;
			MessageBox.Show(impressao, "Formulário de Apuração de Transgressão Disciplinar");
		}

		public void apurarJustificativa() {
			this.Pontos = 0;
		}

		public void ObterCodigo() {
			this.Codigo = Dados.TotalRegistros.gerarRegFATD();
		}


	}
}
