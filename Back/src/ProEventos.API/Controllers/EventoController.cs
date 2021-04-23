using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Queimados",
                Lote = "Lote 13",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yy"),
                ImagemURL = "foto.png"
                },
                new Evento() {
                EventoId = 2,
                Tema = "Angular 11 E outras coisas mais...",
                Local = "Nilopolis",
                Lote = "Rua do caralho",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yy"),
                ImagemURL = "foto2.png"
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

    
        [HttpPost]
        public string Post()
        {   
            return "Post";
        }

        [HttpPut("{token}")]
        public string Put(string token)
        {   
            return $"meu token é = {token}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {   
            return $"O id deletado é = {id}";
        }


        
    }
}