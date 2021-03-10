using OnlineBlazorApp.Data.Model;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface ICategoriaService
    {
        Task<bool> CategoriaInsert(Categoria categoria);
    }
}