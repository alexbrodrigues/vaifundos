﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaifundos
{
    class Fundo_Investimento_Real: Fundo_de_Investimento
    {
        private float imposto;

        public float Imposto
        {
            get { return imposto; }
            set { imposto = value; }
        }
    }
}
