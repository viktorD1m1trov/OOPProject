using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public abstract class Person
    {
        public int Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Gender
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void RoomDistribuition(Participant person, Rooms room)
        {
            throw new System.NotImplementedException();
        }

        public void CarDistribution (Participant person, Participant driver)
        {
            throw new System.NotImplementedException();
        }

        public void PrintSummary(Event newEvent)
        {
            throw new NotImplementedException();
        }
    }

    
}
