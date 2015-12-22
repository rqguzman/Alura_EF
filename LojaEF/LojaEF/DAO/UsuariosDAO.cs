using System.Collections.Generic;
using System.Data.Entity;
using LojaEF.Entidades;

namespace LojaEF.DAO
{
    public class UsuariosDAO
    {
        
        EntidadesContext contexto;

        private List<Usuario> listaUsuarios; 

        public UsuariosDAO()
        {
            this.contexto = new EntidadesContext();
            
        }

        //CREATE
        public void Adiciona(Usuario usuarioRecebido)
        {
            contexto.Database.CreateIfNotExists();
            contexto.Usuarios.Add(usuarioRecebido);
            contexto.SaveChanges();

        }
        
        //READ
        public Usuario BuscaPorId(int idRecebido)
        {
            return contexto.Usuarios.Find(idRecebido);

        }

        public List<Usuario> ListaUsuarios()
        {
            listaUsuarios = new List<Usuario>();
            return listaUsuarios;
        } 

        //DELETE
        public void RemoveUsuario(Usuario usuarioParaExcluir)
        {
            contexto.Usuarios.Remove(usuarioParaExcluir);
            contexto.SaveChanges();
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            contexto.Entry(usuario).State = EntityState.Modified;
            contexto.SaveChanges();
        }
           

    }
}
