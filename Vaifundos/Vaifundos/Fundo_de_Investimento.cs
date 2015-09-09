using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaifundos
{
    enum Tipo { Dólar, Real }
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
        private Enum tipo;

        public Enum Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
