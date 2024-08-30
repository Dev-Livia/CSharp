using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_aritméticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operador + = adição");
            Console.WriteLine("Operador - = subtração");
            Console.WriteLine("Operador * = multiplicação");
            Console.WriteLine("Operador / = divisão");
            Console.WriteLine("Operador % = resto");
            Console.WriteLine("__________________________");

            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1);
        }
    }
}
