using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.11.1 Capacity correction factor for ice-classed ships fIice

    public static class FiIce
    {
        public static double fIice;
        public static double fIiceClass;
        public static double fIcB;
        public static double cBrefdesign;

        
        
        public static double CalcFiIce(string shipType, double deadweight, string iceClass, double cB)
        {
            if (iceClass == "IA Super")
            {
                fIiceClass = 1.0151 + 228.7 / deadweight;
            }

            if (iceClass == "IA")
            {
                fIiceClass = 1.0099 + 95.1 / deadweight;
            }

            if (iceClass == "IB")
            {
                fIiceClass = 1.0067 + 62.7 / deadweight;
            }

            if (iceClass == "IC")
            {
                fIiceClass = 1.0041 + 58.5 / deadweight;
            }

            if (shipType == "Bulk carrier")
            {
                if ( deadweight < 10000 ) { cBrefdesign = 0.78; };
                if ( deadweight > 10000 & deadweight < 25000 ) { cBrefdesign = 0.80; };
                if ( deadweight > 25000 & deadweight < 55000 ) { cBrefdesign = 0.82; };
                if ( deadweight > 55000 & deadweight < 75000 ) { cBrefdesign = 0.86; };
                if ( deadweight > 7500 ) { cBrefdesign = 0.86; };
            }

            if (shipType == "Tanker")
            {
                if (deadweight < 10000) { cBrefdesign = 0.78; };
                if (deadweight > 10000 & deadweight < 25000) { cBrefdesign = 0.80; };
                if (deadweight > 25000 & deadweight < 55000) { cBrefdesign = 0.80; };
                if (deadweight > 55000 & deadweight < 75000) { cBrefdesign = 0.83; };
                if (deadweight > 7500) { cBrefdesign = 0.83; };
            }

            if (shipType == "General cargo ship")
            {
                cBrefdesign = 0.80;
            }

            if (cBrefdesign / cB < 1)
            {
                fIcB = 1;
            }

            else 
            {
                fIcB = cBrefdesign / cB;
            }

            double fIice = fIiceClass * fIcB;

            if (iceClass == "N/A")
            {
                fIice = 1;
            }

            return fIice;

        }

    }

}
