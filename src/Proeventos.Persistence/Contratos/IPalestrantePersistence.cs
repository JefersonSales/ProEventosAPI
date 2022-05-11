using System.Threading.Tasks;
using Proeventos.Domain;

namespace Proeventos.Persistence.Contratos
{
  public interface IPalestrantePersistence
  {
    Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
    Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
    Task<Palestrante> GetAllPalestranteByIdAsync(int palestranteId, bool includeEventos);
  }
}