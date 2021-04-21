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

        double? parameterP;

        public double? ParameterP
        {
            get
            {
                if (Triangle.SideValidation == true)
                {
                    parameterP = CalculateParameterP(Triangle.SideA, Triangle.SideB, Triangle.SideC);
                }
                return parameterP = null;
            }
        }

        double CalculateParameterP(double sideA, double sideB, double sideC)
        {
            var parameterP = (1 / 2) * (sideA + sideB + sideC);
            return parameterP;
        }

    }
}
