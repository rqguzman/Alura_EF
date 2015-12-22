namespace LojaEF.Entidades
{
    public class Produto
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int? CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
