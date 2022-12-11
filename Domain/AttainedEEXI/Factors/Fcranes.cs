using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain.AttainedEEXI.Factors
{
    static class Fcranes
    {
        public static double resultFcranes;

        public static double CalcFcranes
            (double capacity,
             double swl01, double reach01, double swl02, double reach02,
             double swl03, double reach03, double swl04, double reach04) //  fcranes 

        {
            if (swl01 > 0 & reach01 > 0)
            {
                resultFcranes = 1 +
                  (0.0519 * swl01 * reach01 + 32.11
                + (0.0519 * swl02 * reach02 + 32.11)
                + (0.0519 * swl03 * reach03 + 32.11)
                + (0.0519 * swl04 * reach04 + 32.11)
                  ) / capacity;
            }

            else
            {
                resultFcranes = 1;
            }

            return resultFcranes;

        }
    }
}