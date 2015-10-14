using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Naval
{
    abstract class NaviodeGuerra: Navio
    {
        private float blindagem;
        private float ataque;

        public abstract void atacar(NaviodeGuerra Triller);
    }
}
