using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viveiro
{
    abstract class Animal
    {
        private string nome;
        private DateTime dataNascimento;
        private float peso;
        private float capEstomago;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }

        public float Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public float CapEstomago
        {
            get
            {
                return capEstomago;
            }

            set
            {
                capEstomago = value;
            }
        }

        public int Idade(Animal dLaboratorio , DateTime dataatual)
        {

            int Idade = dataatual.Year - dLaboratorio.DataNascimento.Year;
            return Idade;
        }

        public abstract Boolean Comer(float qtd);
    }
}
