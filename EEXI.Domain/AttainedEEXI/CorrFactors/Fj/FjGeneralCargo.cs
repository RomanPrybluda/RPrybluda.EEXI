using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.8.4 Correction factor for general cargo ships fjgenaralcargo

    public static class FjGeneralCargo
    {
        public static double fJGeneralCargo;
        public static double cB;
        public static double fNv;

        public static double CalcFjGeneralCargo(string shipType, double vRef, double vDisplacement, double cB)
        {
            
            fNv = 0.5144 * vRef / Math.Sqrt(9.81 * Math.Pow(vDisplacement, 0.333333));

            if (shipType == "General cargo ship" & fNv <= 0.6)
            {
                fJGeneralCargo = 0.174 / (Math.Pow(fNv, 2.3) * Math.Pow( cB, 0.3));                          
            }

            if (shipType == "General cargo ship" & fNv > 0.6)
            {
                fNv = 0.6;
                fJGeneralCargo = 0.174 / (Math.Pow(fNv, 2.3) * Math.Pow(cB, 0.3));
            }

            if (shipType != "General cargo ship")
            { 
                fJGeneralCargo = 1;
            }

            return fJGeneralCargo;

        }
    }
}   