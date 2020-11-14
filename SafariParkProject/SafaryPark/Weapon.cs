using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    abstract class Weapon : IShootable
    {
        private string _brand;
        Random rand = new Random();

        public virtual string Shoot()
        {return ToString();}
        public override string ToString()
        {return $"{base.ToString()} - {_brand}";}
        public Weapon(string brand)
        {_brand = brand;}

        public string ShootAt(Hunter x)
        {
            var number = rand.Next(0, 10); //rand number between 1 and 10
            if (number <= 5)
            {
                x.Hit = true;
                return $"Successfully shot at {x.ToString()}";
            }
            return $"Missed shooting at {x.ToString()}";
        }
    }
    class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand){}
        public override string Shoot()
        { return $"Zing!! Shooting a {base.Shoot()}";}

    }
    class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand) { }
        public override string Shoot()
        { return $"Splash!! Shooting a {base.Shoot()}"; }
    }
}
