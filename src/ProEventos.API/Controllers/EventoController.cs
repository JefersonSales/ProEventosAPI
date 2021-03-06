using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Proeventos.Domain;
using Proeventos.Persistence.Contextos;

namespace ProEventos.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventoController : ControllerBase
  {
    private readonly ProEventosContext context;

    public EventoController(ProEventosContext context)
    {
      this.context = context;

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
      return context.Eventos;

    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
      return context.Eventos.FirstOrDefault(evento => evento.Id == id);
    }

    [HttpPost]
    public string Post()
    {
      return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
      return $"Exemplo de Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
      return $"Exemplo de Delete com id = {id}";
    }
  }
}
