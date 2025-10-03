using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Calendario
{
    internal class Feriado : IComparable<Feriado>
    {
        public int Dia { get; set; }
        public string Descricao { get; set; }

        //Construtor, onde vou criar uma instancia nova passando o "dia" e a "descrição"
        public Feriado(int dia, string descricao)
        {
            this.Dia = dia;
            this.Descricao = descricao;
            
        }
        public int CompareTo(Feriado outro)
        {   
            //ordenará os feriados em ordem crescente
            return this.Dia.CompareTo(outro.Dia);

            //Se quiser que a ordenação já seja decrescente direto no CompareTo, basta inverter a comparação:
            //
            /*public int CompareTo(Feriado outro)
             {
               return outro.Dia.CompareTo(this.Dia); // Inverte a ordem
             }*/

    }
}
    

}
