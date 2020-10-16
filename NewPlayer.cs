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
    public partial class NewPlayer : Form
    {
        int tempNumerator;
        int valuesToDistrib = 8;
        int imageId = 1;
        Image i = Properties.Resources._1;

        public NewPlayer()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if(valuesToDistrib == 0) {
                GameSystem.BuildItems();
                GameSystem.activeForm = GameSystem.ms;
                string instrument = "";
                if (guitar.Checked) instrument = "Guitar";
                if (bass.Checked) instrument = "Bass";
                if (keyboards.Checked) instrument = "Keyboards";
                if (drums.Checked) instrument = "Drums";
                GameSystem.player = new Player(instrument, i, nameText.Text, surnameText.Text, Int32.Parse(age.Text), 
                    Int32.Parse(vo.Text), Int32.Parse(ja.Text), Int32.Parse(co.Text), Int32.Parse(pe.Text), Int32.Parse(so.Text));
                GameSystem.ms.Show();
                Hide();
                }
            else
                {
                    MessageBox.Show("Not all values are distributed.");
                }
        }

        private void incrementValue(Label l, Button b, Button bOpp)
        {
            if (valuesToDistrib != 0) {
                tempNumerator = Int32.Parse(l.Text);
                tempNumerator++;
                l.Text = tempNumerator.ToString();
                if (l.Text.Equals("10"))
                    b.Enabled = false;
                else
                    bOpp.Enabled = true;
                valuesToDistrib--;
                stats.Text = "STATS (" + valuesToDistrib + ")";
            }
        }

        private void decrementValue(Label l, Button b, Button bOpp)
        {
            tempNumerator = Int32.Parse(l.Text);
            tempNumerator--;
            l.Text = tempNumerator.ToString();
            if (l.Text.Equals("1"))
                b.Enabled = false;
            else
                bOpp.Enabled = true;
            valuesToDistrib++;
            stats.Text = "STATS (" + valuesToDistrib + ")";
        }

        private void voRight_Click(object sender, EventArgs e)
        {
            incrementValue(vo, voRight, voLeft);
        }

        private void voLeft_Click(object sender, EventArgs e)
        {
            decrementValue(vo, voLeft, voRight);
        }

        private void jaRight_Click(object sender, EventArgs e)
        {
            incrementValue(ja, jaRight, jaLeft);
        }

        private void jaLeft_Click(object sender, EventArgs e)
        {
            decrementValue(ja, jaLeft, jaRight);
        }

        private void coLeft_Click(object sender, EventArgs e)
        {
            decrementValue(co, coLeft, coRight);
        }

        private void peLeft_Click(object sender, EventArgs e)
        {
            decrementValue(pe, peLeft, peRight);
        }

        private void soLeft_Click(object sender, EventArgs e)
        {
            decrementValue(so, soLeft, soRight);
        }

        private void coRight_Click(object sender, EventArgs e)
        {
            incrementValue(co, coRight, coLeft);
        }

        private void peRight_Click(object sender, EventArgs e)
        {
            incrementValue(pe, peRight, peLeft);
        }

        private void soRight_Click(object sender, EventArgs e)
        {
            incrementValue(so, soRight, soLeft);
        }

        private void ChangeImage()
        {
            switch(imageId)
            {
                case 1:
                    {
                        i = Properties.Resources._1;
                        break;
                    }
                case 2:
                    {
                        i = Properties.Resources._2;
                        break;
                    }
                case 3:
                    {
                        i = Properties.Resources._3;
                        break;
                    }
            }
            sprite.Image = i;
        }

        private void right_Click(object sender, EventArgs e)
        {
            imageId++;
            ChangeImage();
            if (imageId == 3) right.Enabled = false;
            else
                left.Enabled = true;
        }

        private void left_Click(object sender, EventArgs e)
        {
            imageId--;
            ChangeImage();
            if (imageId == 1) left.Enabled = false;
            else
                right.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void NewPlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
