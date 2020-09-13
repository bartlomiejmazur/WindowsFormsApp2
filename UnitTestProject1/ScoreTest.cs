using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;

namespace UnitTestProject2
{
    [TestClass]
    public class ScoreTest
    {
        [TestMethod]
        public void TestKonstruktoraWynik()
        {
            //arrange
            int Score = 0;
            int Points = 10;

            //act
            Wynik cos = new Wynik();

            //assert
            Assert.AreEqual(Score, Wynik.Score, "blad");
            Assert.AreEqual(Points, Wynik.Points, "b³¹d");
        }
    }
}
