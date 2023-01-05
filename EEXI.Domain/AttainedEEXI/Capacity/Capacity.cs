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

        public static double CalcCapacity(double deadweight, string shipType, double grossTonnage) // Capacity
        {
            if (shipType == "Containership")
            {
                capacity = 0.70 * deadweight;
            }

            if (shipType == "Cruise passenger ship having non-conventional propulsion")
            {
                capacity = grossTonnage;
            }

            else // Other ship types
            {
                capacity = deadweight;
            }

            return capacity;
        }
    }
}
