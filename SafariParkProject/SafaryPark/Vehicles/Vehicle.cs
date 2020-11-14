using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    public class Vehicle : IMoveable
    {
        private int _capacity;
        private int _numPassangers;
        private int _speed =10;

        public int NumPassengers 
        {
            get { return _numPassangers; }
            set { if (value >= 0 & value <= _capacity) _numPassangers = value; else if (value > _capacity) _numPassangers = _capacity; }
        }

        public int Position { get; protected set; }
        //public int Speed { get { return _speed;} }
        //public int Capacity { get { return _capacity; } }



         public virtual string Move()
        {
            Position += _speed;
            return $"Moving along";
        }

         public virtual string Move(int times)
        {
            Position += _speed * times;
            return $"Moving along {times} times";
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }

        public Vehicle()
        {
           
        }
        public override string ToString()
        {
            return $"{base.ToString()} capacity: {_capacity} passengers: {NumPassengers} speed: {_speed} position: {Position}"; //base.toString() in this case is the output from the .toString from Person
        }
    }
}
