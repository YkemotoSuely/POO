using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ConversaoNumeroComExcecao
{
    internal class Program
    {

        public static string NumeroDigitado { get; set; }
        static void Main(string[] args)
        {
           

            Console.Write("Digite um número inteiro: ");
            
            NumeroDigitado = Console.ReadLine();

            try 
            {

                int numero = int.Parse(NumeroDigitado);
                int dobro = numero * 2;
                Console.WriteLine($"O dobro de {numero} é {dobro}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
            }

            Console.ReadKey();
        }

        /*/ trecho de código construído pelo chat, onde um while (!entradaValida) para repetir até que o usuário digite corretamente.
        A variável entradaValida controla se a entrada foi convertida com sucesso.
        A mensagem de erro aparece toda vez que o usuário digita algo inválido.**//*/
                                                                                   
                                                                                
        /* public static string NumeroDigitado { get; set; }

         static void Main(string[] args)
         {
             bool entradaValida = false;

             while (!entradaValida)
             {
                 Console.Write("Digite um número inteiro: ");
                 NumeroDigitado = Console.ReadLine();

                 try
                 {
                     int numero = int.Parse(NumeroDigitado);
                     int dobro = numero * 2;
                     Console.WriteLine($"O dobro de {numero} é {dobro}.");
                     entradaValida = true; // Sai do loop
                 }
                 catch (FormatException)
                 {
                     Console.WriteLine("Valor inválido! Digite apenas números inteiros.\n");
                 }
             }

             Console.WriteLine("\nPressione qualquer tecla para sair...");
             Cons*//*ole.ReadKey();
         }*/
        
    }
}









