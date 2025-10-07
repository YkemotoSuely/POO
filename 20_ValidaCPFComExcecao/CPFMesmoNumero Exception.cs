using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    public class CPFMesmoNumero_Exception :Exception
    {
        public CPFMesmoNumeroException() : base("Todos os números do  CPF não podem ser iguais!");
    }
}
