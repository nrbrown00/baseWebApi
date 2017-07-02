using BaseWebApi.Auth.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BaseWebApi.Auth.Interfaces
{
    public interface IAuthRepository
    {
        Task<IdentityResult> RegisterUser(UserModel userModel);
        Task<IdentityUser> FindUser(string userName, string password);
    }
}