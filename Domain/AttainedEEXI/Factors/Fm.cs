using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain.AttainedEEXI.Factors
{
    static class Fm
    {
        public static double resultFm;

        public static double CalcFm(double iceClass) //  fm (ice class IA Super and IA)
        {
            if (iceClass == 1 || iceClass == 2)
            {
                resultFm = 1.05;
            }

            else
            {
                resultFm = 1;
            }

            return resultFm;

        }
    }
}
