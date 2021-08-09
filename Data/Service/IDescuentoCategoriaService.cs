using OnlineBlazorApp.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface IDescuentoCategoriaService
    {
        Task<bool> EliminarDescuento(int id);
        Task<IEnumerable<DescuentoCategoria>> GetAlldescuentos();
        Task<bool> InsertarDescuento(DescuentoCategoria descuento);
    }
}