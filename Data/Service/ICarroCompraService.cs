using OnlineBlazorApp.Data.Model;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface ICarroCompraService
    {
        Task<bool> CarroCompraInsert(CarroCompra carrocompra);
    }
}