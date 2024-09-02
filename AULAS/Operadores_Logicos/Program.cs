using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADOR && AND
            bool c1 = 2 > 3 && 4 != 5;
            Console.WriteLine(c1);

            //OPERADOR || OR
            bool c2 = 2 > 3 || 4 != 5;
            Console.WriteLine(c2);

            //OPERADOR ! NEGAÇÃO
            bool c3 = ! (2 > 3) || 4 != 5;
            Console.WriteLine(c3);
        }
    }
}
