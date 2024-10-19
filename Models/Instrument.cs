namespace EntityDatabase.Models
{
    public class Instrument
    {
        public int InstrumentId { get; set; }
        public string InstrumentName { get; set; }
        public string Description { get; set; }

        // navigation 
        public List<Musician> Musicians { get; set; }

    }
}
