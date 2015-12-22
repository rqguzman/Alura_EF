using System.Collections.Generic;
using System.Data.Entity;
using LojaEF.Entidades;

namespace LojaEF.DAO
{
    public class CategoriasDAO
    {
        EntidadesContext _contexto;

        private IList<Categoria> listaCategorias;

        public CategoriasDAO()
        {
            this._contexto = new EntidadesContext();
        }

        public void AdicionaCategoria(Categoria categoria)
        {
            _contexto.Categorias.Add(categoria);
            _contexto.SaveChanges();
        }

        public Categoria BuscaPorId(int id)
        {
            return _contexto.Categorias.Find(id);
        }

        public IList<Categoria> Listar()
        {
            listaCategorias = new List<Categoria>();
            return listaCategorias;
        }

        public void AtualizaCategoria(Categoria categoria)
        {
            _contexto.Entry(categoria).State = EntityState.Modified;
        }


        public void RemoveCategoria(Categoria categoria)
        {
            _contexto.Categorias.Remove(categoria);
            _contexto.SaveChanges();
        }
    }
}
