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

    }
}
