using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2POO.Classes {
	public class RegistroDeMissao {
		private Missao missao;
		private Militar militar;
		private String funcao;

		public string Funcao { get => funcao; set => funcao = value; }
		internal Missao Missao { get => missao; set => missao = value; }
		internal Militar Militar { get => militar; set => militar = value; }

		public void imprimirDados() {
			String impressao = "Missão: " + missao.Objetivo + "\nMilitar: " + militar.NomeCompleto + "\nFunção: " + funcao;
			MessageBox.Show(impressao, "Registro de Missão");
		}

		public void alterarFuncao(String funcao) {
			this.Funcao = funcao;
		}
	}
}
