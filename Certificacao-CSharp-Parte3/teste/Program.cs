﻿using System;
using static ModificadorVisibilidade.Program;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Saldo = 1000;
            Console.WriteLine(conta.Saldo);
        }
    }
}
