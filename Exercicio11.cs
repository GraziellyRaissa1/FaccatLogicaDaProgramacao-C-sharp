using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

/*11) Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês,
mais uma comissão também fixa para cada carro vendido e mais 5% do valor das vendas por ele
efetuadas. Escrever um algoritmo que leia o número de carros por ele vendidos, o valor total de suas
vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e escreva o salário final do funcionário*/


namespace FaccatCsharp
{
    internal class Exercicio11
    {
        public static void Main(string[] args)
        {
            Console.Write("Por favor, informe o número de carros vendidos: ");
            int NumerosDecarrosVendidos = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Por favor, digite o valor total das vendas: ");
            double valorTotalDasVendas = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Por favor, digite o salário fixo do vendedor: ");
            double salarioFixo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Por favor, digite o valor que ele recebe por carro vendido: ");
            double valorPorCarroVendido = Convert.ToDouble(Console.ReadLine());

            double comissaoPorCarroVendido = NumerosDecarrosVendidos * valorPorCarroVendido;
            double comissaoSobreAsVendas = valorTotalDasVendas * 0.05;
            double salarioFinalComComissao = salarioFixo + comissaoPorCarroVendido + comissaoSobreAsVendas;

            Console.WriteLine($"O salário final do vendedor é: {salarioFinalComComissao:F2}");
        }
    }
}
