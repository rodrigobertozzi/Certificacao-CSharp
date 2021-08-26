﻿using System;
using System.Collections.Generic;

namespace Topico5.Comparacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Aluno aluno2 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1995, 1, 1)
            };

            Aluno aluno3 = new Aluno
            {
                Nome = "josé da silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Aluno aluno4 = new Aluno
            {
                Nome = "ANDRÉ DOS SANTOS",
                DataNascimento = new DateTime(1970, 1, 1)
            };

            Aluno aluno5 = new Aluno
            {
                Nome = "Ana de Souza",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Console.WriteLine(aluno1.Equals(aluno2));
            Console.WriteLine(aluno1.Equals(aluno3));


            List<Aluno> alunos = new List<Aluno>
            {
                aluno1,
                aluno2,
                aluno3,
                aluno4,
                aluno5
            };

            alunos.Sort();

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }


        }
    }

    class Aluno : IComparable
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public override string ToString()
        {
            return $"Nome: {Nome}, Data Nascimento: {DataNascimento:dd/MM/yyyy}";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                return false;
            }
            return this.Nome.Equals(outro.Nome, StringComparison.CurrentCultureIgnoreCase)
                && this.DataNascimento.Equals(outro.DataNascimento);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, DataNascimento);
        }

        public int CompareTo(object obj)
        {
            //retornar 0 => objetos sao iguais
            //retornar > 0 => objeto atual vem depois
            //retornar < 0 => objeto vem antes na ordenação
            if(obj == null)
            {
                return 1;
            }

            Aluno outro = obj as Aluno;
            if(outro == null)
            {
                throw new ArgumentException("Objeto não é um aluno");
            }

            int resultado = this.DataNascimento.CompareTo(outro.DataNascimento);
            if(resultado == 0)
            {
                resultado = this.Nome.CompareTo(outro.Nome);
            }
            return resultado;
        }
    }
}
