using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychedelic_Dungeons
{

    enum GameMode {
        FREETIME,
        CONCERT,
        PRACTICE
    }

    static class GameSystem
    {
        static public MainScreen ms    = new MainScreen();
        static public MarketScreen mas = new MarketScreen();
        static public Form activeForm;
        static public Player player;
        static public GameMode gameMode = GameMode.FREETIME;
        static public DateTime dateTime = new DateTime(1965, 6, 15, 8, 0, 0);
        static public int hungerTicker = 0;
        static public int hungerRefreshCoefficient;
        static public int gameDay = 1;
        static public List<Goods> g = new List<Goods>();

        static public Goods LoadItem(int index)
        {
            return g.Find(o => o.id == index);
        }

        static public void BuildItems()
        {
            // Boiled egg.

            Goods boiledEgg = new Goods(1, ItemType.ITEM_FOOD, "Boiled Egg", 1, true);
            boiledEgg.saturation = 10;
            g.Add(boiledEgg);

            // Sandwich.

            Goods sandwich = new Goods(2, ItemType.ITEM_FOOD, "Sandwich", 2, true);
            sandwich.saturation = 21;
            g.Add(sandwich);

            // Hamburger.

            Goods hamburger = new Goods(3, ItemType.ITEM_FOOD, "Hamburger", 4, true);
            hamburger.saturation = 43;
            g.Add(hamburger);

            // Burrito.

            Goods burrito = new Goods(4, ItemType.ITEM_FOOD, "Burrito", 8, true);
            burrito.saturation = 90;
            g.Add(burrito);

            // Beer.

            Goods beer = new Goods(5, ItemType.ITEM_DRINK, "Beer", 1, true);
            g.Add(beer);

            // Bottle water.

            Goods bottleWater = new Goods(6, ItemType.ITEM_DRINK, "Bottle Water", 1, true);
            g.Add(bottleWater);

            // Lemonade.

            Goods lemonade = new Goods(7, ItemType.ITEM_DRINK, "Lemonade", 2, true);
            g.Add(lemonade);

            // LSD.
            Goods lsd = new Goods(8, ItemType.ITEM_DRUG, "LSD", 40, true);
            g.Add(lsd);
        }

        internal static string LoadPersonName()
        {
            Random r = new Random();
            int chosen = r.Next() % 10;
            switch(chosen)
            {
                case 0:
                    return "Paul";
                case 1:
                    return "Eugene";
                case 2:
                    return "Doug";
                case 3:
                    return "Dennis";
                case 4:
                    return "Iggy";
                case 5:
                    return "Ozzy";
                case 6:
                    return "Tony";
                case 7:
                    return "Ian";
                case 8:
                    return "Gordon";
                case 9:
                    return "Argen";
            }
            return null;
        }

        internal static string LoadInstrumentName()
        {
            Random r = new Random();
            int chosen = r.Next() % 4;
            switch (chosen)
            {
                case 0:
                    return "guitar";
                case 1:
                    return "bass";
                case 2:
                    return "keyboard";
                case 3:
                    return "drum kit";
            }
            return null;
        }
    }

}
