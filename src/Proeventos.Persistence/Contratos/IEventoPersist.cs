using System.Threading.Tasks;
using Proeventos.Domain;

namespace Proeventos.Persistence.Contratos
{
  public interface IEventoPersist
  {
    Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
    Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
    Task<Evento> GetAllEventoByIdAsync(int eventoId, bool includePalestrantes = false);
  }
}