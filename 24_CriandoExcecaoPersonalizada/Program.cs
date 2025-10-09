using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _24_CriandoExcecaoPersonalizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota do aluno (0 a 10): ");
            string entrada = Console.ReadLine();

            try
            {
                double nota = double.Parse(entrada);

                if (nota < 0 || nota > 10)
                {
                    throw new NotaInvalidaException("Erro: valor de nota inválido! A nota deve estar entre 0 e 10.");
                }

                if (nota >= 6)
                {
                    Console.WriteLine("Aluno aprovado!");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
            }
            catch (NotaInvalidaException ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nErro: entrada inválida! Digite um número válido.");
            }

            Console.ReadKey();
        }
    }
}

    

