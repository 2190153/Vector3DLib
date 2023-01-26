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
            _i = 0;
            _j = 0;
            _k = 0;
        }

           public Vector3D Add(Vector3D other)
           {
               return new Vector3D(_i + other._i, _j + other._j, _k + other._k);
           }
           public Vector3D Sub(Vector3D other)
           {
               return new Vector3D(_i - other._i, _j - other._j, _k - other._k);
           }
           public double DotProduct(Vector3D other)
           {
               return _i * other._i + _j * other._j + _k * other._k;
           }
           public Vector3D CrossProduct(Vector3D other)
           {
               return new Vector3D(
                   _j * other._k - _k * other._j,
                   _k * other._i - _i * other._k,
                   _i * other._j - _j * other._i);
           }

        public static Vector3D operator +(Vector3D op1, Vector3D op2)
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

            return (op1._i * op2._i) + (op1._j * op2._j) + (op1._k * op2._k);

        }
        public override string ToString()
        {
            string temp = "";

            if (_i != 0)
            {

                temp += _i.ToString() + "i";

            }


            if (_j != 0)
            {
                if (_j > 0)
                {
                    temp += "+" + _j.ToString() + "j";
                }
                else
                {
                    temp += _j.ToString() + "j";
                }

            }

            if (_k != 0)
            {
                if (_k > 0)
                {
                    temp += "+" + _k.ToString() + "k";
                }
                else
                {
                    temp += _k.ToString() + "k";
                }

            }


            return temp;
        }


    }
}
