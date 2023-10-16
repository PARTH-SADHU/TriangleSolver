using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TestClass
{
    public class TirangleTester
    {
        [Test]
        public void EquilateralTriangleTest()
        {
            int side1 = 5;
            int side2 = 5;
            int side3 = 5;

            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("A triangle is formed and it is an EQUILATERAL", result);
        }

        [Test]
        public void IsoscelesTriangleTest1()
        {
            int side1 = 3;
            int side2 = 4;
            int side3 = 4;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("A triangle is formed and it is an ISOSCELES", result);
        }

        [Test]
        public void IsoscelesTriangleTest2()
        {
            int side1 = 4;
            int side2 = 4;
            int side3 = 6;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("A triangle is formed and it is an ISOSCELES", result);
        }



    }
}
