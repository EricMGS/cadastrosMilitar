using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2POO.Classes {
	class SistemaRegistros {
		private int ultimoRegFATD = 0;
		private int ultimoRegMissao = 0;

		public int UltimoRegFATD { get => ultimoRegFATD; set => ultimoRegFATD = value; }
		public int UltimoRegMissao { get => ultimoRegMissao; set => ultimoRegMissao = value; }

		public void imprimirDados() {
			String impressao = "Total de FATDs: " + UltimoRegFATD + "\nTotal de Missões: " + UltimoRegMissao;
			MessageBox.Show(impressao, "Total de Registros");
		}

		public int gerarRegFATD() {
			UltimoRegFATD += 1;
			return UltimoRegFATD;
		}

		public int gerarRegMissao() {
			UltimoRegMissao += 1;
			return UltimoRegMissao;
		}
	}
}
