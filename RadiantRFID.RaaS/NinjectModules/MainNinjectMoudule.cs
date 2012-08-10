﻿namespace RadiantRFID.RaaS.NinjectModules
{
    using Ninject.Modules;
    using Ninject.Web.Common;

    using RadiantRFID.RaaS.Tools.DataAccess;
    using RadiantRFID.RaaS.Tools.Security;

    public class MainNinjectMoudule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DataBaseContext>().ToMethod(it => new DataBaseContext()).InRequestScope();
            this.Bind<IUserRepository>().To<UserRepository>();
            this.Bind<IAuthService>().To<AuthService>();
        }
    }
}