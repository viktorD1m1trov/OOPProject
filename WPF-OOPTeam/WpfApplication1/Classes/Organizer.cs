using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public class Organizer : Participant, IParticipant
    {
        public int Event
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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
