using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5) Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o seu antecessor.

namespace FaccatCsharp
{
    internal class Exercicio05
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O número antecessor de {numero} é {numero - 1}");
        }
    }
}
