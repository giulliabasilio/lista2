using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o lado 1:");
            double lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado 2:");
            double lado2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado 3:");
            double lado3 = double.Parse(Console.ReadLine());

            
            bool existeTriangulo =
                (lado1 + lado2 > lado3) &&
                (lado1 + lado3 > lado2) &&
                (lado2 + lado3 > lado1);

            if (!existeTriangulo)
            {
                Console.WriteLine("Não forma um triângulo.");
            }
            else
            {
               
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
        }
    }
}
