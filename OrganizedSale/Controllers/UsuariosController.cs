using System.Collections.Generic;
using System.Linq;
using Controllers.Base;
using Controllers.DAL;
using Modelos;

namespace Controllers
{
    public class UsuariosController :IBaseController<Usuario>
    {   
        private UsuariosDAL usuarioDal = new UsuariosDAL();
        
        public void Adicionar(Usuario entity)
        {
            usuarioDal.Create(entity);            
        }

        public Usuario BuscarPorID(int id)
        {
            return usuarioDal.Find(id);
        }

        public void Editar(Usuario entity)
        {
            usuarioDal.Edit(entity);
        }

        public bool ValidarLogin(string Cpf, string Senha)
        {
            var Usuario = usuarioDal.Search(Cpf);

            if (Usuario.Senha == Senha)
            {
                Session.usuario = Usuario;
                return true;
            }
            else {
                return false;
            }            
            
        }

        public void Excluir(int id)
        {
            Usuario user = usuarioDal.Find(id);

            if (user != null)
            {
                usuarioDal.Delete(user);                
            }
        }

        public IList<Usuario> ListarPorNome(string nome)
        {
            var listaNomes = usuarioDal.ListaNomes(nome);
            return listaNomes;
        }

        public IList<Usuario> ListarTodos()
        {
            var listaTodos = usuarioDal.ListaTodos();
            return listaTodos;
        }
    }
}
