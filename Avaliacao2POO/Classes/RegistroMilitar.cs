using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2POO.Classes {
	class RegistroMilitar {
		private String registro;
		private Militar militar;
		private String patente;

		public string Registro { get => registro; set => registro = value; }
		public string Patente { get => patente; set => patente = value; }
		internal Militar Militar { get => militar; set => militar = value; }

		public void imprimirDados() {
			String impressao = "Registro: " + Registro + "\nMilitar: " + Militar.NomeCompleto + "\nPatente: " + Patente;

			MessageBox.Show(impressao, "Registro Militar");
		}

		public void alterarPatente(String patente) {
			this.Patente = patente;
		}
	}
}
