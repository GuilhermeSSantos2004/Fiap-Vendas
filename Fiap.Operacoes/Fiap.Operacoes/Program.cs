using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome:");
            string nome = Console.ReadLine();

            try
            {
                Console.Write("Digite um numero:");
                double num1 = Convert.ToDouble(Console.ReadLine());


                Console.Write("Digite outro numero:");
                double num2 = double.Parse(Console.ReadLine());


                double soma = num1 + num2;
                double sub = num1 - num2;
                double mult = num2 * num2;
                double modulo = num2 % num2;

                Console.WriteLine("\n Resultados das Operações");
                Console.WriteLine($"Soma: {soma}");
                Console.WriteLine($"Subtração: {sub}");
                Console.WriteLine($"Multiplicação: {mult}");
                Console.WriteLine($"Módulo( Resto da divisão): {modulo}");

                //Operações Relacionais

                Console.WriteLine("\n Comparação entre os números");
                Console.WriteLine($"Os numeros são iguais? {num1 == num2}");
                Console.WriteLine($"Os números são diferentes {num1 != num2}");
                Console.WriteLine($"O primeiro número é maior? {num1 > num2}");
                Console.WriteLine($"O primeiro número é menor? {num1 < num2}");

                Console.WriteLine("\n Verificação Lógica:");

                //Operadores Lógicos
                bool ambosPositivos = num1 > 0 || num2 > 0;
                bool NegativoPositivo = num1 < 0 || num2 < 0;
                bool nenhumNegativo = !(num1 < 0 || num2 < 0);

                Console.WriteLine($"Ambos positivos {ambosPositivos}");
                Console.WriteLine($"Ao menos um negativo {NegativoPositivo}");
                Console.WriteLine($"Nenhum número negativo {NegativoPositivo}");

                Console.WriteLine("\n Pressione qualquer tecla para sair");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
