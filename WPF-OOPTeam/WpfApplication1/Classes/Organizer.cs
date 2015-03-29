using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public class Organizer : Participant, IParticipant
    {
        private Event eventToOrganize;
        //constructor 
        public Organizer()
        { }

        public Organizer (string name, string gender, Event eventToJoin, string email, string gsm, decimal moneyPaid) 
            : base (name, eventToJoin, email, gsm, moneyPaid)
        {
        }

        public Event EventToOrganize
        {
            get
            {
                return this.eventToOrganize;
            }
            set
            {
                this.eventToOrganize = value;
            }
        }
        
        public void AddParticipant()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteParticipant()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeStatus()
        {
            throw new System.NotImplementedException();
        }
    }
}
