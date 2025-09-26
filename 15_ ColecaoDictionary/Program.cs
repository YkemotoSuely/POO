using System;
using System.Collections.Generic;

namespace _15__ColecaoDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando alunos
            Aluno bruno = new Aluno { ra = 1, Nome = "Bruno" };
            Aluno beatriz = new Aluno { ra = 2, Nome = "Beatriz" };
            Aluno gustavo = new Aluno { ra = 3, Nome = "Gustavo" };
            Aluno caroline = new Aluno { ra = 4, Nome = "Caroline" };
            Aluno cecilia = new Aluno { ra = 5, Nome = "Cecilia" };

            // Criando o Dictionary com objetos Aluno
            Dictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();
            dicAlunos.Add(bruno.ra, bruno);
            dicAlunos.Add(beatriz.ra, beatriz);
            dicAlunos.Add(gustavo.ra, gustavo);
            dicAlunos.Add(caroline.ra, caroline);
            dicAlunos.Add(cecilia.ra, cecilia);

            Console.WriteLine("Impressão dos alunos:");

           
            foreach (Aluno aluno in dicAlunos.Values)
            {
                aluno.ImprimirAluno();
            }

            Console.ReadLine(); 
        }
    }

    class Aluno
    {
        public int ra { get; set; }
        public string Nome { get; set; }
        public double[] Notas { get; set; }

        public virtual void ImprimirAluno()
        {
            Console.WriteLine($" - RA: {this.ra} Nome: {this.Nome}");
        }
    }
}