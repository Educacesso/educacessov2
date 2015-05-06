[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Educacesso.infra.CrossCutting.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Educacesso.infra.CrossCutting.App_Start.NinjectWebCommon), "Stop")]

namespace Educacesso.infra.CrossCutting.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using EducacessoV2.Application.Interfaces;
    using EducacessoV2.Application.App;
    using Educacesso.Domain.Interfaces.Services;
    using Educacesso.Domain.Services;
    using Educacesso.Domain.Interfaces.Repositories;
    using Educacesso.Infra.Repositories.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IUserAppService>().To<UserAppService>();
            kernel.Bind<ICursoAppService>().To<CursoAppService>();
            kernel.Bind<ILicaoAppService>().To<LicaoAppService>();
            kernel.Bind<IExercicioAppService>().To<ExercicioAppService>();
            kernel.Bind<IAmigoAppService>().To<AmigoAppService>();
            kernel.Bind<IAmigoUsuarioAppService>().To<AmigoUsuarioAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<ICursoService>().To<CursoService>();
            kernel.Bind<ILicaoService>().To<LicaoService>();
            kernel.Bind<IAmigoService>().To<AmigoService>();
            kernel.Bind<IAmigoUsuarioService>().To<AmigoUsuarioService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<ICursoRepository>().To<CursoRepository>();
            kernel.Bind<ILicaoRepository>().To<LicaoRepository>();
            kernel.Bind<IExercicioRepository>().To<ExercicioRepository>();
            kernel.Bind<IAmigoRepository>().To<AmigoRepository>();
            kernel.Bind<IAmigoUsuarioRepository>().To<AmigoUsuarioRepository>();

        }        
    }
}
