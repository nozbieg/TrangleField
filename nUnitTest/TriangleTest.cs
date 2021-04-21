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
        Triangle triangle;

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
            Assert.AreEqual(0, triangle.SideA, "SideA should be equal 0");
            Assert.AreEqual(0, triangle.SideB, "SideB should be equal 0");
            Assert.AreEqual(0, triangle.SideC, "SideC should be equal 0");

            Assert.AreEqual(false, triangle.SideValidation, "Triangle validation should be false");
        }
        [Test]
        [TestCase(2, 2, 3)]
        [TestCase(1, 1, 1)]
        public void Triangle_CTOR_Parameter_Test(double sideA, double sideB, double sideC)
        {
            var triangleCtor = new Triangle(sideA, sideB, sideC);

            Assert.AreEqual(sideA, triangleCtor.SideA, $"SideA should be equal {sideA}");
            Assert.AreEqual(sideB, triangleCtor.SideB, $"SideB should be equal {sideB}");
            Assert.AreEqual(sideC, triangleCtor.SideC, $"SideC should be equal {sideC}");
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

            Assert.AreEqual(sideA, triangle.SideA, $"Parameter A should be equal {sideA}");
            Assert.AreEqual(sideB, triangle.SideB, $"Parameter B should be equal {sideB}");
            Assert.AreEqual(sideC, triangle.SideC, $"Parameter C should be equal {sideC}");

            Assert.AreEqual(validation, triangle.SideValidation, $"Triangle validation should be: {validation}");
        }
    }
}
