using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//18) Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela
//poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

namespace FaccatCsharp
{
    internal class Exercicio18
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o ano atual: ");
            int anoAtual = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ano de nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            int idade = anoAtual - anoNascimento;

            if (idade >= 16)
            {
                Console.WriteLine("Você tem " + idade + " anos e pode votar este ano.");
            }
            else
            {
                Console.WriteLine("Você tem " + idade + " anos e não pode votar este ano.");
            }
        }
}   }
