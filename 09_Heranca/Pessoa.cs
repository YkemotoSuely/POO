using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome;
        public string Telefone;


        public abstract string GetDocumento();

        public void Imprimir()
        {
            Console.WriteLine($"\n\nLISTA DE PESSOAS\n\n" +
                $"Nome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}\n\n");
        }
        public override string ToString() 
        {
            return $"\n<toString()> Nome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}";
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
                return false;

            //Cast -> conversão de objeto
            //((Pessoa)obj)-> coverte obj que é do tipo Objetc para tipo Pessoa
            return this.Id == ((Pessoa)obj).Id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
