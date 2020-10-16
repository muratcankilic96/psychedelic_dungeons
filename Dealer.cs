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
    public partial class Dealer : Form
    {
        string dialogText = "I HAVE VERY FINE GOODS\nFOR YOU, MAN!\nDON'T YOU WANT\nIT?";
        int dialogTick = 0;
        bool choice2Chosen = false;
        bool discount = false;
        public Dealer()
        {
            InitializeComponent();
        }

        private void talkingScript_Tick(object sender, EventArgs e)
        {
            label1.Text = dialogText.Substring(0, dialogTick++);
            if (dialogTick == dialogText.Length)
            {
                talkingScript.Stop();
                dialogTick = 0;
            }
        }

        private void DealerBox_Enter(object sender, EventArgs e)
        {

        }

        private void choice1_Click(object sender, EventArgs e)
        {
            if(!choice2Chosen)
            {
                GameSystem.activeForm.Enabled = true;
                Hide();
            }
            else if (GameSystem.player.Social > 7)
            {
                Random r = new Random();
                int chance = r.Next() % 100;
                if(chance < (GameSystem.player.Social * 3))
                {
                    dialogText = "OKAY,\nA PACKAGE IS $30, DO YOU BUY IT\nOR NOT?";
                    talkingScript.Start();
                    discount = true;
                } else
                {
                    dialogText = "HELL NO. $40 IS FINAL.";
                    talkingScript.Start();
                }
                choice1.Visible = false;
            }

        }

        private void AddNarcotic()
        {
            Goods badthing = GameSystem.LoadItem(8);
            Goods player_item = null;
            int player_count = 0;
            Tuple<Goods, int> player_item_count = GameSystem.player.items.gc.Find(o => o.Item1 == badthing);
            if (player_item_count != null)
            {
                player_item = player_item_count.Item1;
                player_count = player_item_count.Item2;
            }
            if (player_item != null)
            {
                GameSystem.player.items.gc.Remove(player_item_count);
                GameSystem.player.items.gc.Add(new Tuple<Goods, int>(player_item, player_count + 1));
            }
            else
            {
                GameSystem.player.items.gc.Add(new Tuple<Goods, int>(badthing, 1));
            }
        }

        private void choice2_Click(object sender, EventArgs e)
        {
            if(!choice2Chosen) { 
                dialogText = "A PACKAGE IS $40, DO YOU BUY\nIT?";
                talkingScript.Start();
                choice2.Text = "BUY IT NOW";
                if (GameSystem.player.Social > 6)
                {
                    choice1.Text = "REQUEST A DISCOUNT";
                }
                choice2Chosen = true;
            }
            else
            {
                if(!discount)
                {
                    if(GameSystem.player.Cash >= 40)
                    { 
                        GameSystem.player.Cash -= 40;
                        GameSystem.activeForm.Enabled = true;
                        Hide();
                    }
                    else
                    {
                        dialogText = "NO $40 HERE, DAMN YOU.\nGO AWAY!";
                        talkingScript.Start();
                    }
                    choice2.Visible = false;
                } 
                else
                {
                    if (GameSystem.player.Cash >= 30)
                    {
                        GameSystem.player.Cash -= 30;
                        GameSystem.activeForm.Enabled = true;
                        Hide();
                    }
                    else
                    {
                        dialogText = "NO $30 HERE, DAMN YOU.\nGO AWAY!";
                        talkingScript.Start();
                    }
                    choice2.Visible = false;
                }
            }
        }

        private void Dealer_Shown(object sender, EventArgs e)
        {
        }

        private void choice3_Click(object sender, EventArgs e)
        {
            GameSystem.activeForm.Enabled = true;
            Hide();
        }

        private void Dealer_Load(object sender, EventArgs e)
        {
            dialogText = "I HAVE VERY FINE GOODS\nFOR YOU, MAN!\nDON'T YOU WANT\nIT?";
            choice1.Text = "KINDLY REFUSE IT";
            choice2.Text = "BUY LSD";
            talkingScript.Start();
        }
    }
}
