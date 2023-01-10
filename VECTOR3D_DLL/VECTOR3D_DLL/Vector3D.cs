using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VECTOR3D_DLL
{
    public class Vector3D
    {
        private double x;
        private double y;
        private double z;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Vector3D()
        {
            X=0;
            Y=0;
            Z=0;
                
        }

     /*   public _3DVector Add(_3DVector other)
        {
            return new _3DVector(X + other.X, Y + other.Y, Z + other.Z);
        }
        public _3DVector Sub(_3DVector other)
        {
            return new _3DVector(X - other.X, Y - other.Y, Z - other.Z);
        }
        public double DotProduct(_3DVector other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }
        public _3DVector CrossProduct(_3DVector other)
        {
            return new _3DVector(
                Y * other.Z - Z * other.Y,
                Z * other.X - X * other.Z,
                X * other.Y - Y * other.X);
        }*/

        public static Vector3D operator+(Vector3D op1, Vector3D op2, Vector3D op3)
        {
            Vector3D temp = new Vector3D();
            {
                temp.X = op1.X + op2.X + op3.X;
                temp.Y = op1.Y + op2.Y + op3.Y;
                temp.Z = op1.Z + op2.Z + op3.Z;
                return temp;
            }
        }
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }


    }
}
