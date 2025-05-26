using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do lado A:");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B:");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C:");
            double C = double.Parse(Console.ReadLine());


            double hipotenusa = A;
            double cateto1 = B;
            double cateto2 = C;

            if (B > hipotenusa)
            {
                hipotenusa = B;
                cateto1 = A;
                cateto2 = C;
            }
            if (C > hipotenusa)
            {
                hipotenusa = C;
                cateto1 = A;
                cateto2 = B;
            }


            bool formaTriangulo =
                (A + B > C) &&
                (A + C > B) &&
                (B + C > A);

            if (!formaTriangulo)
            {
                Console.WriteLine("Não forma um triângulo.");
            }
            else
            {

                double hipQuad = hipotenusa * hipotenusa;
                double catetosQuad = cateto1 * cateto1 + cateto2 * cateto2;

                if (Math.Abs(hipQuad - catetosQuad) < 0.0001)
                {
                    Console.WriteLine("Forma um triângulo retângulo.");
                }
                else
                {
                    Console.WriteLine("Não forma um triângulo retângulo.");
                }
            }
        }
    }
}
