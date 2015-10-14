using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Naval
{
    abstract class NaviodeGuerra: Navio
    {
        protected float blindagem;

        public float Blindagem
        {
            get { return blindagem; }
            set { blindagem = value; }
        }
        protected float ataque;

        public float Ataque
        {
            get { return ataque; }
            set { ataque = value; }
        }

        public NaviodeGuerra(float blind, float Ataque, string Name, int tripulantes) : base (Name, tripulantes)
        {
            blindagem = blind;
            ataque = Ataque;
        }

        public abstract void atacar(NaviodeGuerra Triller);
    }
}
