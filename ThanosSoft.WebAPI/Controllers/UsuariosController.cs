using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using AutoMapper;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using ThanosSoft.Negocio.Usuarios;
using System.Web.Http.Results;

namespace ThanosSoft.WebAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        IUsuarioNegocio usuarioNegocio;

        public UsuariosController(IUsuarioNegocio _usuarioNegocio)
        {
            this.usuarioNegocio = _usuarioNegocio;
        }

        [HttpGet]
        [ActionName("buscaUsuarios")]
        public HttpResponseMessage GetTodosUsuarios()
        {
            try
            {
                var listaUsuarios = usuarioNegocio.BuscaTodosUsuarios();

                return Request.CreateResponse(HttpStatusCode.OK, listaUsuarios);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { erro = "Ocorreu um erro ao efetuar sua solicitação. Ex: " + e.ToString() });
            }
        }


        [HttpGet]
        [ActionName("doLogin")]
        public HttpResponseMessage GetDoLogin(string login, string senha)
        {
            try
            {
                bool acessoAutorizado = usuarioNegocio.SelecionaUsuarioLoginSenha(login, senha);

                return Request.CreateResponse(HttpStatusCode.OK, new { acesso = acessoAutorizado });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { erro = "Ocorreu um erro ao efetuar sua solicitação. Ex: " + e.ToString() });
            }
        }

        public class LoginUsuario
        {
            public string login { get; set; }
            public string senha { get; set; }
        }
    }
}
