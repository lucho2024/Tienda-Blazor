using OnlineBlazorApp.Data.Model;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface IUsuarioService
    {
        Task<bool> UsuarioDelete(Usuario usuario);
        Task<bool> UsuarioInsert(Usuario usuario);
        Task<bool> UsuarioRead(Usuario usuario);
        Task<bool> UsuarioUpdate(Usuario usuario);
    }
}