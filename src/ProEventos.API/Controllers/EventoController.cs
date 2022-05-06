﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class EventoController : ControllerBase
  {

    public IEnumerable<Evento> evento = new Evento[]
      {
        new Evento()
        {
          EventoId = 1,
          Tema = "Angular 11 e .NET 5",
          Local = "Ceará",
          Lote = "1º Lote",
          QtdPessoas = 250,
          DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyy"),
          ImageUrl = "Foto1.png",
        },
        new Evento()
        {
          EventoId = 2,
          Tema = "Angular e suas novidades",
          Local = "Ceará",
          Lote = "2º Lote",
          QtdPessoas = 350,
          DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyy"),
          ImageUrl = "Foto2.png",
        },
      };


    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
      return evento;

    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
      return evento.Where(evento => evento.EventoId == id);

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