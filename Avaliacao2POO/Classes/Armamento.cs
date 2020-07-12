using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2POO.Classes {
	class Armamento {
		private int codigo;
		private String omPertencente;
		private bool emUso;

		public int Codigo { get => codigo; set => codigo = value; }
		public bool EmUso { get => emUso; set => emUso = value; }
		public string OmPertencente { get => omPertencente; set => omPertencente = value; }

		public void imprimirDados() {
			String strUso = EmUso == true ? "Sim" : "Não";
			String impressao = "Código do armamento: " + Codigo + "\nOM responsável: " + OmPertencente + "\nEm Uso: " + strUso;
			MessageBox.Show(impressao, "Armamento");
		}

		public void retirarDaReserva() {
			EmUso = true;
		}

		public void devolverAReserva() {
			EmUso = false;
		}
	}
}
