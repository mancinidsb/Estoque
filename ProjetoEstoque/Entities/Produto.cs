using System;

namespace ProjetoEstoque.Entities
{
    internal class Produto
    {
        //Classe Produto
        public string? Nome { get; private set; }
        public int Quantidade { get; private set; }
        public Fornecedor? Fornecedor { get; private set; }
        public string? Descricao { get; set; }

        public Produto(string? nome, int qtd, Fornecedor? forn)
        {
            this.Nome = nome;
            this.Quantidade = qtd;
            this.Fornecedor = forn;
        }

        public Produto(string? nome, int qtd, Fornecedor? forn, string desc)
        {
            this.Nome = nome;
            this.Quantidade = qtd;
            this.Fornecedor = forn;
            this.Descricao = desc;
        }
    }
}
