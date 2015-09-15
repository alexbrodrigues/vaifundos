using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaifundos
{

    class Aplicação
    {
        private DateTime data_aplicacao;

        public DateTime Data_aplicacao
        {
            get { return data_aplicacao; }
            set { data_aplicacao = value; }
        }
        private float valor;

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private float rendimento = 0;

        public float Rendimento
        {
            get { return rendimento; }
            set { rendimento = value; }
        }
       

        public static void Resgatar(List<Aplicação> resgatar, float valorresgatado)
        {

        }
    }
}
