using System.Data.Entity;
using LojaEF.Entidades;

namespace LojaEF
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Produto> Produtos { get; set;}

        public DbSet<Categoria> Categorias { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var configuracaoCategoria = modelBuilder.Entity<Categoria>();
            configuracaoCategoria.HasMany(categoria => categoria.Produtos)
                                 .WithOptional(produto => produto.Categoria);

            var usuarioBuilder = modelBuilder.Entity<Usuario>();
            usuarioBuilder.ToTable("tbl_Usuarios");
            usuarioBuilder.Property(usuario => usuario.Nome)
                          .HasColumnName("col_nome");

            usuarioBuilder.Property(usuario => usuario.Senha)
                          .HasColumnName("col_senha");
        }
    }
}
