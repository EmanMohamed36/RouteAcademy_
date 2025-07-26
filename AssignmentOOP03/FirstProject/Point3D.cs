using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    internal class Point3D:ICloneable,IComparable
    {
        public double x { set; get; }
        public double y { set; get; }
        public double z { set; get; }

        public Point3D()
        { 
            x = 0;
            y = 0;
            z = 0;
        }
        public Point3D(double x, double y)
        { 
            this.x = x;
            this.y = y;
            z = 0;
        }
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: (x:{x},y:{y},z:{z})";
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            return (left?.x == right?.x && left?.y == right?.y && left?.z == right?.z);
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return (left?.x != right?.x || left?.y != right?.y || left?.z != right?.z);
        }

        public object Clone()
        { 
            return new Point3D(x, y, z);
        }

        public int CompareTo(object obj)
        {
            if (obj is not Point3D other)
                throw new ArgumentException("Object is not a Point3D");
            if (x != other.x)
            { 
                return x.CompareTo(other.x);
            }
            return y.CompareTo(other.y);
        }


    }
}
