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
        [TestCase(2, 2, 3, 3.5d, true)]
        [TestCase(1, 1, 1, 1.5d, true)]
        [TestCase(3, 4, 2, 4.5d, true)]
        [TestCase(1, 2, 3, 0d, false)]
        [TestCase(1, 1, 7, 0d, false)]
        public void ParameterP_Equal_Test(double sideA, double sideB, double sideC, double parameterP, bool validation)
        {
            triangleField.Triangle.SideA = sideA;
            triangleField.Triangle.SideB = sideB;
            triangleField.Triangle.SideC = sideC;

            Assert.AreEqual(validation, triangleField.Triangle.SideValidation, $"Validation should be equal to: {validation}");
            Assert.AreEqual(parameterP, triangleField.ParameterP, $"Parameter P should be equal to: {parameterP}");
        }

    }
}
