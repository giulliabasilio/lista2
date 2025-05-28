using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota da P1:");
            double p1 = double.Parse(Console.ReadLine());

            double p2Necessaria = (15 - p1) / 2;

            if (p2Necessaria <= 0)
            {
                Console.WriteLine("Você já está aprovado! Não precisa tirar nada na P2.");
            }
            else if (p2Necessaria > 10)
            {
                Console.WriteLine("Infelizmente, não é possível ser aprovado com a nota da P1.");
            }
            else
            {
                Console.WriteLine($"Você precisa tirar pelo menos {p2Necessaria:F2} na P2 para ser aprovado.");
            }
        }
    }
}

