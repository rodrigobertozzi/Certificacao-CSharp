using System;
using System.Diagnostics;

namespace _01._3.Finalizador
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                Livro livro = new Livro();
            }

            GC.Collect();

            Console.ReadKey();

        }
    }

    class Livro
    {
        public int Ultimoid = 0;
        public string Introducao { get; set; }
        public string Texto { get; set; }
        public string Conclusao { get; set; }
        public int Id { get; }

        public Livro()
        {
            Ultimoid++;
            Id = Ultimoid;
            //Trace.WriteLine("Livro " + Id + "está sendo criadao");

        }

        //~Livro()
        //{
        //    LIBERAR APENAS OS RECURSOS NÃO GERENCIADOS

        //    Trace.WriteLine("Livro " + Id + "está sendo criadao");
        //}
    }

}
