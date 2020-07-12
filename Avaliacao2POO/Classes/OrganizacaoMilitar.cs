using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao2POO.Classes {
	public class OrganizacaoMilitar {
		private String nome;
		private List<Militar> militares = new List<Militar>();
		private String cidade;
		private String regiaoMilitar;

		public string Nome { get => nome; set => nome = value; }
		public string Cidade { get => cidade; set => cidade = value; }
		public string RegiaoMilitar { get => regiaoMilitar; set => regiaoMilitar = value; }
		internal List<Militar> Militares { get => militares; set => militares = value; }

		public void imprimirDados() {
			String impressao = "Nome da OM: " + Nome + "\n" + "Cidade: " + Cidade + "\n" +
				"Região Militar: " + RegiaoMilitar + "\n\nMilitares: \n";
			foreach (Militar mil in Militares) {
				impressao = impressao + mil.NomeCompleto + "\n";
			}

			MessageBox.Show(impressao, "Organização Militar");
		}

		public void transferirMilitar() { }
	}
}
