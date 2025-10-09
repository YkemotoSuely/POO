using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DivisaoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;

            try
            {
                Console.Write("Digite o primeiro número inteiro: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número inteiro: ");
                num2 = int.Parse(Console.ReadLine());

                int resultado = num1 / num2;
                Console.WriteLine($"\nResultado da divisão: {num1} ÷ {num2} = {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nValor inválido! Digite apenas números inteiros.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nNão é possível dividir por zero!");
            }

            Console.ReadKey();
        }
    }
}