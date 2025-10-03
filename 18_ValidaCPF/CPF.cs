using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using _18_ValidaCPF;
using Microsoft.SqlServer.Server;

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
/*📄 Arquivo: CPF.cs
C#using System;using System.Linq;using System.Text.RegularExpressions;Mostrar mais linhas
Essas são bibliotecas que o código usa:

System: funções básicas como Console, String, etc.
System.Linq: permite usar métodos como Distinct() para trabalhar com coleções.
System.Text.RegularExpressions: permite usar expressões regulares para limpar o CPF.


🧩 Classe CPF implementando IDocumento
C#namespace _18_ValidaCPF{    public class CPF : IDocumentoMostrar mais linhas

A classe CPF está dentro do mesmo namespace do projeto.
Ela implementa a interface IDocumento, ou seja, é obrigada a ter a propriedade Numero e o método Validar().


🔐 Propriedade Numero
C#public string Numero { get; private set; }Mostrar mais linhas

Numero guarda o CPF já limpo(sem pontos ou traços).
É pública para leitura(get) e privada para escrita(private set), ou seja, só pode ser alterada dentro da própria classe.


🏗️ Construtor da classe
C#public CPF(string numero){    Numero = Regex.Replace(numero ?? "", "[^0-9]", "");}Mostrar mais linhas

Recebe o CPF digitado pelo usuário.
Usa expressão regular para remover tudo que não for número.
numero ?? "" garante que, se numero for null, ele será tratado como uma string vazia (evita erro).


✅ Método Validar()
C#public bool Validar(){    if (string.IsNullOrWhiteSpace(Numero) || Numero.Length != 11 || Numero.Distinct().Count() == 1)        return false;Mostrar mais linhas

Verifica se o CPF está vazio, tem menos de 11 dígitos ou todos os dígitos são iguais (ex: 11111111111), o que é inválido.


🔢 Cálculo dos dígitos verificadores
C#int digX = CalculaDV(Numero, 9, 10);int digY = CalculaDV(Numero, 10, 11);Mostrar mais linhas

Calcula os dois dígitos verificadores do CPF usando o método CalculaDV.


🔍 Comparação dos dígitos
C#return int.Parse(Numero[9].ToString()) == digX &&       int.Parse(Numero[10].ToString()) == digY;Mostrar mais linhas

Compara os dois últimos dígitos do CPF com os que foram calculados.
Se forem iguais, o CPF é válido.


🧮 Método auxiliar CalculaDV
C#private int CalculaDV(string cpf, int qtdeNumeros, int peso){    int soma = 0;    for (int i = 0; i < qtdeNumeros; i++)    {        soma += int.Parse(cpf[i].ToString()) * (peso - i);    }    int resto = soma % 11;    return (resto < 2) ? 0 : 11 - resto;}Mostrar mais linhas

Calcula o dígito verificador com base nos primeiros números do CPF.
Usa a fórmula oficial da Receita Federal.
Se o resto da divisão por 11 for menor que 2, o dígito é 0. Senão, é 11 - resto.


✅ Resumo
Esse código transforma o CPF digitado em números puros, verifica se ele tem 11 dígitos e se não são todos iguais, calcula os dois dígitos verificadores e compara com os originais. Se tudo estiver certo, retorna true (CPF válido).*/