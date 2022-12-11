using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain.AttainedEEXI.Factors
{
    static class FjICEclass
    {
        public static double resultFjICEclass;
        public static double fJ0;
        public static double fJmin;
        public static double fJmax = 1;

        public static double CalcFjICEclass(double shipType, double deadweight, double iceClass, double mcrME) //  fj (ice class)
        {
            if (shipType == 1) // Bulk carrier
            {
                fJ0 = 17.207 * Math.Pow(deadweight, 0.5705) / mcrME;

                if (iceClass == 1)
                { fJmin = 0.2515 * Math.Pow(deadweight, 0.0851); };

                if (iceClass == 2)
                { fJmin = 0.3918 * Math.Pow(deadweight, 0.0556); };

                if (iceClass == 3)
                { fJmin = 0.8075 * Math.Pow(deadweight, 0.0071); };

                if (iceClass == 4)
                { fJmin = 0.8573 * Math.Pow(deadweight, 0.0087); };

                if (fJ0 > fJmin & fJ0 < fJmax)
                { resultFjICEclass = fJ0; }

                if (fJ0 < fJmin & fJmin < fJmax)
                { resultFjICEclass = fJmin; }

                else
                { resultFjICEclass = fJmax; }

            }

            if (shipType == 3) // Tanker
            {
                fJ0 = 17.444 * Math.Pow(deadweight, 0.5766) / mcrME;

                if (iceClass == 1)
                { fJmin = 0.2488 * Math.Pow(deadweight, 0.0903); };

                if (iceClass == 2)
                { fJmin = 0.4541 * Math.Pow(deadweight, 0.0524); };

                if (iceClass == 3)
                { fJmin = 0.7783 * Math.Pow(deadweight, 0.0145); };

                if (iceClass == 4)
                { fJmin = 0.8741 * Math.Pow(deadweight, 0.0079); };

                if (fJ0 > fJmin & fJ0 < fJmax)
                { resultFjICEclass = fJ0; }

                if (fJ0 < fJmin & fJmin < fJmax)
                { resultFjICEclass = fJmin; }

                else
                { resultFjICEclass = fJmax; }

            }

            if (shipType == 5) // General cargo ship
            {
                fJ0 = 1.974 * Math.Pow(deadweight, 0.7987) / mcrME;

                if (iceClass == 1)
                { fJmin = 0.1381 * Math.Pow(deadweight, 0.1435); };

                if (iceClass == 2)
                { fJmin = 0.1574 * Math.Pow(deadweight, 0.144); };

                if (iceClass == 3)
                { fJmin = 0.3256 * Math.Pow(deadweight, 0.0922); };

                if (iceClass == 4)
                { fJmin = 0.4966 * Math.Pow(deadweight, 0.0583); };

                if (fJ0 > fJmin & fJ0 < fJmax)
                { resultFjICEclass = fJ0; }

                if (fJ0 < fJmin & fJmin < fJmax)
                { resultFjICEclass = fJmin; }

                else
                { resultFjICEclass = fJmax; }

            }

            if (shipType == 6) // Refrigerated cargo carrier
            {
                fJ0 = 5.598 * Math.Pow(deadweight, 0.696) / mcrME;

                if (iceClass == 1)
                { fJmin = 0.5254 * Math.Pow(deadweight, 0.0357); };

                if (iceClass == 2)
                { fJmin = 0.6325 * Math.Pow(deadweight, 0.0278); };

                if (iceClass == 3)
                { fJmin = 0.7670 * Math.Pow(deadweight, 0.0159); };

                if (iceClass == 4)
                { fJmin = 0.8918 * Math.Pow(deadweight, 0.0079); };

                if (fJ0 > fJmin & fJ0 < fJmax)
                { resultFjICEclass = fJ0; }

                if (fJ0 < fJmin & fJmin < fJmax)
                { resultFjICEclass = fJmin; }

                else
                { resultFjICEclass = fJmax; }

            }

            else
            {
                resultFjICEclass = 1;
            }

            return resultFjICEclass;

        }

    }
}
