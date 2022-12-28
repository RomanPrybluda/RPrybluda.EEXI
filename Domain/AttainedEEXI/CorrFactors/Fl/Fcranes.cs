using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // Factor for general cargo ships equipped with cranes

    public static class Fcranes
    {
        public static double fCranes;

        public static double CalcFcranes(double swl01, double swl02, double swl03, double swl04,
                    double reach01, double reach02, double reach03, double reach04, double capacity)
        {
            
            if (swl01 == 0)
            {
                fCranes = 1;
            }

            else
            {
                fCranes = 1 + ((0.0519 * swl01 * reach01 + 32.11)
                               +  (0.0519 * swl02 * reach02 + 32.11)
                               +  (0.0519 * swl03 * reach03 + 32.11)
                               +  (0.0519 * swl04 * reach04 + 32.11))
                               / capacity;
            }

            return fCranes;

        }

    }

}