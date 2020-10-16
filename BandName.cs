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
    public partial class BandName : Form
    {
        internal string musicianName;
        public BandName()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Band b = new Band(BandNameText.Text, new Musician(musicianName, "Drums"));
            GameSystem.player.playerBand = b;
            GameSystem.activeForm.Enabled = true;
            GameSystem.ms.band.Text = GameSystem.player.playerBand.Name;
            Hide();
        }
    }
}
