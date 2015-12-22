using System;
using LojaEF.Entidades;

namespace LojaEF
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Usuario u = new Usuario() { Nome = "Victor", Senha = "234" };

            //UsuariosDAO dao = new UsuariosDAO();
            //dao.Adiciona(u);
            //dao.RemoveUsuario(dao.BuscaPorId(6));
            //Usuario u2 = dao.BuscaPorId(4);
            //u2.Nome = "Victor Kendy Harada";
            //dao.AtualizaUsuario(u2);

            //Usuario u3 = new Usuario()
            //{
            //    ID = 2,
            //    Nome = "Nome Atualizado",
            //    Senha = "123Mudar"
            //};

            //var contexto = new EntidadesContext();
            //contexto.Entry(u3).State = System.Data.Entity.EntityState.Modified;
            //contexto.SaveChanges();

            //var contexto = new EntidadesContext();
            //contexto.Database.CreateIfNotExists();

            //var p = new Produto() {Nome = "Camisa", Preco = 150.0M};
            //contexto.Produtos.Add(p);
            //contexto.SaveChanges();

            //AULA 3
            //PARTE 1
            //EntidadesContext contexto = new EntidadesContext();

            //Categoria cat = new Categoria() { Nome = "informatica"};
            //Produto produto = new Produto() {Nome = "computador", Categoria = cat, Preco = 1000};

            //contexto.Categorias.Add(cat);
            //contexto.Produtos.Add(produto);
            //contexto.SaveChanges();

            //contexto.Dispose();
            //Console.WriteLine("Sucesso");
            //Console.ReadKey();

            //PARTE 2
            //EntidadesContext contexto = new EntidadesContext();

            //Produto produto = new Produto()
            //{ Nome = "impressora",
            //    Preco = 200,
            //    CategoriaId = 1
            //};

            //contexto.Produtos.Add(produto);
            //contexto.SaveChanges();

            //contexto.Dispose();
            //Console.WriteLine("Sucesso");
            //Console.ReadKey();

            //PARTE 3
            EntidadesContext contexto = new EntidadesContext();

            Categoria categoria = contexto.Categorias.Find(1);
            foreach (var produto in categoria.Produtos)
            {
                Console.WriteLine(produto.Nome);
            }
            
            contexto.Dispose();
            Console.WriteLine("Sucesso");
            Console.ReadKey();
        }
    }
}
