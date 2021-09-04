﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas SkyWalker");
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial.FazerPedido(2, "Comercial");

            clienteEspecial.FazerPedido(3);

            //As instruções a seguir produzem erros de compilação.
            //Um argumento tem que ser fornecido para o primeiro parametro
            //Precisa ser um inteiro
            //clienteEspecial.FazerPedido("Residencial", 1);
            //clienteEspecial.FazerPedido();

            //Você não pode deixar um buraco nos argumentos
            //clienteEspecial.FazerPedido(3, , 4);
            //clienteEspecial.FazerPedido(3, 4);

            //Você pode usar um argumento nomeado para fazer
            //a instrução funcionar.
            clienteEspecial.FazerPedido(3, quantidade: 4);


        }
    }

    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome = "Anônimo")
        {
            this.nome = nome;
        }

        public void FazerPedido(int produtoId, string endereco = "Residencial", int quantidade = 10)
        {
            Console.WriteLine("Cliente {0}: ProdutoId: {1}, endereco: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
        }
    }
}
