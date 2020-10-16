namespace Psychedelic_Dungeons
{
    public class Musician
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private string instrument;
        public string Instrument
        {
            get
            {
                return instrument;
            }
        }

        public Musician(string n, string i)
        {
            name         =   n;
            instrument   =   i;
        }
    }
}