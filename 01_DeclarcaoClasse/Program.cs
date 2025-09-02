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


        
    

}
