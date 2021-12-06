using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    class Leader : Enemy
    {
        private Tile target;

        public Tile Target
        {
            get { return target; }
            set { target = value; }
        }

        [NonSerialized] public Random r;

        public Leader(int i, int j, TileType ConstructType = TileType.Enemy, char ConstructSymbol = 'L', int ConstructEnemyDMG = 2, int ConstructHP = 20) : base(i, j, ConstructType, 'L', 2, 20, 20)
        {
           
        }

        public override MovementEnum ReturnMove(MovementEnum LeaderMove)
        {
            switch (LeaderMove)
            {
                case MovementEnum.Up:
                    {
                        x--;
                        return LeaderMove;
                    }

                case MovementEnum.Down:
                    {
                        x++;
                        return LeaderMove;
                    }

                case MovementEnum.Left:
                    {
                        y--;
                        return LeaderMove;
                    }

                case MovementEnum.Right:
                    {
                        y++;
                        return LeaderMove;
                    }
            }

            return (MovementEnum)LeaderMove;
        }

        public override String ToString()
        {
            return "Leader" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }

        /*public bool CheckValidMove(int Move)
        {
            bool Output = false;
            if ((Surroundings[Move].TypeEnum == TileType.Ground) || (Surroundings[Move].TypeEnum == TileType.Weapon) || (Surroundings[Move].TypeEnum == TileType.Gold))
            { Output = true; }
            else
            { Output = false; }
            return Output;
        }*/
    }
}
