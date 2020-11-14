using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    public class Airplane : Vehicle
    {
        private string _airline;
        private int _altitude;

        public Airplane(int capacity, int speed, string name) : base (capacity, speed)
        {
            this._airline = name;
        }
        public Airplane(int capacity) : base(capacity)
        {
            
        }

        public int Altitude { get { return _altitude; } set { _altitude = value; } }

        public void Ascend(int distance)
        {Altitude += distance;}

        public void Descend(int distance)
        {
            int result = Altitude - distance;
            if (result >= 0) Altitude = result;
            else if (result< 0) Altitude = 0;
        }


        public override string Move()
        {
            return $"{base.Move()} at an altitude of {Altitude} metres.";
        }

        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {Altitude} metres.";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude: {Altitude}."; //base.toString() in this case is the output from the .toString from Person
        }
    }
}
