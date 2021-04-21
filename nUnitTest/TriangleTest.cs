using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrangleField;

namespace nUnitTest
{
    [TestFixture]
    class TriangleTest
    {
        private Triangle triangle;

        [SetUp]
        public void SetUp()
        {
            triangle = new Triangle();
        }

        [Test]
        public void Triangle_IsNull_Test()
        {
            Assert.IsNotNull(triangle, "Object triangle should exist");
        }

        [Test]
        public void Triangle_InitParameter_Test()
        {
            Assert.AreEqual(triangle.SideA, 0, "SideA should be equal 0");
            Assert.AreEqual(triangle.SideB, 0, "SideB should be equal 0");
            Assert.AreEqual(triangle.SideC, 0, "SideC should be equal 0");

            Assert.AreEqual(triangle.SideValidation, false, "Triangle validation should be false");
        }
        [Test]
        [TestCase(2, 2, 3)]
        [TestCase(1, 1, 1)]
        public void Triangle_CTOR_Parameter_Test(double sideA, double sideB, double sideC)
        {
            var triangleCtor = new Triangle(sideA, sideB, sideC);

            Assert.AreEqual(triangleCtor.SideA, sideA, $"SideA should be equal {sideA}");
            Assert.AreEqual(triangleCtor.SideB, sideB, $"SideB should be equal {sideB}");
            Assert.AreEqual(triangleCtor.SideC, sideC, $"SideC should be equal {sideC}");
        }

        [Test]
        [TestCase(2, 2, 3, true)]
        [TestCase(1, 1, 1, true)]
        [TestCase(3, 4, 2, true)]
        [TestCase(1, 2, 3, false)]
        [TestCase(1, 1, 7, false)]
        public void Triangle_SettingParameter_Test(double sideA, double sideB, double sideC, bool validation)
        {
            triangle.SideA = sideA;
            triangle.SideB = sideB;
            triangle.SideC = sideC;

            Assert.AreEqual(triangle.SideA, sideA, $"Parameter A should be equal {sideA}");
            Assert.AreEqual(triangle.SideB, sideB, $"Parameter B should be equal {sideB}");
            Assert.AreEqual(triangle.SideC, sideC, $"Parameter C should be equal {sideC}");

            Assert.AreEqual(triangle.SideValidation, validation, $"Triangle validation should be: {validation}");
        }
    }
}
