﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificacao_CSharp_Parte3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1000);
            //funcionario.salario = 1000;
            //Console.WriteLine(funcionario.salario);

            //funcionario.salario = -1200;
            //Console.WriteLine(funcionario.salario);

            //funcionario.Salario = -1200;
            //funcionario.Salario = 1200;
            Console.WriteLine(funcionario.Salario);
            //funcionario.Salario = 2000;
        }
    }
    class Funcionario
    {
        public Funcionario(decimal salario)
        {
            if (salario < 0)
             {
                throw new ArgumentOutOfRangeException("Salario não pode ser negativo");
             }
                this.salario = salario;
        }

        decimal salario;

        public decimal Salario //encapsulamento do campo salario
        {
            get
            {
                return salario;
            }
            //set
            //{
            //    if (value < 0)
            //    {
            //        throw new ArgumentOutOfRangeException("Salario não pode ser negativo");
            //    }
            //    salario = value;
            //}
        }

        //private decimal salario;

        //public decimal Salario
        //{
        //    get { return salario; }
        //    set { salario = value; }
        //}

        //public decimal Salario { get; set; }

    }
}



