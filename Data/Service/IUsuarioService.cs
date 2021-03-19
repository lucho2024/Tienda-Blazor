using OnlineBlazorApp.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAllClientes();
        Task<IEnumerable<Usuario>> GetUsuario();
        Task<bool> UsuarioInsert(Usuario usuario);
    }
}