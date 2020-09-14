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
            

            //act
            Random r = new Random();
            Owoc owoc = new Owoc(1);
            owoc.nowy_owoc();
            
            x = r.Next(0, 20) * segment;
            y = r.Next(0, 20) * segment;





            //assert
            Assert.AreNotEqual(x, owoc, "blad") ;
            Assert.AreNotEqual(y, owoc, "blad");
            


        }
        [TestMethod]
        public void TestOwoc()
        {
            //arrange
            int segment;
            
            //act
            Owoc nowy = new Owoc(1);
            Owoc nowy2 = new Owoc(1);
            //assert
            Assert.AreEqual(nowy.segment, nowy2.segment, "blad");
        }
        
    }
}