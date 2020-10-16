using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychedelic_Dungeons
{
    public partial class MarketScreen : Form
    {
        Goods selected;
        public MarketScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            Map m = new Map();
            m.Show();
            Enabled = false;
        }

        private void MarketScreen_Load(object sender, EventArgs e)
        {
            date.Text = GameSystem.dateTime.Day.ToString() + "/" + GameSystem.dateTime.Month.ToString() + "/" + GameSystem.dateTime.Year.ToString();
            marketList.Items.Clear();
            marketList.Items.Add(GameSystem.LoadItem(1));
            marketList.Items.Add(GameSystem.LoadItem(2));
            marketList.Items.Add(GameSystem.LoadItem(3));
            marketList.Items.Add(GameSystem.LoadItem(4));
            marketList.Items.Add(GameSystem.LoadItem(5));
            marketList.Items.Add(GameSystem.LoadItem(6));
        }

        private void MarketBox_Enter(object sender, EventArgs e)
        {

        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            
            if(GameSystem.player.Cash >= selected.cash)
            {
                Goods player_item = null;
                int  player_count = 0;
                GameSystem.player.Cash -= selected.cash;
                MessageBox.Show("Bought one " + selected + ".");
                Tuple<Goods, int> player_item_count = GameSystem.player.items.gc.Find(o => o.Item1 == selected);
                if (player_item_count != null)
                {
                    player_item = player_item_count.Item1;
                    player_count = player_item_count.Item2;
                }
                if(player_item != null)
                {
                    GameSystem.player.items.gc.Remove(player_item_count);
                    GameSystem.player.items.gc.Add(new Tuple<Goods, int>(player_item, player_count + 1));
                } else
                {
                    GameSystem.player.items.gc.Add(new Tuple<Goods, int>(selected, 1));
                }
                
            }
            else
                MessageBox.Show("Not enough money to buy " + selected + ".");
        }

        private void marketList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = (Goods) marketList.SelectedItem;
            cash.Text      = "$" + selected.cash.ToString();
        }
    }
}
