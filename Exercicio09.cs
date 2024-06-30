using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9) Escreva um algoritmo para ler o salário mensal atual de um funcionário e o percentual de reajuste.
//Calcular e escrever o valor do novo salário.

namespace FaccatCsharp
{
    internal class Exercicio09
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, digite o salário mensal atual: ");
            double salarioAtualFuncionario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Por favor, digite o percentual de reajuste: ");
            double percentualDeReajuste = Convert.ToDouble(Console.ReadLine());

            double novoSalarioFuncionario = salarioAtualFuncionario + (salarioAtualFuncionario * percentualDeReajuste / 100);
            Console.WriteLine($"O novo salário é: {novoSalarioFuncionario:F2}");
        }
    }
}
