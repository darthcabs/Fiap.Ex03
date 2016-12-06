using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo02.Persistencia.Test
{
    class Calculadora
    {
        public int Fatorial(int numero)
        {
            if (numero < 0)
            {
                throw new Exception("Não existe fatorial de número negativo");
            }
            else
            {
                if (numero == 0)
                {
                    return 1;
                }
                int res = numero * Fatorial(numero - 1);

                return res;
            }
        }
    }
}