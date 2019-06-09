using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ThanosSoft.Infraestrutura.EDMX;
using ThanosSoft.Dados.Usuarios;

namespace ThanosSoft.Negocio.Usuarios
{
    public class UsuarioNegocio : IUsuarioNegocio
    {
        #region ATRIBUTOS E CONSTRUTOR

        private IUsuarioDados usuarioDAO = null;

        /// <summary>
        /// Metodo construtor
        /// </summary>
        /// <param name="usuarioDAO"></param>
        public UsuarioNegocio(IUsuarioDados usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }

        #endregion

        #region USUARIO

        /// <summary>
        /// Metodo responsavel por alterar o usuario
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario AlteraUsuario(Usuario usuario)
        {
            return usuarioDAO.AlteraUsuario(usuario);
        }

        public IList<Usuario> BuscaTodosUsuarios()
        {
            return usuarioDAO.BuscaTodosUsuario();
        }

        /// <summary>
        /// Metodo responsavel por selecionar o Usuário
        /// </summary>
        /// <param name="Usuario"></param>
        /// <returns></returns>
        public Usuario SelecionaUsuarioPorLogin(String Login)
        {
            return usuarioDAO.SelecionaUsuarioPorLogin(Login);
        }

        public bool SelecionaUsuarioLoginSenha(string login, string senha)
        {
            return usuarioDAO.SelecionaUsuarioLoginSenha(login, senha);
        }
        #endregion

    }
}