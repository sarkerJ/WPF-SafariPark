using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    public interface IShootable
    {
        public string Shoot();
        public string ShootAt(Hunter x);

    }
}
