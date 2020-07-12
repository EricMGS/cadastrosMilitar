using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2POO.Classes {
	class Uniforme {
		private String tamanho;
		private String tipo;
		private bool deRala;

		public string Tamanho { get => tamanho; set => tamanho = value; }
		public string Tipo { get => tipo; set => tipo = value; }
		public bool DeRala { get => deRala; set => deRala = value; }

		public void imprimirDados() {
			String strRala = DeRala == true ? "Sim" : "Não";
			String impressao = "Tipo de uniforme: " + tipo + "\nTamanho: " + tamanho + "\nDe rala?: " + strRala;
			MessageBox.Show(impressao, "Uniforme");
		}

		public void mudarParaRala() {
			DeRala = true;
		}

		public void mudarParaUso() {
			DeRala = false;
		}
	}
}
