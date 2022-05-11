using System.Threading.Tasks;
using Proeventos.Application.Contratos;
using Proeventos.Persistence.Contratos;
using Proeventos.Domain;
using System;

namespace Proeventos.Application
{
  public class EventoService : IEventoServices
  {
    private readonly IGeralPersist _geralPersist;
    private readonly IEventoPersist _eventoPersist;
    public EventoService(IGeralPersist geralPersist, IEventoPersist eventoPersist)
    {
      eventoPersist = eventoPersist;
      geralPersist = geralPersist;

    }
    public async Task<Evento> AddEvento(Evento model)
    {
      try
      {
        _geralPersist.Add<Evento>(model);
        if (await _geralPersist.SaveChangesAsync())
        {
          return await _eventoPersist.GetAllEventoByIdAsync(model.Id, false);
        }
        return null;
      }
      catch (Exception ex)
      {

        throw new Exception(ex.Message);
      }
    }

    public async Task<Evento> UpdateEvento(int eventoId, Evento model)
    {
      try
      {
        var evento = await _eventoPersist.GetAllEventoByIdAsync(eventoId, false);
        if (evento == null) return null;

        model.Id = evento.Id;

        _geralPersist.Update(model);
        if (await _geralPersist.SaveChangesAsync())
        {
          return await _eventoPersist.GetAllEventoByIdAsync(model.Id, false);
        }
        return null;
      }
      catch (Exception ex)
      {

        throw new Exception(ex.Message);
      }
    }

    public async Task<bool> DeleteEvento(int eventoId)
    {
      try
      {
        var evento = await _eventoPersist.GetAllEventoByIdAsync(eventoId, false);
        if (evento == null) throw new Exception("Evento para delete não encontrado");

        _geralPersist.Delete<Evento>(evento);
        return await _geralPersist.SaveChangesAsync();
      }
      catch (Exception ex)
      {

        throw new Exception(ex.Message);
      }
    }
    public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
    {
      try
      {
        var eventos = await _eventoPersist.GetAllEventosAsync(includePalestrantes);
        if (eventos == null) throw new Exception("Não foi possível encontrar os eventos");
        return eventos;
      }
      catch (Exception ex)
      {

        throw new Exception(ex.Message);
      }
    }

    public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
    {
      try
      {
        var eventos = await _eventoPersist.GetAllEventosByTemaAsync(tema, includePalestrantes);
        if (eventos == null) return null;
        return eventos;
      }
      catch (Exception ex)
      {

        throw new Exception(ex.Message);
      }
    }

    public async Task<Evento> GetAllEventoByIdAsync(int eventoId, bool includePalestrantes = false)
    {
         try
      {
        var eventos = await _eventoPersist.GetAllEventoByIdAsync(eventoId, includePalestrantes);
        if (eventos == null) return null;
        return eventos;
      }
      catch (Exception ex)
      {

        throw new Exception(ex.Message);
      }
    }



  }
}