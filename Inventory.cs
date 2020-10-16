using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Psychedelic_Dungeons
{
    public class Inventory
    {
        public List<Tuple<Goods, int>> gc = new List<Tuple<Goods, int>>();

        public Inventory()
        {
            gc.Add(new Tuple<Goods, int>(GameSystem.LoadItem(1), 2));
            Debug.Write(gc[0].Item1.ToString() + " " + gc[0].Item2);
        }
        
    }
}