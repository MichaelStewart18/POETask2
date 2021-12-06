using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POETask2
{
    class Shop
    {
        [NonSerialized]
        public Random r = new Random();
        private Character Buyer;

        private Weapon[] stock;

        public Weapon[] Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Shop(Character buyer)
        {
            Buyer = buyer;
            Stock = new Weapon[3];
            r = new Random();

            for (int i = 0; i < 3; i++)
            {
                Stock[i] = RandomWeapon(r.Next(4));
            }
        }

        private Weapon RandomWeapon(int RandWeap)
        {
            Weapon Output = null;

            switch (RandWeap)
            {
                case 0:
                    Output = new RangedWeapon(RangedWeapon.RangedWeaponTypes.Rifle);
                    break;
                case 1:
                    Output = new RangedWeapon(RangedWeapon.RangedWeaponTypes.Longbow);
                    break;
                case 2:
                    Output = new MeleeWeapon(MeleeWeapon.MeleeWeaponTypes.Dagger);
                    break;
                case 3:
                    Output = new MeleeWeapon(MeleeWeapon.MeleeWeaponTypes.Longsword);
                    break;
            }

            return Output;
        }


       /* public bool CanBuy(int num)
        {
            bool Output = false;
            Weapon Purchase;
            Purchase = Stock[num];

            if (Purchase.Cost > Buyer.GoldPurse)
            {
                Output = false;
            }
            else
            {
                Output = true;
            }
            return Output;
        }

        public void Buy(int num)
        {
            Buyer.GoldPurse = Buyer.GoldPurse - Stock[num].Cost;
            Buyer.Pickup(Stock[num]);
            r = new Random();
            Stock[num] = RandomWeapon(r.Next(4));
        }

        public string DisplayWeapon(int num)
        {
            string Output = "";

            switch (Stock[num].Symbol)
            {
                case "D":
                    Output = "Buy Dagger for 3 Gold";
                    break;

                case "B":
                    Output = "Buy LongBow for 6 Gold";
                    break;

                case "S":
                    Output = "Buy LongSword for 5 Gold";
                    break;

                case "R":
                    Output = "Buy Rifle for 7 Gold";
                    break;
            }
            return Output;


        } */
    }
}
