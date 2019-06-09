using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ThanosSoft.Infraestrutura.EDMX;

namespace ThanosSoft.Negocio.Usuarios
{
    public interface IUsuarioNegocio
    {
        /// <summary>
        /// Metodo responsavel por buscar todos os usuarios
        /// </summary>
        IList<Usuario> BuscaTodosUsuarios();

        /// <summary>
        /// Metodo responsavel por alterar o usuario
        /// </summary>
        /// <param name="usuario"></param>
        Usuario AlteraUsuario(Usuario usuario);

        /// <summary>
        /// Metodo responsavel por selecionar o Usuário
        /// </summary>
        /// <param name="Usuario"></param>
        /// <returns></returns>
        Usuario SelecionaUsuarioPorLogin(String Login);

        bool SelecionaUsuarioLoginSenha(string login, string senha);

    }
}