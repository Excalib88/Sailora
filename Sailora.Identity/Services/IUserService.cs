using System.Collections.Generic;
using System.Threading.Tasks;
using Sailora.Identity.Entities;
using Sailora.Identity.Models;

namespace Sailora.Identity.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Task<AuthenticateResponse> Register(UserModel userModel);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}