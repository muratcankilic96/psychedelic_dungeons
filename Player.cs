using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psychedelic_Dungeons
{
    class Player
    {
        #region Properties
        #region Characteristics
        //* Main characteristics
        // Player instrument
        private string instrumentSpecialty;
        public string InstrumentSpecialty
        {
            get
            {
                return instrumentSpecialty;
            }
        }

        // Player image
        private Image image;
        public Image Sprite
        {
            get
            {
                return image;
            }
        }
        // Player name
        private string name;
        public string Name {
            get
            {
                return name;
            }
        }

        // Player surname
        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
        }

        // Player age
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
        }

        #endregion

            #region Stats

        //* Player stats
        // Vocals
        private int vocals;
        public int Vocals
        {
            get
            {
                return vocals;
            }
            set
            {
                vocals = value;
            }
        }

        // Jamming
        private int jamming;
        public int Jamming
        {
            get
            {
                return jamming;
            }
            set
            {
                jamming = value;
            }
        }

        // Composition
        private int composition;
        public int Composition
        {
            get
            {
                return composition;
            }
            set
            {
                composition = value;
            }
        }

        // Performance
        private int performance;
        public int Performance
        {
            get
            {
                return performance;
            }
            set
            {
                performance = value;
            }
        }

        // Social
        private int social;
        public int Social
        {
            get
            {
                return social;
            }
            set
            {
                social = value;
            }
        }
        #endregion

            #region Modifiers
        //* Modifiers
        // Morale
        private int morale = 50;
        public int Morale
        {
            get
            {
                return morale;
            }
            set
            {
                morale = value;
            }
        }

        // Drunkenness
        private int drunkenness = 0;
        public int Drunkenness
        {
            get
            {
                return drunkenness;
            }
            set
            {
                drunkenness = value;
            }
        }

        // Hunger
        private int hunger;
        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
            }
        }

        // Addiction
        private bool isAddicted = false;
        public bool IsAddicted
        {
            get
            {
                return isAddicted;
            }
            set
            {
                isAddicted = value;
            }
        }

        #endregion
        #endregion
        public Band playerBand = null;
        private int cash = 100;
        public int Cash
        {
            get
            {
                return cash;
            }
            set
            {
                cash = value;
            }
        }
        public Instrument playerInstrument;
        public Inventory items = new Inventory();

        public Player(string isp, Image i, string n, string sn, int a, 
                      int vo, int ja, int co, int pe, int so)
        {
            instrumentSpecialty = isp;
            image       = i;
            name        = n;
            surname     = sn;
            age         = a;
            vocals      = vo;
            jamming     = ja;
            composition = co;
            performance = pe;
            social      = so;
            hunger      = 0;
        }
    }
}
