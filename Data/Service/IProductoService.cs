using OnlineBlazorApp.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface IProductoService
    {
        Task<bool> deleteIdproducto(int id);
        Task<IEnumerable<Producto>> GetAllProductos();
        Task<IEnumerable<Producto>> GetProductoByCategory(string pk_categoria);
        Task<Producto> GetProductoById(string idproducto);
        Task<bool> ProductoInsert(Producto producto);
        Task<bool> ProductoUpdate(Producto producto);
    }
}