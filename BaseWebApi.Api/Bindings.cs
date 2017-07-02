using BaseWebApi.Auth.Interfaces;
using BaseWebApi.Auth.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseWebApi.API
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthRepository>().To<AuthRepository>();
        }
    }
}