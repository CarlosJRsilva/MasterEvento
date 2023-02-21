using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MasterEventos.API.Models;

namespace MasterEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento(){
            EventoId = 1,
            Tema = "Anguar 11 e .NET 5",
            Local = "Colatina",
            Lote = "1º lote",
            QtdPessoas = 150,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
        },
        new Evento() {
            EventoId = 2,
            Tema = "Anguar 11 e .NET 5",
            Local = "Colatina",
            Lote = "2º lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(4).ToString(),
            ImagemURL = "foto.png"
        }
    };

    public EventoController()
    {
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return _evento; 
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
      return _evento.Where(evento => evento.EventoId == id); 
    }
}
