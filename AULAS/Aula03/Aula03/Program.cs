using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'f';
            int idade = 12;
            string nome = "Maria";
            double saldo = 10.600;

            Console.WriteLine("Bom dia");
            Console.Write("Boa Tarde!");
            Console.WriteLine("Boa noite !!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString());
        }
    }
}
