using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    public interface IMoveable
    {
        string Move();
        string Move(int times);
    }
}
