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
    }
}
