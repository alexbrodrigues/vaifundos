﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Naval
{
    class PortaAvioes: NaviodeGuerra
    {
        private int qtdAvioes;

        public int QtdAvioes
        {
            get { return qtdAvioes; }
            set { qtdAvioes = value; }
        }

        public PortaAvioes(int avioes, string Name, int tripulantes, float shield, float attack): base (shield, attack, Name, tripulantes)
        {
            qtdAvioes = avioes;
        }

        public override void atacar(NaviodeGuerra War_ship)
        {
            if (War_ship.Blindagem > 0)
            {
                float atacar = ((ataque * qtdAvioes) / 2);
                if (this.Estado.Equals(EstadoNavio.MuitoDanificado))
                {
                    War_ship.Blindagem = War_ship.Blindagem - (atacar * 20) / 100;
                }
                else
                {
                    if (this.Estado.Equals(EstadoNavio.Danificado))
                    {
                        War_ship.Blindagem = War_ship.Blindagem - (atacar * 40) / 100;
                    }
                    else
                    {
                        if (this.Estado.Equals(EstadoNavio.Perfeito))
                        {
                            War_ship.Blindagem = War_ship.Blindagem - atacar;
                        }
                        else
                        {
                            if (this.Estado.Equals(EstadoNavio.Inoperante))
                            {
                                Console.WriteLine("Não é possivel atacar Navio se encontra inoperante!");
                                War_ship.Blindagem = 0;
                            }
                        }
                    }
                }
            }
            else
            {
                if (War_ship.Equals(EstadoNavio.Perfeito))
                {
                    War_ship.Estado = EstadoNavio.Danificado;
                }
                else
                {
                    if (War_ship.Equals(EstadoNavio.Danificado))
                    {
                        War_ship.Estado = EstadoNavio.MuitoDanificado;
                    }
                    else
                    {
                        if (War_ship.Equals(EstadoNavio.MuitoDanificado))
                        {
                            War_ship.Estado = EstadoNavio.Inoperante;
                        }
                    }
                }
            }
        }
    }
}
