using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    public class Hunter : Person, IShootable  //hunter is inheriting from Person
    {
        //Backend Field
        private bool _hit = false;

        //Properties
        public bool Hit { get {return _hit; } set { _hit = value; } }
        public IShootable Shooter { get; set ; }

        //Constructors
        public Hunter() { }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName) //this calls the person class contructor and sets the name
        { this.Shooter = shooter;}


        //Shooting Methods + ToString
        public string Shoot()
        { return $"{GetFullName()}: {Shooter.Shoot()}"; } //uses the Person.GetFullName() method
        public string ShootAt(Hunter x)
        { return Shooter.Shoot();}
        public override string ToString()
        { return $"{base.ToString()}"; } //base.toString() in this case is the output from the .toString from Person    
    }
}
