using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Point
    {
        public int x;
        public int y;


        public override string ToString()
        {
            //return base.ToString();
            return $"({x},{y})";
        }

        public override bool Equals(object? obj)
        {
            //return base.Equals(obj);
            return x == ((Point)obj).x && y == ((Point)obj).y ;
        }
    }

    internal class Point3D : Point
    {
        public int z;
    }

    struct Temp
    {

    }
}
