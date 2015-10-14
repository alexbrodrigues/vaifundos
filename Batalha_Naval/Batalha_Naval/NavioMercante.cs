using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Naval
{
    class NavioMercante
    {
        private float carga;

        public float Carga
        {
            get { return carga; }
            set { carga = value; }
        }
        private float capacidadeCarga;

        public float CapacidadeCarga
        {
            get { return capacidadeCarga; }
            set { capacidadeCarga = value; }
        }

        public void Carregamento()
        {
            float volumecarga = 0;
            volumecarga = carga / capacidadeCarga;
            Console.WriteLine("O Navio Mercante possui {0} de carga, {1} capacidade de carga e {2} de volume ocupado",carga,capacidadeCarga,volumecarga);
        }
    }
}
