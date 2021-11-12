using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    class Mage : Enemy
    {
        public Mage(int i, int j, TileType ConstructType, char Symbol, int ConstructEnemyDamage, int ConstructHp) : base(i, j, ConstructType, 'M', 5, 5, 5)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum MageMove)
        {
            MageMove = MovementEnum.NoMovement;

            return MageMove;
        }

        public override String ToString()
        {
            return "Mage" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
