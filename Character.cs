using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    abstract class Character : Tile
    {
        //Member Variables
        protected int Hp;
        protected int MaxHp;
        protected int Damage;
        protected char Symbol;

        public Tile[] characterVision = new Tile[4];

        public int hp
        {
            get { return Hp; }
            set { Hp = value; }
        }

        public int maxhp
        {
            get { return MaxHp; }
            set { MaxHp = value; }
        }

        public int damage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public enum MovementEnum
        {
            NoMovement = 0,
            Up = 1,
            Left = 2,
            Right = 3,
            Down = 4
        }

        protected Character(int x, int y, TileType ConstructType, char ConstructSymbol) : base(x, y, ConstructType, ConstructSymbol)
        {
            ConstructSymbol = Symbol;
            Hp = hp;
            MaxHp = maxhp;
            Damage = damage;
        }



        public int Positions()
        {
            return x;
        }

        public virtual void Attack(Character target)
        {
            target.Hp = target.Hp - 10;
        }

        public bool IsDead = false;    //Check if the character is dead


        public virtual bool CheckRange(Character target)    //Check if the target is in range of the character
        {
            return true;
        }

        private int DistanceTo(Character target)    //Determines the absolute distance between the character and the target
        {
            return Math.Abs(x - target.x) + Math.Abs(y - target.y);
        }

        public void Move(MovementEnum move)  //Edites a units X and Y valaues in order to move it
        {
            switch (move)
            {
                
            }
        }

        public abstract MovementEnum ReturnMove(MovementEnum move = 0);  //Returns a direction of movement


        public abstract override string ToString();  //overrides traditional object ToString Method



    }
}
