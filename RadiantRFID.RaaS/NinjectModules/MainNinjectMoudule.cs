namespace RadiantRFID.RaaS.NinjectModules
{
    using Ninject.Modules;
    using Ninject.Web.Common;

    using RadiantRFID.RaaS.Tools.Common;
    using RadiantRFID.RaaS.Tools.DataAccess;
    using RadiantRFID.RaaS.Tools.Security;

    public class MainNinjectMoudule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAuthService>().To<AuthService>();
            this.Bind<DataBaseContext>().ToMethod(it => new DataBaseContext()).InRequestScope();
            this.Bind<IUserRepository>().To<UserRepository>();
            this.Bind<IContextProvider>().To<ContextProvider>();
            this.Bind<ISession>().To<Session>();
            this.Bind<IRandomToken>().To<RandomToken>();
        }
    }
}