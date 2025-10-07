using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidaCPFComExcecao
{
    public class CPFQtdeDigitoException : Exception
    {
        public CPFQtdeDigitoException() : base("O CPF deve ter 11 dígitos!");
    }
}
