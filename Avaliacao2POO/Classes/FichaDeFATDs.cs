using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Avaliacao2POO.Classes {
	class FichaDeFATDs {
		private String omPertencente;
		private Militar militar;
		private List<FATD> fatds = new List<FATD>();
		private int pontuacao = 0;

		public string OmPertencente { get => omPertencente; set => omPertencente = value; }
		public int Pontuacao { get => pontuacao; set => pontuacao = value; }
		internal Militar Militar { get => militar; set => militar = value; }
		internal List<FATD> Fatds { get => fatds; set => fatds = value; }

		public void imprimirDados() {
			String impressao = "Militar: " + Militar.NomeCompleto + "\nOrganização Militar: " + OmPertencente + "\nPontuação: " +
				Pontuacao.ToString();
			MessageBox.Show(impressao, "Ficha de FATDs");
		}

		public int calcularPontuacao() {
			int pontuacao = 0;
			foreach (FATD f in Fatds) {
				pontuacao += f.Pontos;
			}
			return pontuacao;
		}

		public void gerarPunicao() {
			Dados.MilitarSelecionado.Punicao = true;
		}
	}
}
