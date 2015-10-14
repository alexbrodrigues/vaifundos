using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Naval
{
    enum EstadoNavio {Inoperante,MuitoDanificado,Danificado,Perfeito};
    abstract class Navio
    {
        private string Nome;

        public string Nome1
        {
            get { return Nome; }
            set { Nome = value; }
        }
        private int qtdTripulantes;

        public int QtdTripulantes
        {
            get { return qtdTripulantes; }
            set { qtdTripulantes = value; }
        }
        private EstadoNavio estado;

        internal EstadoNavio Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Navio(string Name)
        {
            Nome = Name;
        }

        public Navio(string Name, int qtd)
        {
            Nome = Name;
            qtdTripulantes = qtd;
        }

    }
}
