using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14__HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> setNumeros = new HashSet<int>();

            setNumeros.Add(45);
            setNumeros.Add(33);
            setNumeros.Add(17);
            setNumeros.Add(56);
            setNumeros.Add(42);
            setNumeros.Add(45);
            setNumeros.Add(19);
            setNumeros.Add(79);
            setNumeros.Add(93);

            Console.WriteLine("Impressão dos SetNumeros");
            foreach (int numero in setNumeros)
            {
                Console.WriteLine($" - {numero}");
            }



        }
    }
}
