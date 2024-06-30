using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*10) O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do
distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que o percentual do distribuidor
seja de 28% e os impostos de 45%, escrever um algoritmo para ler o custo de fábrica de um carro,
calcular e escrever o custo final ao consumidor.*/

namespace FaccatCsharp
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o custo de fábrica do carro: ");
            double custoDeFabrica = Convert.ToDouble(Console.ReadLine());

            double percentualDistribuidor = 0.28;
            double percentualImpostos = 0.45;

            double precoFinal = custoDeFabrica + (custoDeFabrica * percentualDistribuidor) + (custoDeFabrica * percentualImpostos);
            Console.WriteLine($"O custo final que o consumidor deve pagar é: {precoFinal:F2}");
        }
    }
}
