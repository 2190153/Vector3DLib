using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VECTOR3D_DLL
{
    public class Vector3D
    {
        private double _i;
        private double _j;
        private double _k;

        public double i
        {
            get { return _i; }
            set { _i = value; }
        }

        public double j
        {
            get { return _j; }
            set { _j = value; }
        }

        public double k
        {
            get { return _k; }
            set { _k = value; }
        }

        public Vector3D(double i, double j, double k)
        {
            _i = i;
            _j = j;
            _k = k;
        }
        public Vector3D()
        {
            _i=0;
            _j=0;
            _k=0;
                
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

        public static Vector3D operator+(Vector3D op1, Vector3D op2)
        {
            Vector3D temp = new Vector3D();
            
            temp._i = op1._i + op2._i;
            temp._j = op1._j + op2._j;
            temp._k = op1._k + op2._k;
            return temp;
            
        }

        public static Vector3D operator -(Vector3D op1, Vector3D op2)
        {
            Vector3D temp = new Vector3D();

            temp._i = op1._i - op2._i;
            temp._j = op1._j - op2._j;
            temp._k = op1._k - op2._k;
            return temp;

        }

        public static Vector3D operator *(Vector3D op1, Vector3D op2)
        {
            Vector3D temp = new Vector3D();

            temp._i = (op1._j * op2._k) - (op2._j * op1._k);
            temp._j = (op1._i * op2._k) - (op2._i * op1._k);
            temp._k = (op1._i * op2._j) - (op2._j * op1._i);
            return temp;

        }

        public static double operator %(Vector3D op1, Vector3D op2)
        {
         
            return (op1._i * op2._i)+ (op1._j * op2._j)+ (op1._k * op2._k); 

        }
        public override string ToString()
        {
            string temp = "";

            if (_i!= 0)
            {
                if (_i > 0)
                {
                    temp += _i.ToString();
                }
            }


            if (_j != 0)
            {
                if (_j > 0)
                {
                    temp += _j.ToString();
                }

            }


            return $"({_i}, {_j}, {_k})";
        }


    }
}
