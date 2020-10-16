using System.Windows.Forms;

namespace Psychedelic_Dungeons
{
    public enum ItemType
    {
        ITEM_FOOD,
        ITEM_DRINK,
        ITEM_DRUG,
        ITEM_GUITAR,
        ITEM_BASS,
        ITEM_KEYBOARD,
        ITEM_DRUMSTICK,
        ITEM_MICROPHONE,
        ITEM_AMPLIFIER
    }

    public class Goods
    {
        public int id;
        public ItemType type;
        public string name;
        public bool isConsumable;
        public int cash;
        public int saturation;    // Positive value decreases hunger.
        public int addictionRate; // 1 - 100 value is for drugs and alcoholic beverages.
        public override string ToString()
        {
            return name;
        }

        public Goods(int i, ItemType t, string n, int c, bool consume)
        {
            id = i;
            type = t;
            name = n;
            cash = c;
            isConsumable = consume;
        }

        public void Use()
        {
            switch(type)
            {
                case ItemType.ITEM_FOOD:
                    GameSystem.player.Hunger -= 10;
                    if (GameSystem.player.Hunger < 0) GameSystem.player.Hunger = 0;
                    MessageBox.Show("Used " + name + " to heal " + saturation + " hunger.");
                    break;
                default: break;
            }
        }
    }
}