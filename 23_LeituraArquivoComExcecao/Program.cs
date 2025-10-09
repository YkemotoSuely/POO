using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _23_LeituraArquivoComExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho completo do arquivo que está buscando (diretório/pasta/nome do arquivo): ");
            string caminho = Console.ReadLine();


            try
            {
                string conteudo = File.ReadAllText(caminho);
                Console.WriteLine("\nConteúdo do arquivo:");
                Console.WriteLine(conteudo);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("\nArquivo não encontrado! Verifique o caminho e tente novamente.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"\n O acesso ao caminho {caminho} foi negado");

            }
        }
    }
}
