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
    class TriangleFieldTest
    {
        TriangleField triangleField;
        Triangle triangle;

        [SetUp]
        public void SetUp()
        {
            triangleField = new TriangleField();
            triangle = new Triangle();
        }

        [Test]
        public void TriangleField_IsNull_Test()
        {
            Assert.IsNotNull(triangleField, "Object triangleField should exist");
        }
        [Test]
        public void ParameterP_InitEqual_Test()
        {
            Assert.AreEqual(0, triangleField.ParameterP, "ParameterP should be equal to 0");
        }

        [Test]
        [TestCase(2, 2, 3, 3.5d)]
        [TestCase(1, 1, 1, 1.5d)]
        [TestCase(3, 4, 2, 4.5d)]
        [TestCase(1, 2, 3, 0d)]
        [TestCase(1, 1, 7, 0d)]
        public void ParameterP_Equal_Test(double sideA, double sideB, double sideC, double parameterP)
        {
            triangleField.Triangle.SideA = sideA;
            triangleField.Triangle.SideB = sideB;
            triangleField.Triangle.SideC = sideC;

            Assert.AreEqual(parameterP, triangleField.ParameterP, $"Parameter P should be equal to: {parameterP}");
        }

        [Test]
        [TestCase(2, 2, 3, 1.98d)]
        [TestCase(1, 1, 1, 0.43d)]
        [TestCase(3, 4, 2, 2.90d)]
        [TestCase(1, 2, 3, 0d)]
        [TestCase(1, 1, 7, 0d)]
        public void CalculateField_Equal_Test(double sideA, double sideB, double sideC, double fieldResult)
        {
            triangleField.Triangle.SideA = sideA;
            triangleField.Triangle.SideB = sideB;
            triangleField.Triangle.SideC = sideC;

            var field = triangleField.CalculateField(triangleField.Triangle, triangleField.ParameterP);
            Assert.AreEqual(fieldResult, field, $"Field should be equal to: {fieldResult}");
        }
    }
}
