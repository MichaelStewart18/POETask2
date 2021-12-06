using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    abstract class Weapon : Item
    {
        protected Weapon(char ConstructSymbol, int i = -1, int j = -1, TileType ConstructType = TileType.Weapon) : base(i, j, ConstructType, ConstructSymbol)
        {
            this.Symbol = ConstructSymbol;
        }

        private int damage;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        private int range;

        public virtual int Range
        {
            get { return range; }
            set { range = value; }
        }

        private int durability;

        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        private int cost;

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private int weapontype;

        public int WeaponType
        {
            get { return weapontype; }
            set { weapontype = value; }
        }
    }
}
