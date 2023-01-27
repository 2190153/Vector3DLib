using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VECTOR3D_DLL;

namespace VectorTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructor1()
        {
            Vector3D a = new Vector3D();
            Vector3D b = new Vector3D();
            Vector3D c = new Vector3D();

            Assert.AreEqual(a.i, 0);
            Assert.AreEqual(b.j, 0);
            Assert.AreEqual(c.k, 0);
        }

        [TestMethod]
        public void TostringTest()
        {
            Vector3D v = new Vector3D(1, -2, 3);

            string a = v.ToString();

            Assert.AreEqual(a, "1i-2j+3k");
        }
        [TestMethod]
        public void AdditionTest()
        {
            Vector3D a1 = new Vector3D();
            Vector3D a2 = new Vector3D();
            Vector3D result1;



            a1.i = 5;
            a2.i = 10;
            a1.j = 10;
            a2.j = 10;
            a1.k = 15;
            a2.k = 10;
            result1 = a1 + a2;

            Assert.AreEqual(result1.i, 15);
            Assert.AreEqual(result1.j, 20);
            Assert.AreEqual(result1.k, 25);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            Vector3D a1 = new Vector3D();
            Vector3D a2 = new Vector3D();
            Vector3D result1;



            a1.i = 15;
            a2.i = 10;
            a1.j = 20;
            a2.j = 5;
            a1.k = 15;
            a2.k = 5;
            result1 = a1 - a2;

            Assert.AreEqual(result1.i, 5);
            Assert.AreEqual(result1.j, 15);
            Assert.AreEqual(result1.k, 10);
        }

        /*[TestMethod]
        public void DotProductTest()
        {
            Vector3D a1 = new Vector3D();
            Vector3D a2 = new Vector3D();
            Vector3D result1;

            a1.i = 2;
            a2.i = 2;
            a1.j = 5;
            a2.j = 3;
            a1.k = 2;
            a2.k = 4;
            result1 = a1 * a2;

            Assert.AreEqual(result1.i, 14);
            Assert.AreEqual(result1.j, 4);
            Assert.AreEqual(result1.k, 0);
        }

        [TestMethod]
        public void DivisionTest()
        {
            Vector3D a1 = new Vector3D();
            Vector3D a2 = new Vector3D();
            Vector3D result1;



            a1.i = 5;
            a2.i = 10;
            a1.j = 10;
            a2.j = 10;
            a1.k = 15;
            a2.k = 10;
            double result1 = a1 % a2;

            Assert.AreEqual(result1.i, 15);
            Assert.AreEqual(result1.j, 20);
            Assert.AreEqual(result1.k, 25);
        }*/
     
    }
}
