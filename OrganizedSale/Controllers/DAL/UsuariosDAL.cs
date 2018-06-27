using Modelos;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Controllers.DAL
{
    class UsuariosDAL : DbContext
    {
        private Contexto contexto = new Contexto();

        public Usuario Search(string Cpf)
        {
            List<Usuario> Usuarios = new List<Usuario>();
            
            Usuarios = contexto.Usuarios.Where(usu => usu.Cpf == Cpf).ToList();
            if (Usuarios.Count > 0)
            {
                return Usuarios[0];
            }
            else
            {
                return new Usuario();
            }                        
        }

        public int Create(Usuario entity)
        {
            entity.Ativo = true;
            contexto.Usuarios.Add(entity);
            contexto.SaveChanges();

            return entity.UsuarioID;
        }

        public Usuario Find(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public int Edit(Usuario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();

            return entity.UsuarioID;
        }

        public void Delete(Usuario id)
        {
            contexto.Usuarios.Remove(id);
            contexto.SaveChanges();
        }

        public List<Usuario> ListaNomes(string nome)
        {            
            return contexto.Usuarios.Where(usu => usu.Nome == nome).ToList(); ;
        }

        public List<Usuario> ListaTodos()
        {
            return contexto.Usuarios.ToList();
        }

    }
}
