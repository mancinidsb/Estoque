using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjetoEstoque.Entities
{
    internal class Estoque
    {
        //Classe Estoque
        public List<Produto> Produtos = new List<Produto>();

        public int InserirProduto(Produto prod) 
        {
            if (this.PesquisaProduto(prod.Nome) == null)
            {
                this.Produtos.Add(prod);
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public string MostraProduto(string? nome)
        {
            Produto? prod = this.PesquisaProduto(nome);
            if (prod != null)
            {
                return $"Nome: {prod.Nome} | Quantidade: {prod.Quantidade} | Venda Unitária: {prod.Preco}" +
                    $" | Valor Total Dos Produto: {(prod.Preco*prod.Quantidade).ToString("F2", CultureInfo.InvariantCulture)} " +
                    $"| Fornecedor: {prod.Fornecedor.Nome}";
            }
            else
            {
                return "";
            }
        }
        private Produto? PesquisaProduto(string? nome)
        {
            foreach(Produto prod in this.Produtos)
            {
                if(prod.Nome == nome)
                {
                    return prod;
                }
            }
            return null;
        }
    }
}
