namespace EntityDatabase.Models
{
    public class Band
    {
        public int BandId { get; set; }
        public string FirstName { get; set; }
        public string Country { get; set; }

        // navigation 
        public List<Musician> Musicians { get; set; }
    }
}
