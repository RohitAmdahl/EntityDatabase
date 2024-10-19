using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDatabase.Models
{
    public class Musician
    {
        public int MusicianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Origin { get; set; }

        // Navigation properties 

        public int BandId { get; set; }
        public Band Band { get; set; }

        public int InstrumentId { get; set; }
        public Instrument Instrument { get; set; }

    }
}
