using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CalculadoraWindowsForm
{
    class Calculadora
    {
        public int suma(int a, int b) {
            return a + b;
        }
        public int restar(int a, int b) {
            return a - b;
        }
        public int multiplicar(int a, int b) {
            return a * b;
        }

        public int divide(int a, int b) {
            if (b==0)
            {
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }
}
