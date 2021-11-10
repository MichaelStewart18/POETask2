using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    public abstract class Tile
    {
        private char symbol;
        protected int x;
        protected int y;
        public enum TileType
        {
            Hero = 0,
            Enemy = 1,
            Gold = 2,
            Weapon = 3,
            Obstacle = 4,
            EmptyTile = 5
        }

        public char getSymbol()
        {
            return symbol;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        protected TileType TypeEnum;

        public TileType typeEnum
        {
            get { return typeEnum; }
            set { TypeEnum = value; }
        }

        public Tile(int i, int j, TileType ConstructType, char Symbol)
        {
            x = i;
            y = j;
            TypeEnum = ConstructType;
            symbol = Symbol;
        }


    }
}
