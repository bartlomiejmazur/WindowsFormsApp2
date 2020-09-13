using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UnitTestProject2
{
    [TestClass]
    public class OwocTest
    {
        [TestMethod]

        public void TestMetody_nowy_owoc()
        {
            //arrange
            int x;
            int y;
            int segment = 1;
            int a;
            int b;

            //act
            Random r = new Random();
            a = r.Next(0, 20) * segment;
            b = r.Next(0, 20) * segment;
            x = r.Next(0, 20) * segment;
            y = r.Next(0, 20) * segment;
            



            //assert
            Assert.AreNotEqual(x,  a, "blad");
            Assert.AreNotEqual(y, b, "blad");


        }
        [TestMethod]
        public void TestOwoc()
        {
            //arrange
            int segment = 0;
            int nowy;
            //act
            nowy = segment;
            //assert
            Assert.AreEqual(nowy, segment, "blad");
        }
        
    }
}