using System;
using System.Collections.Generic;
using System.Text;

namespace PRAXYS.Shared.Entities
{
    public class Contact
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Gender { get; set; }

        public int ClientID { get; set; }
        public Clients Client { get; set; }
    }
}
