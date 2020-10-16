using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychedelic_Dungeons
{
    public partial class MainScreen : Form
    {
        int direction = 1;
        int tickCount = 0;
        Thread t;
        Random r = new Random();
        
        public MainScreen()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            leftMenu.BringToFront();
            characterImage.BackgroundImage = GameSystem.player.Sprite;
            namesurname.Text = GameSystem.player.Name + " " + GameSystem.player.Surname;
            age.Text   = GameSystem.player.Age.ToString();
            voVal.Text = GameSystem.player.Vocals.ToString();
            peVal.Text = GameSystem.player.Performance.ToString();
            soVal.Text = GameSystem.player.Social.ToString();
            jaVal.Text = GameSystem.player.Jamming.ToString();
            coVal.Text = GameSystem.player.Composition.ToString();
            cash.Text = "$" + GameSystem.player.Cash.ToString();
            specialty.Text = GameSystem.player.InstrumentSpecialty;
            if (GameSystem.player.playerBand != null) band.Text = GameSystem.player.playerBand.Name; else band.Text = "None";
            hour.Text = GameSystem.dateTime.Hour.ToString("00");
            min.Text = GameSystem.dateTime.Minute.ToString("00");
            date.Text = GameSystem.dateTime.Day.ToString() + "/" + GameSystem.dateTime.Month.ToString() + "/" + GameSystem.dateTime.Year.ToString();
            hung.Text = GameSystem.player.Hunger.ToString();
            day.Text = "Day " + GameSystem.gameDay.ToString();
            GameSystem.hungerRefreshCoefficient = r.Next() % 10 + 55;
        }

        private void openMenu()
        {
            for(int i = 0; i < 60; i++)
            {
                leftMenu.Invoke( new Action( () =>
                    leftMenu.Location = new Point(leftMenu.Location.X + 6, leftMenu.Location.Y)
                    ));
                Thread.Sleep(1);
            }
        }

        private void closeMenu()
        {
            for (int i = 0; i < 60; i++)
            {
                leftMenu.Invoke(new Action(() =>
                  leftMenu.Location = new Point(leftMenu.Location.X - 6, leftMenu.Location.Y)
                    ));
                Thread.Sleep(1);
            }
        }

        private void characterImage_Click(object sender, EventArgs e)
        {
            direction = 1;
            menuToggle.Enabled = true;
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            direction = -1;
            menuToggle.Enabled = true;
        }

        private void dateTimeCounter_Tick(object sender, EventArgs e)
        {
            int event_probability = r.Next() % 15;
            GameSystem.dateTime = GameSystem.dateTime.AddMinutes(1);
            hour.Text = GameSystem.dateTime.Hour.ToString("00");
            min.Text = GameSystem.dateTime.Minute.ToString("00");
            GameSystem.mas.hour.Text = hour.Text;
            GameSystem.mas.min.Text  = min.Text;
            GameSystem.hungerTicker++;
            if(GameSystem.dateTime.Hour > 22 && GameSystem.gameMode == GameMode.FREETIME)
            {
                dateTimeCounter.Stop();
                MessageBox.Show("Day " + GameSystem.gameDay + " is over.");
                GameSystem.gameDay++;
                GameSystem.dateTime = GameSystem.dateTime.AddDays(1);
                GameSystem.dateTime = GameSystem.dateTime.AddHours(-15);
                date.Text = GameSystem.dateTime.Day.ToString() + "/" + GameSystem.dateTime.Month.ToString() + "/" + GameSystem.dateTime.Year.ToString();
                GameSystem.mas.date.Text = date.Text;
                day.Text = "Day " + GameSystem.gameDay.ToString();
                dateTimeCounter.Start();
            }
            if(GameSystem.hungerTicker == GameSystem.hungerRefreshCoefficient)
            {
                GameSystem.player.Hunger++;
                hung.Text = GameSystem.player.Hunger.ToString();
                GameSystem.hungerRefreshCoefficient = r.Next() % 10 + 55;
                GameSystem.hungerTicker = 0;

            }
            if(GameSystem.player.Hunger >= 100)
            {
                dateTimeCounter.Stop();
                MessageBox.Show(GameSystem.player.Name + " died of hunger.\nGame over.");
                Application.Exit();
            }
            if(event_probability == 1)
            {
                dateTimeCounter.Stop();
                int eventNumber = r.Next() % 5;
                string peopleId = GameSystem.LoadPersonName();
                switch(eventNumber)
                {
                    case 0:
                        if(GameSystem.player.playerBand == null) { 
                            if(MessageBox.Show("When you were talking with your friend " + peopleId + ", you considered building a new band. Do you accept it?", "Event", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                BandName bn = new BandName();
                                GameSystem.activeForm.Enabled = false;
                                bn.musicianName = peopleId;
                                bn.Show();
                            }
                          
                        }
                        else
                        {
                            if (MessageBox.Show("When you were talking with your friend " + peopleId + ", you considered joining him to your band. Do you accept it?", "Event", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                GameSystem.player.playerBand.AddMember(new Musician(peopleId, "Bass"));
                            }
                        }
                        break;
                    case 1:
                        MessageBox.Show("You went on running. Your morale increases but your hunger increases as well.", "Event");
                        GameSystem.player.Hunger += 5;
                        GameSystem.player.Morale += 5;
                        hung.Text = GameSystem.player.Hunger.ToString();
                        break;
                    case 2:
                        if(MessageBox.Show("A dealer comes. Talk with him?", "Event", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Dealer d = new Dealer();
                            GameSystem.activeForm.Enabled = false;
                            d.Show();
                            
                        }
                        break;
                    case 3:
                        MessageBox.Show("You've found a sandwich leftover on the street. It looks clean!");
                        Goods sandwich = GameSystem.LoadItem(2);
                        Goods player_item = null;
                        int player_count = 0;
                        Tuple<Goods, int> player_item_count = GameSystem.player.items.gc.Find(o => o.Item1 == sandwich);
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
                            GameSystem.player.items.gc.Add(new Tuple<Goods, int>(sandwich, 1));
                        }
                        break;
                    case 4:
                        int price = r.Next() % 70 + 30;
                        string instrument = GameSystem.LoadInstrumentName();
                        if (MessageBox.Show("There is a friend that sells his " + instrument  + ". It is $" + price + ". Do you buy it?", "Event", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                        }
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
                dateTimeCounter.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hung_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimeCounter.Stop();
            InventoryForm ifo = new InventoryForm();
            ifo.Show();
            Enabled = false;
        }

        private void MainScreenBox_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                hung.Text = GameSystem.player.Hunger.ToString();
                dateTimeCounter.Start();
            }
        }

        private void menuToggle_Tick(object sender, EventArgs e)
        {
            tickCount++;
            leftMenu.Location = new Point(leftMenu.Location.X + direction * 12, leftMenu.Location.Y);
            if (tickCount == 30) {
                tickCount = 0;
                menuToggle.Enabled = false;
            }
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            Map m = new Map();
            m.Show();
            Enabled = false;
        }
    }
}
