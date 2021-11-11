using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    public class Gold : Item 
    {
        private Random r = new Random();
        private int goldAmt;

        public int GoldDrop()
        {
            return goldAmt;
        }

    public Gold(int x, int y) : base(x, y, TileType.Gold, '@')
        {
            
        }

        //public override abstract ToString();
    }
}
