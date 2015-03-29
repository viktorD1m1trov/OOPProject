using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public abstract class Person
    {

        private string name;
        private string gender;
        //constructor

        public string Name
        {
            get
            {
                return this.name;
            }
          protected  set
            {
                if (string.IsNullOrEmpty(value) || value.Length<2)
                {
                    throw new Exception("Name length must be greater than 2.");
                }
                this.name = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
           protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Gender must be specified.");
                }
                this.gender = value;
            }
        }

        public void RoomDistribuition(Participant person)//  Rooms room
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
