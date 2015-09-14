using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaifundos
{
    
    class Fundo_de_Investimento
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string sigla;

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        private List<Aplicação> aplicacoes;

internal List<Aplicação> Aplicacoes
{
  get { return aplicacoes; }
  set { aplicacoes = value; }
}
        public static void ImprimirFundo(List<Fundo_de_Investimento> impressao)
        {
            for(int i = 0; i < impressao.Count(); i++)
            {
                 Console.WriteLine("{0}.{1}.{2}",i, impressao[i].Nome, impressao[i].Sigla);
            }
        }

        public static bool VerificaSigla(List<Fundo_de_Investimento> verifica, string sigla)
        {
            for (int i = 0; i < verifica.Count(); i++)
            {
                if (verifica[i].Sigla.Equals(sigla))
                {
                    return true;
                }
            }
            return false;
        }
        public static Fundo_de_Investimento BuscaFundo(List<Fundo_de_Investimento> busca, string sigla)
        {
            for (int i = 0; i < busca.Count(); i++)
            {
                if (busca[i].Sigla == sigla)
                {
                    return busca[i];
                }
            }
            return null;
        }

    }
}
