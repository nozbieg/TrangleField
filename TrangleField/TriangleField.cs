using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangleField
{
    public class TriangleField
    {

        public Triangle Triangle { get; set; }

        double parameterP;

        public TriangleField(Triangle triangle)
        {
            Triangle = triangle;
        }
        public TriangleField()
        {
            Triangle = new Triangle();
        }

        public double ParameterP
        {
            get
            {
                if (Triangle.SideValidation == true)
                {
                    parameterP = CalculateParameterP(Triangle.SideA, Triangle.SideB, Triangle.SideC);
                    return parameterP;
                }
                else return parameterP = 0;

            }
        }

        double CalculateParameterP(double sideA, double sideB, double sideC)
        {
            var parameterP = (1 / 2) * (sideA + sideB + sideC);
            return parameterP;
        }

        public double CalculateField(Triangle triangle, double parameterP)
        {
            double field = 0;
            if (parameterP != 0)
            {
                var p = parameterP;
                var a = triangle.SideA;
                var b = triangle.SideB;
                var c = triangle.SideC;

                var fieldFunction = (p * ((p - a) * (p - b) * (p - c)));
                if (fieldFunction == 0)
                {
                    return field;
                }
                else if (fieldFunction < 0)
                {
                    return field;
                }
                else
                {
                    field = Math.Sqrt(fieldFunction);

                    return field;
                }
            }
            else return field;

        }
    }
}
