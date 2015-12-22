using System.Collections.Generic;
using System.Data.Entity;
using LojaEF.Entidades;

namespace LojaEF.DAO
{
    class ProdutosDAO
    {
        EntidadesContext contexto;

        private List<Produto> listaProdutos;

        public ProdutosDAO()
        {
            this.contexto = new EntidadesContext();

        }

        //CREATE
        public void Adiciona(Produto p)
        {
            contexto.Database.CreateIfNotExists();
            contexto.Produtos.Add(p);
            contexto.SaveChanges();

        }

        //READ
        public Produto BuscaPorId(int idRecebido)
        {
            return contexto.Produtos.Find(idRecebido);

        }

        public List<Produto> ListaProdutos()
        {
            listaProdutos = new List<Produto>();
            return listaProdutos;
        }

        //UPDATE
        public void Atualiza(Produto produto)
        {
            contexto.Entry(produto).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        //DELETE
        public void RemoveProduto(Produto produtoParaExcluir)
        {
            contexto.Produtos.Remove(produtoParaExcluir);
            contexto.SaveChanges();
        }


    }
}
