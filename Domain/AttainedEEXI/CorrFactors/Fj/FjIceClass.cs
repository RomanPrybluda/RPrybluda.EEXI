using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.8.1 Power correction factor for ice-class ships fj

    public static class FjIceClass
    {
        public static double fJiceClass;
        public static double fJ0;
        public static double fJmin;

        public static double CalcFjICEclass(string shipType, double deadweight, string iceClass, double mcrME)
        {
            if (shipType == "Bulk carrier")
            {
                fJ0 = 17.207 * Math.Pow(deadweight, 0.5705) / mcrME;

                if (iceClass == "IA Super")
                { fJmin = 0.2515 * Math.Pow(deadweight, 0.0851); };

                if (iceClass == "IA")
                { fJmin = 0.3918 * Math.Pow(deadweight, 0.0556); };

                if (iceClass == "IB")
                { fJmin = 0.8075 * Math.Pow(deadweight, 0.0071); };

                if (iceClass == "IC")
                { fJmin = 0.8573 * Math.Pow(deadweight, 0.0087); };

            }

            if (shipType == "Tanker")
            {
                fJ0 = 17.444 * Math.Pow(deadweight, 0.5766) / mcrME;

                if (iceClass == "IA Super")
                { fJmin = 0.2488 * Math.Pow(deadweight, 0.0903); };

                if (iceClass == "IA")
                { fJmin = 0.4541 * Math.Pow(deadweight, 0.0524); };

                if (iceClass == "IB")
                { fJmin = 0.7783 * Math.Pow(deadweight, 0.0145); };

                if (iceClass == "IC")
                { fJmin = 0.8741 * Math.Pow(deadweight, 0.0079); };

            }

            if (shipType == "General cargo ship")
            {
                fJ0 = 1.974 * Math.Pow(deadweight, 0.7987) / mcrME;

                if (iceClass == "IA Super")
                { fJmin = 0.1381 * Math.Pow(deadweight, 0.1435); };

                if (iceClass == "IA")
                { fJmin = 0.1574 * Math.Pow(deadweight, 0.144); };

                if (iceClass == "IB")
                { fJmin = 0.3256 * Math.Pow(deadweight, 0.0922); };

                if (iceClass == "IC")
                { fJmin = 0.4966 * Math.Pow(deadweight, 0.0583); };
                 
            }

            if (shipType == "Refrigerated cargo carrier")
            {
                fJ0 = 5.598 * Math.Pow(deadweight, 0.696) / mcrME;

                if (iceClass == "IA Super")
                { fJmin = 0.5254 * Math.Pow(deadweight, 0.0357); };

                if (iceClass == "IA")
                { fJmin = 0.6325 * Math.Pow(deadweight, 0.0278); };

                if (iceClass == "IB")
                { fJmin = 0.7670 * Math.Pow(deadweight, 0.0159); };

                if (iceClass == "IC")
                { fJmin = 0.8918 * Math.Pow(deadweight, 0.0079); };

            }

            if (fJ0 > fJmin & fJ0 < 1)
            { 
                fJiceClass = fJ0; 
            }

            if (fJ0 < fJmin & fJmin < 1)
            { 
                fJiceClass = fJmin; 
            }

            if (fJ0 >= 1 & fJmin >= 1)
            { 
                fJiceClass = 1; 
            }

            if (iceClass == "N/A")
            {
                fJiceClass = 1;
            }

                return fJiceClass;

        }

    }

}   