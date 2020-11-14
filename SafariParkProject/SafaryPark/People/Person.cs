using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    public class Person : IMoveable
    {
        private string _firstName;
        private string _lastName;

        private int _age;
        public int Age
        {
            get { return _age; }
            set { if(value >= 0) _age = value; } //did not have to say int value because its mentioned in propery name
        }
        //public int Age { get; set; } //prop +tab +tab //property //auto implemented propery

        public Person() { }

        public Person(string fname, string lName) //ctor +tab+tab //constructor don't have a return type
        {
            _firstName = fname;
            _lastName = lName;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override string ToString() //if you add sealed then any child classes cannot ovveride the ToString() method same goes if you use it in the class name
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }

        //used from the interface
         public virtual string Move(){
            return $"Walking along";
        }

         public virtual string Move(int times)
        {
            return $"Walking along {times} times";
        }



    }
}
