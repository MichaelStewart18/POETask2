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

       public Gold(int x, int y, TileType ConstructType, char Symbol, int ConstructHp, int ConstructMaxHP) : base(x, y, ConstructType, '@')
        {
            
        }

        //public override abstract ToString();
    }
}
