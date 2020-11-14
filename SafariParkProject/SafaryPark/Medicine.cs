using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    abstract class Medicine : IHealing
    {
        private string _brand;

        public Medicine(string brand) 
        {this._brand = brand;}

        public override string ToString()
        { return $"{base.ToString()} - {_brand}"; }
        public virtual string Heal()
        {return ToString();}
    }

     class Vaccine : Medicine
    {
        public Vaccine(string brand) : base(brand){}
        public override string Heal()
        { return $"Healed with {base.ToString()}"; }
    }

    class Bandages : Medicine
    {
        public Bandages(string brand) : base(brand) { }
        public override string Heal()
        { return $"Healed with {base.ToString()}"; }
    }
}
