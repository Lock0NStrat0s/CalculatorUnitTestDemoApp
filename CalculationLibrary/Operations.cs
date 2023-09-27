using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary
{
    public class Operations
    {
        public double Add(double uno, double dos)
        {
            return uno + dos;
        }

        public double Subtract(double uno, double dos)
        {
            return uno - dos;
        }

        public double Multiply(double uno, double dos)
        {
            return uno * dos;
        }

        public double Divide(double uno, double dos)
        {
            double output = 0;

            if (dos != 0)
            {
                output = uno / dos;
            }

            return output;
        }
    }
}
