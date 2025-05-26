using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base do retângulo:");
            double baseRetangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do retângulo:");
            double altura = double.Parse(Console.ReadLine());

            double area = baseRetangulo * altura;

            Console.WriteLine("Área do retângulo: " + area);

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }
        }
    }
}
