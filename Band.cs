namespace Psychedelic_Dungeons
{
    public class Band
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private Musician[] members = new Musician[4];
        public Musician[] Members {
            get
            {
                return members;
            }
            set
            {
                members = value;
            }
        }


        private int musicianCount;
        private int charts;

        public Band(string n, params Musician[] mems)
        {
            int i = 0;
            name = n;
            foreach(Musician m in mems) mems[i++] = m;
            musicianCount += 1;
        }

        public void AddMember(Musician m)
        {
            members[musicianCount++] = m;
        }
    }
}