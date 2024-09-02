using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_implícita_e_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            float b;
            // Aqui estamos assumindo o risco de que talvez perderemos dados ao usar esta formula, pois um tem menos bytes que o outro.
            a = 5.1;
            b = (float)a;



            
        }
    }
}
