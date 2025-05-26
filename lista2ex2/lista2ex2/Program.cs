using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Os números são idênticos.");
            }
            else
            {
                int maior = (numero1 > numero2) ? numero1 : numero2;
                Console.WriteLine("O maior número é: " + maior);
            }
        }
    }
}
