using System;


namespace _01_DeclarcaoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado obj1 = new Quadrado();
            obj1.Lado = 5;
            obj1.ImprimeArea();

            obj1.Lado = 15;
            obj1.ImprimeArea();

            Quadrado obj2 = new Quadrado();
            obj2.Lado = 25;
            obj2.ImprimeArea();

            Retangulo obj3 = new Retangulo();
            obj3.Base = 7;
            obj3.Altura = 8;
            obj3.ImprimeArea();

            Circulo obj4 = new Circulo();
            obj4 = new Circulo();
            obj4.Raio = 7;
            obj4.ImprimeArea();

            Triangulo obj5 = new Triangulo();
            obj5.Base = 7;
            obj5.Altura = 8;
            obj5.ImprimeArea();


            Conta obj6 = new Conta();
            obj6.Banco = 123;
            obj6.Agencia = "011";
            obj6.Numero = "1234-5";
            obj6.Saldo = 500.00;
            obj6.Limite = 500.00;

            obj6.Sacar(220);
            Console.WriteLine($" Saldo atual: {obj6.ConsultaSaldo()}");

            obj6.Depositar(1000.55);
            Console.WriteLine($"Saldo atual: {obj6.ConsultaSaldo()}");

            obj6.ConsultaSaldo();


            Aluno obj7 = new Aluno();
            obj7.Codigo = 22;
            obj7.Nome = "Carol";
            obj7.Notas = [9.6, 8.0, 9.5, 10.0];
            

            obj7.LancarNotas();
            obj7.CalcularMedia();
            obj7.Mencao();

        }
    }

    public class Quadrado
    {
        public int Lado;

        public int CalculaArea()
        {
            int area = Lado * Lado;
            return area;

        }
        public void ImprimeArea()
        {

            Console.WriteLine($"Quadrado com lado de {Lado} possue uma área de {CalculaArea()}");

        }
    }

    public class Retangulo
    {
        public int Base, Altura;
            
       
         public int CalculaAreaRetangulo()
        {
            int ret = Base * Altura;
            return ret;
        }
        public void ImprimeArea()
        {

            Console.WriteLine($"Retangulo com base de {Base} e altura de {Altura}, possue uma área de {CalculaAreaRetangulo()}");
        }
    }
    public class Circulo
    {
        public double Raio;

        public double CalculaArea()
        {
            double area = Math.PI * Raio * Raio;
            return area;
        }

        public void ImprimeArea()
        {
            Console.WriteLine($"Circulo com raio de {Raio}, possui uma área de {CalculaArea():F2}");

        }
  
    } 
    public class Triangulo
    {

        public int Base, Altura;

        public int CalculaArea()
        { 
            int area = (Base * Altura)/2;
            return area;
        }
        public void ImprimeArea()
        {
            Console.WriteLine($"Triangulo com base de {Base} e altura de {Altura}, possue uma área de {CalculaArea()}");
        }
    }
    public class Conta
    {
        public int Banco;
        public string Agencia, Numero;
        public double Saldo, Limite;

        // Método para depositar
        public void Depositar(double valor)
        {
           
                Saldo += valor;
                //Console.WriteLine($"Depósito de R${valor} realizado com sucesso.");
          
        }

        // Método para sacar
        public void Sacar(double valor)
        {
            Saldo = Saldo - valor;
        
        }
        public double ConsultaSaldo()
        { 
             return Saldo;
        }
    }
    public class Aluno
    {
        public int Codigo;
        public string Nome;

        // Arrays para armazenar as notas
        public double[] notas = new double[4];

        // Método para lançar notas nos bimestres
        public void LancarNotas()
        {
            Notas[trimestre - 1] = notas; 
           
        }
        
        // Método para exibir as notas
        public void ExibirNotas()
        {
            Console.WriteLine($"\nNotas do aluno {Nome}:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Bimestre {bimestres[i]}: Nota {notas[i]}");
            }
        }

        // Método para calcular a média
        public double CalcularMedia()
        {
            double media = 0;
            for (int i = 0; i < 4; i++)
            {
                media += notas[i];
            }
            return media / 4;
        }
        public string Mencao()
        {
            if (CalcularMedia() >= 5)
                return "Aprovado";
            else
                return "Reprovado";
        }
    }
}
