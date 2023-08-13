using Microsoft.AspNetCore.Mvc;
using Project.API.Models;

namespace Project.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventController : ControllerBase
{
   public IEnumerable<Event> _events = new Event[]{
      new Event(){
               EventId =1,
               Theme="Angular com .Ney",
               Local="Lauro de Freitas",
               batch="lote 1",
               QtdPeople = 100,
               EventDate= DateTime.Now.AddDays(1).ToString(),
               ImageURL = "photo.png"
               },
                  new Event(){
               EventId =2,
               Theme="Angular com .Ney 2",
               Local="Salvador",
               batch="lote 2",
               QtdPeople = 1000,
               EventDate= DateTime.Now.AddDays(10).ToString(),
               ImageURL = "photo.png"
               }
       };
    public EventController()
    {
        
    }

    [HttpGet]
    public IEnumerable<Event> Get()
    {
         return _events;
         
    }

    [HttpGet("{id}")]
    public IEnumerable<Event> Get(int id)
    {
         return _events.Where(e => e.EventId == id);
         
    }


    [HttpPost("{id}")]
    public string Post()
    {
       return $"Exempplo post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
       return $"Exempplo put com id={id}";
    }
    
     [HttpDelete("{id}")]
    public string Delete(int id)
    {
       return $"Exempplo delete com id={id}";
    }

    
}
