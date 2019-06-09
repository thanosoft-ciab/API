using Microsoft.Practices.Unity;
using ThanosSoft.Negocio.Usuarios;
using ThanosSoft.Dados.Usuarios;
using Unity;
using Unity.Lifetime;
using Unity.Injection;
using ThanosSoft.Infraestrutura.EDMX;

namespace ThanosSoft.WebAPI.DTO
{
    /// <summary>
    /// Classe responsavel por configurar a IoC para a API
    /// </summary>
    public class ConfigureIoC
    {
        UnityContainer container = null;

        /// <summary>
        /// Construtor padrao
        /// </summary>
        public ConfigureIoC()
        {
            container = new UnityContainer();
        }

        /// <summary>
        /// Metodo qu realizas as configuracoes principais
        /// </summary>
        /// <returns></returns>
        public UnityContainer register()
        {
            this.regiterDB();
            this.registerDependencies();

            return container;
        }

        /// <summary>
        /// Metodo que regista a classe que representa o banco
        /// </summary>
        private void regiterDB()
        {
            container.RegisterType<ThanosSoft.Infraestrutura.EDMX.ThanosSoftDBEntities>(new HierarchicalLifetimeManager(),
                                            new InjectionFactory(c =>
                                            {
                                                return new ThanosSoftDBEntities();
                                            })
                                        );
        }

        /// <summary>
        /// Metodo que registra todas as dependencias
        /// </summary>
        private void registerDependencies()
        {
            container.RegisterType<IUsuarioNegocio, UsuarioNegocio>(new HierarchicalLifetimeManager());
            container.RegisterType<IUsuarioDados, UsuarioDados>(new HierarchicalLifetimeManager());
        }
    }
}

