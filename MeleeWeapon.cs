using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    class MeleeWeapon : Weapon
    {
        public enum MeleeWeaponTypes
        {
            Dagger, Longsword, BareHanded
        }
        public MeleeWeapon(MeleeWeaponTypes WeaponType, int i = -1, int j = -1, TileType ConstructType = TileType.Weapon, char ConstructSymbol = '.') : base(ConstructSymbol, i, j, ConstructType)
        {
            if (WeaponType == MeleeWeaponTypes.Dagger)
            {
                base.Symbol = 'D';
                base.Durability = 10;
                base.Damage = 3;
                base.Cost = 3;
            }
            if (WeaponType == MeleeWeaponTypes.Longsword)
            {
                base.Symbol = 'S';
                base.Durability = 6;
                base.Damage = 4;
                base.Cost = 5;
            }
            if (WeaponType == MeleeWeaponTypes.BareHanded)
            {
                base.Symbol = '.';
                base.Durability = 0;
                base.Damage = 0;
                base.Cost = 0;
            }
            base.x = i;
            base.y = j;
            base.Range = 1;
        }



    }
}