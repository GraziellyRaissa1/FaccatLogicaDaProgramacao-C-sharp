using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*12) Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor
correspondente em graus Celsius (baseado na fórmula abaixo):
 C F - 32
 ---------- = -----------
 5 9 */


namespace FaccatCsharp
{
    internal class Exercicio12
    {
       
    
        public static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Celsius é: " + celsius);
        }
    }

}

