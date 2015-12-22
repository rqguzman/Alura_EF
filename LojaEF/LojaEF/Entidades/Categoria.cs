using System.Collections.Generic;

namespace LojaEF.Entidades
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string Nome { get; set; }

        public virtual IList<Produto> Produtos { get; set; } 
    }
}
