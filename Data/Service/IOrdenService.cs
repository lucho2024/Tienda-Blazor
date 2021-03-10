using OnlineBlazorApp.Data.Model;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface IOrdenService
    {
        Task<bool> OrdenInsert(Orden orden);
    }
}