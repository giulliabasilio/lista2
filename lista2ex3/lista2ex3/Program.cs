using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2ex3
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int num3 = int.Parse(Console.ReadLine());

           
            int maior = num1;

            if (num2 > maior)
                maior = num2;

            if (num3 > maior)
                maior = num3;

            
            Console.WriteLine("\nMaior valor(es):");

            if (num1 == maior)
                Console.WriteLine("Primeiro número: " + num1);

            if (num2 == maior)
                Console.WriteLine("Segundo número: " + num2);

            if (num3 == maior)
                Console.WriteLine("Terceiro número: " + num3);

        }
    }
}
