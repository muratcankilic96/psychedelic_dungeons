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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void credits_Click(object sender, EventArgs e)
        {
            Credits c = new Credits();
            Hide();
            c.Show();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            NewPlayer np = new NewPlayer();
            Hide();
            np.Show();
        }

        private void MainMenu_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}
