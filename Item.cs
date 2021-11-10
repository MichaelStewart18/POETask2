using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    public abstract class Item : Tile
    {
        protected char Symbol;
        int itemType;

        protected Item(int x, int y, TileType ConstructType, char ConstructSymbol) : base(x, y, ConstructType, ConstructSymbol)
        {
            ConstructSymbol = Symbol;
        }

        public override string ToString()
        {
            return itemType.ToString();
        }
    }
}
