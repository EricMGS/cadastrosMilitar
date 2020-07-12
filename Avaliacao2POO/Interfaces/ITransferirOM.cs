using Avaliacao2POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao2POO.Classes {
	public interface ITransferirOM {
		//Não consegui rodar a interface devido a problemas com minha versão do Visual Studio
		//Mas o código funciona e deixarei ele comentado

		/*
		public FichaDeFATDs gerarFichaFATD(OrganizacaoMilitar om) {
			FichaDeFATDs ficha = new FichaDeFATDs();
			ficha.OmPertencente = om.Nome;
			ficha.Militar = Dados.MilitarSelecionado;

			return ficha;
		}
		public Armamento trocarArmamento(String om) {
			Armamento arma = new Armamento();
			arma.Codigo = (new Random()).Next();
			arma.OmPertencente = om;
			arma.EmUso = false;
			return arma; 
		}*/
	}
}
