using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();

        private int enemyDamage;

        public int EnemyDamage
        {
            get { return enemyDamage; }
            set { enemyDamage = value; }
        }

        public Enemy(int x, int y, TileType ConstructType, char Symbol, int ConstructEnemyDamage, int ConstructHp, int ConstructMaxHP) : base(x, y, ConstructType, Symbol)
        {
            damage = ConstructEnemyDamage;
            hp = ConstructHp;
            maxhp = ConstructMaxHP;

        }

        public override String ToString()
        {
            String Info = GetType().Name + "\n";
            Info += "at [" + x.ToString() + ";" + y.ToString() + "] \n";
            Info += Hp.ToString() + " HP \n";
            Info += "{" + Damage.ToString() + "}";
            return Info;
        }

    }
}
