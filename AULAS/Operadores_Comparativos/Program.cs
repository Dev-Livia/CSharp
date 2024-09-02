using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Comparativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            bool c5 = a < 10;
            bool c6 = a <= 20;
            bool c7 = a >= 20;

            Console.WriteLine(c7);  
            Console.WriteLine(c6);  
            Console.WriteLine(c5);  
        }
    }
}
