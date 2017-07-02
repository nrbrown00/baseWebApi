﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseWebApi.Auth.DbContext
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            :base("AuthContext")
        {

        }
    }
}