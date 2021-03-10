using OnlineBlazorApp.Data.Model;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface IProductoService
    {
        Task<bool> ProductoInsert(Producto producto);
    }
}