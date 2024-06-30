using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6) Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a
//área do retângulo.

namespace FaccatCsharp
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, digite a base do retângulo: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Por favor, digite a altura do retângulo: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());
            double area = baseRetangulo * alturaRetangulo;
            Console.WriteLine($"A área do retângulo é: {area}");
        }
    }
}
