using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Avaliacao2POO.Classes {
	public class Missao : Registro{
		private String tipo;
		private String objetivo;
		private List<RegistroDeMissao> registros = new List<RegistroDeMissao>();

		public string Tipo { get => tipo; set => tipo = value; }
		public string Objetivo { get => objetivo; set => objetivo = value; }
		internal List<RegistroDeMissao> Registros { get => registros; set => registros = value; }

		public Missao() {
			this.ObterCodigo();
		}

		public void imprimirDados() {
			String impressao = "Código da Missão: " + this.Codigo + "\nTipo de missão: " + tipo + "\n" + "Objetivo: " + objetivo;

			MessageBox.Show(impressao, "Missão");
		}

		public void inserirRegistro(RegistroDeMissao reg) {
			Registros.Add(reg);
		}

		public void ObterCodigo() {
			this.Codigo = Dados.TotalRegistros.gerarRegMissao();
		}
	}
}
