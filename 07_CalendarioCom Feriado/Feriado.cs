using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CalendarioCom_Feriado
{
    internal class Feriado
    {
        public int Dia { get; set; }
        public string Descricao { get; set; }

        //Construtor, onde vou criar uma instancia nova passando o "dia" e a "descrição"
        public Feriado(int dia, string descricao)
        {
            this.Dia = dia;
            this.Descricao = descricao;
            
        }
    }
}
