using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Local { get; set; }
        public string EventDate { get; set; }
        public string Theme { get; set; }
        public int QtdPeople { get; set; }
        public string batch { get; set; }
        public string ImageURL { get; set; }

        
    }
}