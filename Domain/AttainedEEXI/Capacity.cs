using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain.AttainedEEXI
{
    static class Capacity
    {
        public static double resultCapacity;

        public static double CalcCapacity(double deadweight, double shipType) // Capacity
        {
            if (shipType == 4) // Containership
            {
                resultCapacity = 0.70 * deadweight;
            }
            else // Ship types other than Containership
            {
                resultCapacity = deadweight;
            }

            return resultCapacity;
        }
    }
}
