using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    public static class Capacity
    {
        public static double capacity;

        public static double CalcCapacity(double deadweight, string shipType) // Capacity
        {
            if (shipType == "Containership")
            {
                capacity = 0.70 * deadweight;
            }
            else // Ship types other than Containership
            {
                capacity = deadweight;
            }

            return capacity;
        }
    }
}
