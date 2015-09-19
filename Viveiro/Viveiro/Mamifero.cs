using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viveiro
{
    class Mamifero: Animal
    {
        private int qtdGlandulasMamarias;

        public int QtdGlandulasMamarias
        {
            get
            {
                return qtdGlandulasMamarias;
            }

            set
            {
                qtdGlandulasMamarias = value;
            }
        }

        public override bool Comer(float qtd)
        {
            while (qtd < CapEstomago)
            {
                return true;
            }
            return false;
        }
    }
}
