using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso da pessoa (em kg):");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da pessoa (em metros):");
            double altura = double.Parse(Console.ReadLine());

            double r = peso / (altura * altura);

            Console.WriteLine("R (peso / altura²): " + r.ToString("F2")); 

            if (r < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (r < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }

        }
    }
}
