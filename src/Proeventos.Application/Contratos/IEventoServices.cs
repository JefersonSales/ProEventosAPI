using System.Threading.Tasks;
using Proeventos.Domain;

namespace Proeventos.Application.Contratos
{
    public interface IEventoServices
    {
    Task<Evento> AddEvento(Evento model);

    Task<Evento> UpdateEvento(int eventoId, Evento model);

    Task<bool> DeleteEvento(int eventoId);

    Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);

    Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);

    Task<Evento> GetAllEventoByIdAsync(int eventoId, bool includePalestrantes = false);
  }
}  