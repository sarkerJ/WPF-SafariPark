using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    public class Ranger :Person, IShootable, IHealing
    {
        Random rand = new Random();

        public IShootable Shooter { get; set; }
        public IHealing Healing { get; set; }

        public Ranger() { }
        public Ranger(string fName, string lName, IShootable shooter) : base(fName, lName) 
        { this.Shooter = shooter; }

        public Ranger(string fName, string lName, IShootable shooter, IHealing healing) : base(fName, lName)
        {
            this.Shooter = shooter;
            this.Healing = healing; 
        }

        //Shooting methods
        public string Shoot()
        { return $"{GetFullName()}: {Shooter.Shoot()}"; }
        public string ShootAt(Hunter x)
        { return Shooter.ShootAt(x); }

        public override string ToString()
        { return $"{base.ToString()}"; } //base.toString() in this case is the output from the .toString from Person

        public string Heal()
        {return Healing.Heal();}
    }
}
