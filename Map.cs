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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameSystem.activeForm.Enabled = true;
            Hide();
        }

        private void TransferToPlace(Form f)
        {
            GameSystem.activeForm.Visible = false;
            GameSystem.activeForm = f;
            f.Visible = true;
            f.Enabled = true;
            Hide();
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            TransferToPlace(GameSystem.ms);
        }

        private void marketLabel_Click(object sender, EventArgs e)
        {
            TransferToPlace(GameSystem.mas);
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }
    }
}
