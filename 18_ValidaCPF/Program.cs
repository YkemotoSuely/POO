using System;

namespace _18_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o CPF: ");
            string cpfDigitado = Console.ReadLine();

            IDocumento documento = new CPF(cpfDigitado);

            if (documento.Validar())
                Console.WriteLine("CPF VÁLIDO!");
            else
                Console.WriteLine("CPF INVÁLIDO!");
        }
    }
}


/*//Função de cada arquivo

IDocumento.cs: Define a interface com a propriedade Numero e o método Validar().
CPF.cs: Implementa a interface IDocumento, recebe o CPF, limpa os caracteres e valida os dígitos.
Program.cs: Ponto de entrada do programa, onde o CPF é lido e validado usando a interface.

 POO\
└── 18_ValidaCPF\
    ├── Program.cs         // Onde o usuário digita o CPF e recebe o resultado
    ├── IDocumento.cs      // Interface que define o contrato para documentos
    └── CPF.cs             // Classe que implementa a lógica de validação do CPF*/