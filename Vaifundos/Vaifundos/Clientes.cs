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

        public int Id
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
    }
}
