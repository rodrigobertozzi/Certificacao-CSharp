using System;
using System.IO;

namespace Listings
{
    class Item_00 //Streams
    {
        static void XMain(string[] args)
        {
            //TAREFAS:
            //1. ABRIR O ARQUIVO Diretores.txt
            //2. LER 10 BYTES DO ARQUIVO
            //3. IMPRIMIR ESSES BYTES NO CONSOLE

            FileStream fluxoDeArquivo
                = new FileStream("Diretores.txt", FileMode.Open, FileAccess.Read);

            byte[] array = new byte[10];
            int posicao = 0;
            int tamanho = 10;

            //Primeira leitura
            fluxoDeArquivo.Read(array, posicao, tamanho);

            foreach (var caractere in array)
            {
                Console.Write((char)caractere);
            }

            // Salto relativo: relativo à posição atual
            //Salto absoluto: relativo à posição inicialdo arquivo

            fluxoDeArquivo.Seek(5, SeekOrigin.Begin);

            fluxoDeArquivo.Position = 5;

            //Segunda leitura
            fluxoDeArquivo.Read(array, posicao, tamanho);

            foreach (var caractere in array)
            {
                Console.Write((char)caractere);
            }


            Console.ReadKey();
        }
    }
}