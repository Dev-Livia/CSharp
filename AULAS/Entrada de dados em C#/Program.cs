using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_dados_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comando 
            // Console.ReadLine();
            //lê da entrada padrão até a quebra de linha.
            //Retorna os dados lidos na forma de string.

            Console.WriteLine("Olá, qual seu nome?");
            string frase = Console.ReadLine();
            Console.WriteLine($"Olá {frase}");

            //Comando Split 
            //string s = console.ReadLine();
            //string[] vet = s.Split(' ');

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());

        }
    }
}
