using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11__ColecaoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> nomes = new List<string>();
            nomes.Add("Bruno");
            nomes.Add("Beatriz");
            nomes.Add("Gustavo");
            nomes.Add("Caroline");
            nomes.Add("Cecilia");


            Console.WriteLine("Impressão de nomes");
            foreach (string nome in nomes)
            {
                Console.WriteLine($"- {nome}");
            }

        }
    }
}
