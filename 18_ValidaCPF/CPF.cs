using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _18_ValidaCPF
{
    public class CPF : IDocumento
    {
        public string Numero { get; private set; }

        public CPF(string numero)
        {
            // Remove caracteres não numéricos
            Numero = Regex.Replace(numero ?? "", "[^0-9]", "");
        }

        public bool Validar()
        {
            if (string.IsNullOrWhiteSpace(Numero) || Numero.Length != 11 || Numero.Distinct().Count() == 1)
                return false;

            int digX = CalculaDV(Numero, 9, 10);
            int digY = CalculaDV(Numero, 10, 11);

            return int.Parse(Numero[9].ToString()) == digX &&
                   int.Parse(Numero[10].ToString()) == digY;
        }

        private int CalculaDV(string cpf, int qtdeNumeros, int peso)
        {
            int soma = 0;
            for (int i = 0; i < qtdeNumeros; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (peso - i);
            }

            int resto = soma % 11;
            return (resto < 2) ? 0 : 11 - resto;
        }
    }
}