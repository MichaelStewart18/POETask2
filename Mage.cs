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

        public override MovementEnum ReturnMove(MovementEnum MageMoves)
        {
            bool ValidMove = false;
            int move = 0;
            MovementEnum Output = MovementEnum.NoMovement;

            while (ValidMove == false)
            {
                move = r.Next(0, 5);
                ValidMove = true;

                if ((characterVision[move].ToString() != "Wall") & (characterVision[move].ToString() != "Hero"))
                {
                    ValidMove = false;
                }
            }
            return (MovementEnum)move;
        }

        public override String ToString()
        {
            return "Mage" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
