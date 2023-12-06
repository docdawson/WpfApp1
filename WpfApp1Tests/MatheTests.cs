using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet.Frameworks;

namespace WpfApp1.Tests
{
    [TestClass()]
    public class MatheTests
    {
        [TestMethod()]
        public void plusTest()
        {

            //arrange
            int a = 1;
            int b = 2;
            int erwartet = 3;

            //act
            int ergebnis = Mathe.plus(a, b);

            //assert
            Assert.AreEqual(ergebnis, erwartet);
        }


        [TestMethod()]
        public void plusTestAdvanced()
        {

            //arrange
            int a = 999999999;
            int b = 1;
            int erwartet = 1000000000;

            //act
            int ergebnis = Mathe.plus(a, b);

            //assert
            Assert.AreEqual(ergebnis, erwartet);
        }

        [TestMethod()]
        public void minusTest()
        {
            //arrange
            int a = 10;
            int b = 2;
            int erwartet = 8;

            //act
            int ergebnis = Mathe.minus(a, b);

            //assert
            Assert.AreEqual(ergebnis, erwartet);
        }

        [TestMethod()]
        public void minusTest2()
        {
            //arrange
            int a = 10;
            int b = 12;
            int erwartet = -2;

            //act
            int ergebnis = Mathe.minus(a, b);

            //assert
            Assert.AreEqual(ergebnis, erwartet);
        }

        [TestMethod()]
        public void malTest()
        {
            //arrange
            int a = 10;
            int b = 12;
            int erwartet = 120;

            //act
            int ergebnis = Mathe.mal(a, b);

            //assert
            Assert.AreEqual(ergebnis, erwartet);
        }

       

        [TestMethod()]
        public void geteiltTest()
        {
            //arrange
            int a = 100;
            int b = 0;

            //act
            Assert.ThrowsException<ArgumentException>(() => { Mathe.geteilt(a,b);});
        }

        [TestMethod()]
        public void addTest()
        {
            //arrange
            string a = "test";
            string b = "QWER";
            string erwartet = "testQWER";

            //act
            string ergebnis = Mathe.add(a, b);

            //assert
            Assert.AreEqual<string>(ergebnis, erwartet);
        }
    }
}