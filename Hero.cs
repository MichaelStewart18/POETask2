using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POETask2
{
    class Hero : Character
    {
        public Hero(int x, int y, TileType ConstructType, char Symbol, int ConstructHp, int ConstructMaxHP) : base(x, y, ConstructType, 'H')
        {
            damage = 2;
            hp = ConstructHp;
            maxhp = ConstructMaxHP;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            switch (move)
            {
                case MovementEnum.Up:
                    {
                        x--;
                        return move;
                    }

                case MovementEnum.Down:
                    {
                        x++;
                        return move;
                    }

                case MovementEnum.Left:
                    {
                        y--;
                        return move;
                    }

                case MovementEnum.Right:
                    {
                        y++;
                        return move;
                    }
            }

            return Character.MovementEnum.NoMovement;
        }

        public AttackEnum ReturnAttack(AttackEnum attack)
        {
            switch (attack)
            {
                case AttackEnum.Up:
                    {
                        if(Map.map[x-1, y] is Goblin)
                        {
                            MessageBox.Show("Hit!");
                        }
                        return attack;
                    }

                case AttackEnum.Down:
                    {
                        if (Map.map[x+1, y] is Goblin)
                        {
                            MessageBox.Show("Hit!");
                        }
                        return attack;
                    }

                case AttackEnum.Left:
                    {
                        if (Map.map[x, y-1] is Enemy)
                        {
                            MessageBox.Show("Hit!");
                        }
                        return attack;
                    }

                case AttackEnum.Right:
                    {
                        if (Map.map[x, y+1] is Goblin)
                        {
                            MessageBox.Show("Hit!");
                        }
                        return attack;
                    }
            }

            return Character.AttackEnum.NoAttack;
        }
        public override String ToString()
        {
            return "Hero" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
