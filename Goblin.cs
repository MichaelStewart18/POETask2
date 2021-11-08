using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    class Goblin : Enemy
    {
        public Goblin(int i, int j, TileType ConstructType, char Symbol, int ConstructEnemyDamage, int ConstructHp) : base(i, j, ConstructType, 'G', 1, 10, 10)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum GoblinMoves)
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
                    ValidMove = true;
                }
            }
            return (MovementEnum)move;
        }

        public override String ToString()
        {
            return "Goblin" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
