using Microsoft.AspNetCore.Mvc;
using Project.API.Data;
using Project.API.Models;

namespace Project.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventController : ControllerBase
{
    private readonly DataContext _dataContext;
    public EventController(DataContext dataContext)
    {
      _dataContext = dataContext;
        
    }
    

    [HttpGet]
    public IEnumerable<Event> Get()
    {
         return _dataContext.Events;
         
    }

    [HttpGet("{id}")]
    public IEnumerable<Event> Get(int id)
    {
         return _dataContext.Events.Where(e => e.EventId == id);
         
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
