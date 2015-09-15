using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaifundos
{
    class Clientes
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int id;

        public int getsetid
        {
            get { return id; }
            set { id = value; }
        }
        private List<Fundo_de_Investimento> Lista_Fundo;

        internal List<Fundo_de_Investimento> Lista_Fundo1
        {
            get { return Lista_Fundo; }
            set { Lista_Fundo = value; }
        }

        public static Clientes BuscaCliente(List<Clientes> busca, int id)
        {
            for (int i = 0; i < busca.Count(); i++)
            {
                if (busca[i].getsetid == id)
                {
                    return busca[i];
                }
            }
            return null;
        }
        public static bool verificaId(List<Clientes> verifica, int id)
        {
            for (int i = 0; i < verifica.Count(); i++)
            {
                if (verifica[i].id.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
