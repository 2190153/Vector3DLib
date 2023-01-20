using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VECTOR3D_DLL;

namespace VectroDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3D v = new Vector3D(1, -2, 3);

            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
