using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Participant : Person, IParticipant, IDriver
    {
        private int moneyPaid;
        private int gsm;
        private int email;
    
        public int HasPaid
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int GSM
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Mai
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int MoneyPaid
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int EMai
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        //dobaveno Andrej 27.03
        public void AddMusicalWish(string wish)
        {
            StreamWriter sw = new StreamWriter("..\\..\\MusicalWishList.txt");
            using (sw)
            {
                sw.WriteLine(wish);
            }
        }
    }
}
