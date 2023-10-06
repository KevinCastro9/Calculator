using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Structs
{
    struct Operacoes
    {
        public Operacoes(float primeiroValor, float segundoValor)
        {
            PrimeiroValor = primeiroValor;
            SegundoValor = segundoValor;
        }

        public float PrimeiroValor;
        public float SegundoValor;

        public float Soma()
        {
            float resultado = PrimeiroValor + SegundoValor;
            return resultado;
        }
        public float Subtracao()
        {
            float resultado = PrimeiroValor - SegundoValor;
            return resultado;
        }
        public float Divisao()
        {
            float resultado = PrimeiroValor / SegundoValor;
            return resultado;
        }
        public float Multiplicacao()
        {
            float resultado = PrimeiroValor * SegundoValor;
            return resultado;
        }
    }
}
