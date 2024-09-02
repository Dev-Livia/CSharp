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

            bool c1 = 2 > 3 && 4 != 5;
            Console.WriteLine(c1);

            bool c2 = 2 > 3 || 4 != 5;
            Console.WriteLine(c2);

        }
    }
}
