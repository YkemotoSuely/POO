using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Aluno
{
    public class Aluno
    {

        private string nome;

        public string Nome
        {
            get { return nome; }
        }

        public int Idade
        {   
            get { return idade; }
            set;

        }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double Media 
        {
           media =  (nota1 + nota2)/2         
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();



        }
    }
}
