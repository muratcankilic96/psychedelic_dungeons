using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychedelic_Dungeons
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            GameSystem.ms.Enabled = true;
            Hide();
        }

        private void UpdateList()
        {
            listing.Items.Clear();
            foreach (var gc_ in GameSystem.player.items.gc)
            {
                listing.Items.Add(gc_);
            }
        }

        private void inventoryBox_Enter(object sender, EventArgs e)
        {

        }

        private void use_Click(object sender, EventArgs e)
        {
            Tuple<Goods, int> used = (Tuple<Goods, int>)listing.SelectedItem;
            Goods new_g = used.Item1;
            int new_c   = used.Item2;
            new_c--;
            var removed = GameSystem.player.items.gc.Find(o => o == listing.SelectedItem);
            removed.Item1.Use();
            if (new_c != 0 && removed.Item1.isConsumable)
            { 
                GameSystem.player.items.gc.Remove(removed);
                GameSystem.player.items.gc.Add(new Tuple<Goods, int>(new_g, new_c));
            }
            UpdateList();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
