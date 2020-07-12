using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avaliacao2POO;
using System.Windows.Forms;

namespace Avaliacao2POO.Classes {
	//Dados persistentes
	static class Dados {
		//DADOS PERSISTENTES
		//FOI NECESSÁRIA ESSA FORMA DE IMPLEMENTAÇÃO DEVIDO A UM ERRO DE VERSÃO APRESENTADO EM MINHA IDE
		//HOUVE TAMBÉM UM ERRO DE IMPLEMENTAÇÃO DE INTERFACE, ENTÃO DECIDIR DEIXAR TUDO(EXCETO AS CLASSES) GLOBAL PARA MANTER A CONSISTÊNCIA
		private static List<OrganizacaoMilitar> listaOMs = new List<OrganizacaoMilitar>();
		private static List<Militar> listaMilitares = new List<Militar>();
		private static List<Missao> listaMissoes = new List<Missao>();
		private static Militar militarSelecionado;
		private static FichaDeFATDs fichaFATDSelecionada;
		private static SistemaRegistros totalRegistros = new SistemaRegistros();
		//LISTAS DOS COMBOBOX
		private static List<String> regioesMilitares = new List<String> {
		"1ª RM", "2ª RM", "3ª RM", "4ª RM", "5ª RM", "6ª RM", "7ª RM", "8ª RM", "9ª RM", "10ª RM", "11ª RM", "12ª RM"};
		private static List<String> patentes = new List<string> {
		"Soldado", "Cabo", "3º Sargento", "º2 Sargento", "1º Sargento", "Subtenente", "Aspirante a Oficial", "2º Tenente",
		"1º Tenente", "Capitão", "Major", "Tenente-Coronel", "Coronel", "General de Brigada", "General de Divisão", "General do Exército",
		"Marechal"};
		private static List<String> funcoes = new List<String> {"Médico", "Infantaria", "Cavalaria", "Artilharia", "Reconhecimento",
		"Comunicações", "Estratégico"};
		private static List<String> gravidadesFATD = new List<String> { "Leve", "Média", "Pesada"};
		private static List<String> pontosFATD = new List<String> { "1", "2", "5", "10", "12", "15"};
		private static List<String> tamanhosUniforme = new List<String> { "P", "M", "G", "GG"};
		private static List<String> tiposUniforme = new List<string> {
		"Calção TFM", "Camisa TFM", "Tênis TFM", "Calça Camuflada", "Camisa Camuflada", "Gandola", "Gorro", "Boina", "Japona", "Coturno"};
		private static List<String> tiposMissao = new List<string> { 
		"Emboscada", "Reconhecimento", "Patrulha", "Escolta", "Guarda"};

		public static List<string> RegioesMilitares { get => regioesMilitares; set => regioesMilitares = value; }
		public static List<string> Patentes { get => patentes; set => patentes = value; }
		internal static List<OrganizacaoMilitar> ListaOMs { get => listaOMs; set => listaOMs = value; }
		internal static List<Militar> ListaMilitares { get => listaMilitares; set => listaMilitares = value; }
		public static Militar MilitarSelecionado { get => militarSelecionado; set => militarSelecionado = value; }
		internal static FichaDeFATDs FichaFATDSelecionada { get => fichaFATDSelecionada; set => fichaFATDSelecionada = value; }
		public static List<Missao> ListaMissoes { get => listaMissoes; set => listaMissoes = value; }
		internal static SistemaRegistros TotalRegistros { get => totalRegistros; set => totalRegistros = value; }
		public static List<string> Funcoes { get => funcoes; set => funcoes = value; }

		public static bool verificarPreenchimento(List<String> dados) {
			foreach (String item in dados) {
				if (item.Equals("")) {
					MessageBox.Show("Preencha todos os campos!", "Informação incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}
			}
			return true;
		}
		public static void populateCmbOM(ComboBox combo) {
			var bindingSource = new BindingSource();

			bindingSource.DataSource = Dados.ListaOMs;
			combo.DataSource = bindingSource.DataSource;
			combo.DisplayMember = "Nome";
			combo.ValueMember = "Nome";
		}

		public static void populateCmbMilitar(ComboBox combo) {
			var bindingSource = new BindingSource();

			bindingSource.DataSource = Dados.ListaMilitares;
			combo.DataSource = bindingSource.DataSource;
			combo.DisplayMember = "NomeCompleto";
			combo.ValueMember = "NomeCompleto";
		}

		public static void populateCmbFuncoes(ComboBox combo) {
			foreach (String item in Dados.Funcoes) {
				combo.Items.Add(item);
			}
		}

		public static void populateCmbMissoes(ComboBox combo) {
			var bindingSource = new BindingSource();

			bindingSource.DataSource = Dados.ListaMissoes;
			combo.DataSource = bindingSource.DataSource;
			combo.DisplayMember = "Objetivo";
			combo.ValueMember = "Objetivo";
		}

		public static void populateCmbPatente(ComboBox combo) {
			foreach (String item in Dados.Patentes) {
				combo.Items.Add(item);
			}
		}

		public static void populateCmbRegiaoMilitar(ComboBox combo) {
			foreach (String item in Dados.RegioesMilitares) {
				combo.Items.Add(item);
			}
		}

		public static void populateCmbPunicao(ComboBox combo) {
			combo.Items.Add("Sim");
			combo.Items.Add("Não");
		}

		public static void populateCmbGravidadesFATD(ComboBox combo) {
			foreach (String item in Dados.gravidadesFATD) {
				combo.Items.Add(item);
			}
		}
		public static void populateCmbPontosFATD(ComboBox combo) {
			foreach (String item in Dados.pontosFATD) {
				combo.Items.Add(item);
			}
		}
		public static void populateCmbTamanhosUniforme(ComboBox combo) {
			foreach (String item in Dados.tamanhosUniforme) {
				combo.Items.Add(item);
			}
		}
		public static void populateCmbTiposUniforme(ComboBox combo) {
			foreach (String item in Dados.tiposUniforme) {
				combo.Items.Add(item);
			}
		}
		public static void populateCmbTiposMissao(ComboBox combo) {
			foreach (String item in Dados.tiposMissao) {
				combo.Items.Add(item);
			}
		}
		public static void populateCmbdeRala(ComboBox combo) {
			combo.Items.Add("Sim");
			combo.Items.Add("Não");
		}

		public static void populateCmbFATD(ComboBox combo) {
			var bindingSource = new BindingSource();

			bindingSource.DataSource = Dados.MilitarSelecionado.FichasFATD;
			combo.DataSource = bindingSource.DataSource;
			combo.DisplayMember = "OmPertencente";
			combo.ValueMember = "OmPertencente";
		}

		public static void populateListBoxFATD(ListBox listbox, List<FATD> lista) {
			var bindingSource = new BindingSource();

			bindingSource.DataSource = lista;
			listbox.DataSource = bindingSource.DataSource;
			listbox.DisplayMember = "Descricao";
			listbox.ValueMember = "Descricao";
		}

		public static void populateListBoxUniforme(ListBox listbox, List<Uniforme> lista) {
			var bindingSource = new BindingSource();

			bindingSource.DataSource = lista;
			listbox.DataSource = bindingSource.DataSource;
			listbox.DisplayMember = "Tipo";
			listbox.ValueMember = "Tipo";
		}

		public static void populateListBoxMissoes(ListBox listbox, List<Missao> lista) {
			var bindingSource = new BindingSource();

			bindingSource.DataSource = lista;
			listbox.DataSource = bindingSource.DataSource;
			listbox.DisplayMember = "Objetivo";
			listbox.ValueMember = "Objetivo";
		}

		public static Militar buscaMilitar(String nomeCompleto) {
			foreach (Militar mil in Dados.ListaMilitares) {
				if (mil.NomeCompleto.Equals(nomeCompleto)) {
					return mil;
				}
			}
			return null;
		}

		public static int buscaIndexPatente(String patente) {
			int counter = 0;
			foreach (String p in Dados.Patentes) {
				if (p.Equals(patente)) {
					return counter;
				}
				counter += 1;
			}
			return 0;
		}

		public static RegistroDeMissao buscaRegMissao(Missao missao) {
			foreach (RegistroDeMissao reg in Dados.militarSelecionado.Missoes) {
				if (reg.Missao == missao) {
					return reg;
				}
			}
			return null;
		}

		public static RegistroDeMissao buscaRegMissao(String objetivo) {
			foreach (RegistroDeMissao reg in Dados.militarSelecionado.Missoes) {
				if (reg.Missao.Objetivo.Equals(objetivo)) {
					return reg;
				}
			}
			return null;
		}
	}
}
