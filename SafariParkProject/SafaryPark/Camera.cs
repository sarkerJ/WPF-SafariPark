using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    public class Camera :IShootable
    {
        private string _brand;
        Random rand = new Random();

        public Camera(string brand)
        {
            this._brand = brand;
        }

        public string Shoot()
        { return $"Shooting a {ToString()}"; }

        public string ShootAt(Hunter x)
        {
            var number = rand.Next(1, 11); //rand number between 1 and 10
            if (number <= 8)
            {
                x.Hit = true;
                return $"Successfully shot at {x.ToString()}";
            }

            return $"Missed shooting at {x.ToString()}";
        }

        public override string ToString()
        { return $"{base.ToString()} - {_brand}"; }
    }
}
