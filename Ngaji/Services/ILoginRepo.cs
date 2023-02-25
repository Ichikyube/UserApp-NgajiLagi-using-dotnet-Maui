using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ngaji.Models.User;

namespace Ngaji.Services
{
    public interface ILoginRepo
    {
        Task<LoginRequest> Login(string userName, string password);
    }
}
