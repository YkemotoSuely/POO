using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("999-88");
            conta.Nome = "Suely Ykemoto";

            //Não é possível atribuir o valor em um atributo privado
            //conta.numero = "999-88";

            //conta.Saldo = -1000.00m;
            conta.Depositar(-1000.00m);

            //utilizando o métdo acessador
            conta.setSaldo(1000.00m);

            conta.ImprimirSaldo();


            while (true)
            {
                Console.WriteLine("Informe a operação: [D]-Depositar, [S]-Sacar ou [E]-Sair");
                string operacao = Console.ReadLine();

                if (operacao.ToUpper() == "D")
                {
                    Console.WriteLine("Informe o valor para depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "S")
                {
                    Console.WriteLine("Inoforme o valor para saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();
                }
                else if (operacao.ToUpper() == "E")
                {
                    Console.WriteLine($"Conta: {conta.GetType.Numero()} Nome: {conta.Nome} Saldo: {conta.getSaldo()}");
                    break;
                }
                else
                {
                    Console.WriteLine("Informe apenas as letras [D] para Depositar, [S]-Sacar ou [E]-Sair\"");
                }

            }
        }

        public class Conta
        {
            public string Nome { get; private set; }
            private string Numero { get; } // Somente leitura
            private decimal saldo;

            public Conta(string numero)
            {
                this.numero = numero;
            }

            // Construtor define o número da conta e o nome
            public Conta(string nome, string numero)
            {
                Nome = nome;
                Numero = numero;
                saldo = 0;
            }

            public decimal getSaldo()
            {
                return saldo;
            }

            public void Depositar(decimal valor)
            {
                if (valor > 0)
                {
                    saldo += valor;
                }
                else
                    Console.WriteLine("Valor de depósito incorreto, deve ser maior que zero!");
            }

            public void Sacar(decimal valor)
            {
                saldo -= valor;
            }

            public void ImprimirSaldo()
            {
                Console.WriteLine($"Saldo Atual: {saldo:C2}");
            }

            private bool ValidarConta(string numeroInformado)
            {
                return numeroInformado == this.Numero;
            }

            public bool PodeOperar(string numeroInformado)
            {
                return ValidarConta(numeroInformado);
            }
        }
    }
}
