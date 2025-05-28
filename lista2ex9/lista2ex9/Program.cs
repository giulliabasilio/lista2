using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso (kg):");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura (m):");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo (F para feminino, M para masculino):");
            char sexo = char.ToUpper(Console.ReadLine()[0]);

            double r = peso / (altura * altura);
            Console.WriteLine($"R (peso/altura²): {r:F2}");

            if (sexo == 'F')
            {
                if (r < 19)
                    Console.WriteLine("Abaixo do peso");
                else if (r < 24)
                    Console.WriteLine("Peso ideal");
                else
                    Console.WriteLine("Acima do peso");
            }
            else if (sexo == 'M')
            {
                if (r < 20)
                    Console.WriteLine("Abaixo do peso");
                else if (r < 25)
                    Console.WriteLine("Peso ideal");
                else
                    Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
            }

        }
    }

}
    
