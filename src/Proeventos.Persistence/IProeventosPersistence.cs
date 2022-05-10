using System.Threading.Tasks;
using Proeventos.Domain;

namespace Proeventos.Persistence
{
  public interface IProeventosPersistence
  {
    //GERAL
    void Add<T>(T entity) where T : class;
    void Update<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    void DeleteRange<T>(T[] entity) where T : class;

    Task<bool> SaveChangesAsync();

    //EVENTOS
    Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
    Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
    Task<Evento[]> GetAllEventoByIdAsync(int EventoId, bool includePalestrantes);

    //PALESTRANTE
    Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string Nome, bool includeEventos);
    Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
    Task<Palestrante[]> GetAllPalestranteByIdAsync(int PalestranteId, bool includeEventos);
  }
}