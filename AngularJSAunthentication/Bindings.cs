using AngularJSAunthentication.API.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSAunthentication.API
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthRepository>().To<AuthRepository>();
        }
    }
}