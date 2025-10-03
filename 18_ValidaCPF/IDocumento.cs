using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace _18_ValidaCPF
{
    public interface IDocumento
    {
        string Numero { get; }
        bool Validar();
    }
}

/*🔹 namespace _18_ValidaCPF

Um namespace é como uma "caixa" que agrupa classes relacionadas.
Aqui, todas as classes do seu projeto estão dentro do namespace _18_ValidaCPF, o que ajuda a organizar e evitar conflitos de nomes.


🔹 public interface IDocumento

Uma interface define um contrato que as classes devem seguir.
public significa que essa interface pode ser acessada por outras classes fora do arquivo.
IDocumento é o nome da interface. Por convenção, interfaces começam com a letra I.


🔹 string Numero { get; }

Define uma propriedade somente leitura chamada Numero, do tipo string.
Qualquer classe que implemente essa interface deve ter essa propriedade.


🔹 bool Validar();

Define um método chamado Validar que retorna um valor booleano(true ou false).
Qualquer classe que implemente essa interface deve implementar esse método.


🧩 Resumo
A interface IDocumento está dizendo:

"Toda classe que me implementar precisa ter uma propriedade chamada Numero (somente leitura) e um método chamado Validar() que retorna true ou false."*/