using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaifundos
{

    class Fundo_de_Investimento
    {
        protected string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        protected string sigla;

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        protected List<Aplicação> aplicacoes;

        internal List<Aplicação> Aplicacoes
        {
            get { return aplicacoes; }
            set { aplicacoes = value; }
        }
        public static void ImprimirFundo(List<Fundo_de_Investimento> impressao)
        {
            for (int i = 0; i < impressao.Count(); i++)
            {
                Console.WriteLine("{0}.{1}.{2}", i, impressao[i].Nome, impressao[i].Sigla);
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
        public int[] Notasasacar
        {
            get { return Notasasacar; }
            set { Notasasacar = value; }
        }
        public string melhortroco(Aplicação a)
        {
            float valor = a.Valor;
            int[] notas = Notasasacar;
            float troco;
            int i;

            //////////////////ORDENA AS NOTAS INSERIDAS///////////////////////////
            int aux = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = 0; j < notas.Length; j++)
                {
                    if (notas[i] < notas[j])
                    {
                        aux = notas[i];
                        notas[i] = notas[j];
                        notas[j] = aux;
                    }
                }
            }
            ////////////////////CALCULA MELHOR RESGATE//////////////////////////////
            int[] nmoedas = new int[notas.Length];
            while (valor != troco && i < notas.Length)
            {

                if (troco >= notas[i])
                {
                    int j = i;
                    while (j < notas.Length)
                    {
                        valor += notas[j];
                        nmoedas[j] += 1;

                        if (valor > troco)
                        {
                            valor -= notas[j];
                            nmoedas[j] -= 1;
                            j++;
                        }
                        else if (valor == troco)
                        {
                            string c = Convert.ToString(notas);
                            return c;
                        }
                    }
                    valor -= notas[i];
                    nmoedas[i] -= 1;
                    i++;
                }
                else
                    i++;
            }
        }
    }
}
