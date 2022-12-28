using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // Factor for general cargo ships equipped with cranes and cargo-related gear

    public static class FRoRoRamp
    {
        public static double fRoRoRamp;
        public static double capacityNoRoRo;
        public static double capacityRoRo;

        public static double CalcFRoRoRamp (double rampRoRoWeight, double capacity)
        {
            if (rampRoRoWeight == 0)
            {
                fRoRoRamp = 1;
            }

            else
            {
                double capacityRoRo = capacity;
                double capacityNoRoRo = capacity - rampRoRoWeight;

                fRoRoRamp = capacityNoRoRo / capacityRoRo;
            }

            return fRoRoRamp;
        }

    }

}