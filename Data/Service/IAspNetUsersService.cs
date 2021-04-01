using OnlineBlazorApp.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface IAspNetUsersService
    {
        Task<IEnumerable<AspNetUsers>> GetUsuario(string email);
    }
}