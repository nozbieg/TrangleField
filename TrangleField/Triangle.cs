using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangleField
{
    public class Triangle
    {
        public Triangle()
        {
            SideA = 0;
            SideB = 0;
            SideC = 0;
        }

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public bool SideValidation
        {
            get
            {
                return ValidateSide();
            }
        }

        bool ValidateSide()
        {
            if (SideA + SideB > SideC
              && SideA + SideC > SideB
              && SideB + SideC > SideA)
            {
                return true;
            }
            else return false;

        }


    }
}
