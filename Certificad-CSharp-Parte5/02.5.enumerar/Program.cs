using System;

namespace _02._5.enumerar
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA
            //======
            //Imprimir odocumento no console, destacando as letras maiusculas no texto
            string documento = GetDocumento();
            Console.WriteLine(documento);

            //Char c = documento[0];
            //Console.WriteLine(c);

            foreach (var c in documento)
            {
                if (char.IsUpper(c))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else
                {
                    Console.ResetColor();
                }
                Console.Write(c);
            }

            Console.ReadKey();
        }

        private static string GetDocumento()
        {
            return "Uma cadeia de caracteres é uma coleção sequencial de caracteres que é usada para representar um texto. Um objeto string é uma coleçao sequencial de objetos System.Char que representam uma cadeia de caracteres; um System.Char objeto corresponde a umaunidade de código UTF-16. O valor de objeto String é o conteudo da coleçao sequencial de objetos Char cujo o valor é imutavel. ou seja, ele é somente leitura.";
        }
    }
}
