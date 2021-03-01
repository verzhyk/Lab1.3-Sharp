using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vladVector3D
{
    public class Vector3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Vector3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D SumOfVectors(Vector3D vector)
        {
            return new Vector3D(X + vector.X, Y + vector.Y, Z + vector.Z);
        }
        public Vector3D SubstractionOfVectors(Vector3D vector)
        {
            return new Vector3D(X - vector.X, Y - vector.Y, Z - vector.Z);
        }

        public int ScalarOfVectors(Vector3D vector)
        {
            return (X * vector.X) + (Y * vector.Y) + (Z * vector.Z);
        }
    }
}
