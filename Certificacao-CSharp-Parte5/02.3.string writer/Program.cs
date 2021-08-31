using System;
using System.IO;
using System.Text;

namespace _02._3.string_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA
            //======
            //Ler sequencialmente alista de ingredientes 
            //linha a linha
            //cada linha deve começar com "°" e um espaço

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string ingredientes = GetIngredientes();

            using (StringWriter stringWriter = new StringWriter())
            {

                using (StringReader stringReader = new StringReader(ingredientes))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        stringWriter.WriteLine("° " + line);

                    }
                }
                Console.WriteLine(stringWriter);
            }
        }
        private static string GetIngredientes()
        {
            return
                @"3 cenouras médias raspadas e picadas
3 ovos
1 xicara de óleo
2 xicaras de açucar
2 xicaras de farinha de trigo
1 colher(sopa)";

        }
    }
}