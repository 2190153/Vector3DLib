using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VECTOR3D_DLL;

namespace VectorTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TostringTest()
        {
            Vector3D v = new Vector3D(1, -2, 3);

            string a = v.ToString();

            Assert.AreEqual(a, "1i-2j+3k");
        }
    }
}
