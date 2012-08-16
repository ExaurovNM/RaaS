using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RadiantRFID.RaaS.Ninject
{
    using RadiantRFID.RaaS.DomainModel.Security;

    using global::Ninject.Modules;

    public class MainNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAuthService>().To<AuthService>();
        }
    }
}