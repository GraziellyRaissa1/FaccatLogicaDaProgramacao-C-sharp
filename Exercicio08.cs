using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8) Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos brancos,
//nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total de eleitores

namespace FaccatCsharp
{
    internal class Exercicio08
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, digite o número total de eleitores: ");
            int totalDeEleitores = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por favor, digite o número de votos brancos: ");
            int votosEmBrancos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por favor, digite o número de votos nulos: ");
            int votosNulos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por favor, digite o número de votos válidos: ");
            int votosValidos = Convert.ToInt32(Console.ReadLine());

            double percentualVotosEmBrancos = (double)votosEmBrancos / totalDeEleitores * 100;
            double percentualVotosNulos = (double)votosNulos / totalDeEleitores * 100;
            double percentualVotosValidos = (double)votosValidos / totalDeEleitores * 100;

            Console.WriteLine($"Percentual de votos brancos: {percentualVotosEmBrancos:F2}%");
            Console.WriteLine($"Percentual de votos nulos: {percentualVotosNulos:F2}%");
            Console.WriteLine($"Percentual de votos válidos: {percentualVotosValidos:F2}%");
        }
    }
}
