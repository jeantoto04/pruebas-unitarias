using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Calculator
    {
        public int resta(int value1, int value2)
        {
            return value1 - value2;
        }

        public int suma(int value11, int value22)
        {
            return value11 + value22;
        }


        public int multiplicacion(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public int division(int valor1, int valor2)
        {
            return valor1 / valor2;
        }

    }
}
