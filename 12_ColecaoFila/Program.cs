using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<String> filaNomes = new Queue<String>();
            filaNomes.Enqueue("Bruno");
            filaNomes.Enqueue("Beatriz");
            filaNomes.Enqueue("Gustavo");
            filaNomes.Enqueue("Caroline");
            filaNomes.Enqueue("Cecilia");


            Console.WriteLine("Impressão dos filaNomes");
            Console.WriteLine($"1º) {filaNomes.Dequeue()} \n2º) {filaNomes.Dequeue()} \n3º) {filaNomes.Dequeue()}");

            foreach (String nome in filaNomes)
            {
                Console.WriteLine($" - {nome}");

            }
        }
    }
}
