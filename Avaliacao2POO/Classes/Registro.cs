using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao2POO.Classes {
	public abstract class Registro {
		private int codigo;
		private DateTime date;

		public int Codigo { get => codigo; set => codigo = value; }
		public DateTime Date { get => date; set => date = value; }

		public void ObterCodigo() { }
	}
}
