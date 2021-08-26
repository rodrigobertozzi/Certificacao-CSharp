using System;
namespace ModificadorVisibilidade
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Banco
    {
        public Banco()
        {
            Conta conta = new Conta();
            conta.Saldo = 1000;
            Console.WriteLine(conta.Saldo);
        }
    }

    public class Conta
    {
        public Conta()
        {
            this.Saldo = 1000;
            Console.WriteLine(this.Saldo);
        }

        void Sacar(decimal saque)
        {
            Saldo = Saldo - saque;
        }

        public decimal Saldo { get; set; }
    }

    public class ContaCorrente: Conta
    {
        public ContaCorrente()
        {
            this.Saldo = 1000;
            Console.WriteLine(this.Saldo);
        }
    }
}
