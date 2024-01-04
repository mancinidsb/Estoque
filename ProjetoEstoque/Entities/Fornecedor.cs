using System;

namespace ProjetoEstoque.Entities
{
    internal class Fornecedor
    {
        //Classe Fornecedor
        public string? Nome { get; private set; }
        public string? Cnpj { get; private set; }

        public Fornecedor(string? nome, string? cnpj) 
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
        }
    }
}
