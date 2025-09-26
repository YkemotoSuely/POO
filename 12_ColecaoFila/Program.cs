//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _12_ColecaoFila
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Queue<String> filaNomes = new Queue<String>();
//            filaNomes.Enqueue("Bruno");
//            filaNomes.Enqueue("Beatriz");
//            filaNomes.Enqueue("Gustavo");
//            filaNomes.Enqueue("Caroline");
//            filaNomes.Enqueue("Cecilia");


//            Console.WriteLine("Impressão dos filaNomes");
//            Console.WriteLine($"1º) {filaNomes.Dequeue()} \n2º) {filaNomes.Dequeue()} \n3º) {filaNomes.Dequeue()}");

//            foreach (String nome in filaNomes)
//            {
//                Console.WriteLine($" - {nome}");

//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;

namespace _12_ColecaoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaNomes = new Queue<string>();

            Console.WriteLine("Digite os nomes para a fila de atendimento (digite 'fim' para encerrar):");

            while (true)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                if (nome.ToLower() == "fim")
                    break;

                if (nome.Length >= 3)
                {
                    filaNomes.Enqueue(nome);
                }
                else
                {
                    Console.WriteLine("❌ O nome deve ter pelo menos 3 caracteres. Tente novamente.");
                }
            }

            Console.WriteLine("\n Atendimento:");
            for (int i = 1; i <= 3 && filaNomes.Count > 0; i++)
            {
                Console.WriteLine($"\n {i}º atendido: {filaNomes.Dequeue()}");
            }

            Console.WriteLine("\nAinda aguardando na fila:");
            if (filaNomes.Count == 0)
            {
                Console.WriteLine("Nenhum nome na fila.");
            }
            else
            {
                foreach (string nome in filaNomes)
                {
                    Console.WriteLine($" - {nome}");
                }
            }

            Console.ReadLine(); // Para manter o console aberto
        }
    }
}