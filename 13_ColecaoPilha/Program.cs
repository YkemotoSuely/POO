using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ColecaoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stackNumeros = new Stack<string>();
            stackNumeros.Push("79");
            stackNumeros.Push("80");
            stackNumeros.Push("81");
            stackNumeros.Push("82");
            stackNumeros.Push("83");

            Console.WriteLine("Impressão dos stackNumeros");
            Console.WriteLine($" O último número de senha gerado foi:  {stackNumeros.Pop()}");

            foreach (String numero in stackNumeros)
            {

                Console.WriteLine($" - {numero}");
            }
        }
    }
}
