using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7) Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
//Considerar ano com 365 dias e mês com 30 dias.

namespace FaccatCsharp
{
    internal class Exercicio07
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, digite a idade em anos: ");
            int anos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Por favor, digite a idade em meses: ");
            int meses = Convert.ToInt32(Console.ReadLine());    
            Console.Write("Por favor, digite a idade em dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            int totalDeDias = anos * 365 + meses * 30 + dias;
            Console.WriteLine($"A idade em dias é: {totalDeDias}");
        }
    }
}
