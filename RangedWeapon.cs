using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    class RangedWeapon : Weapon
    {
        public enum RangedWeaponTypes
        {
            Rifle, Longbow, BareHanded
        }
        public RangedWeapon(RangedWeaponTypes WeaponType, int i = -1, int j = -1, TileType ConstructType = TileType.Weapon, char ConstructSymbol = '.') : base(ConstructSymbol, i, j, ConstructType)
        {
            if (WeaponType == RangedWeaponTypes.Rifle)
            {
                base.Symbol = 'R';
                base.Durability = 10;
                base.Range = 3;
                base.Damage = 5;
                base.Cost = 7;
            }
            if (WeaponType == RangedWeaponTypes.Longbow)
            {
                base.Symbol = 'B';
                base.Durability = 4;
                base.Range = 2;
                base.Damage = 4;
                base.Cost = 6;
            }
            if (WeaponType == RangedWeaponTypes.BareHanded)
            {
                base.Symbol = '.';
                base.Durability = 0;
                base.Damage = 0;
                base.Cost = 0;
            }
            base.x = i;
            base.y = j;

        }
    }
}
