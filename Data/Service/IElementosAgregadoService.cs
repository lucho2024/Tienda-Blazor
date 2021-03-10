using OnlineBlazorApp.Data.Model;
using System.Threading.Tasks;

namespace OnlineBlazorApp.Data.Service
{
    public interface IElementosAgregadoService
    {
        Task<bool> ElementosAgregadoInsert(ElementosAgregado elementoagregado);
    }
}