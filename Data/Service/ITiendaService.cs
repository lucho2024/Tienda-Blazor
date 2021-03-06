using OnlineBlazorApp.Data.Model;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface ITiendaService
    {
        Task<bool> TiendaInsert(Tienda tienda);
    }
}