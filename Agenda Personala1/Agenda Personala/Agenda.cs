using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Personala
{
    class Agenda
    {
        private Person owner;
        private List<Event> Eventslist;
       public Agenda(Person owner)
        {
            
            Eventslist = new List<Event>();
            this.owner = owner;
        }

        public List<Event> AddEvent(Event imput)
        {
            Eventslist.Add(imput);
            return Eventslist;
            
        }
    }
}
