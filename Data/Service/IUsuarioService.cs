using OnlineBlazorApp.Data.Model;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface IUsuarioService
    {
        Task<bool> UsuarioInsert(Usuario usuario);
    }
}