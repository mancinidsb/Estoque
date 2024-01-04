using System;
using ProjetoEstoque.Entities;

namespace ProjetoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio Do Programa
            Fornecedor forn = new("Coca-Cola", Auxilia.CriaCnpj());
            Produto prod = new("Crystal", 5, forn, 5.0);
            Estoque estoque = new();

            estoque.InserirProduto(prod);
            Console.WriteLine(estoque.MostraProduto("Crystal"));
        }
    }
}