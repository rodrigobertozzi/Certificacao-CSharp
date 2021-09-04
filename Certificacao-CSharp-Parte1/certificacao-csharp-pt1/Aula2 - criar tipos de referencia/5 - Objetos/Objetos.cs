using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuação: {pontuacao}");

            Console.WriteLine("Object com valor primitivo");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"meuobjeto: {meuObjeto}");
            Console.WriteLine($"meuObjeto.GetType(): {meuObjeto.GetType()}");

            Console.WriteLine();
            Console.WriteLine("OBJECT COM REFERENCIA DE OBJETO");

            meuObjeto = new Jogador();
            Jogador classRef;
            classRef = (Jogador)meuObjeto; // conversao explicita ou cast

            Console.WriteLine($"classref.Pontuacao: {classRef.Pontuacao}");
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
