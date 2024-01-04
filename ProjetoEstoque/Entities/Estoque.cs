using System;
using System.Collections.Generic;

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

        public Produto? PesquisaProduto(string? nome)
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
