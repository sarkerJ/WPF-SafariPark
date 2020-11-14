using System;
using System.Collections.Generic;
using System.Text;

namespace SafaryPark
{
    public struct Point3D
    {
        public int x, y, z;
        public Point3D(int x, int y, int z) //in Struct you need to initialize all the fields!
        {
            this.x = x; //this.x means the public int x
            this.y = y;
            this.z = z;

        }
        
    }
}
