using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    // fi Capacity factor for technical/regulatory limitation on capacity
    // Capacity correction factor for ships under Common Structural Rules (CSR)

    public static class FiCRS
    {
        public static double resultFiCRS;

        public static double CalcFiCRS(double deadweightCRS, double lwtCSR) //  fi CRS (ice class)
        {
            if (deadweightCRS != 0 & lwtCSR != 0)
            {
                resultFiCRS = 1 + 0.08 * lwtCSR / deadweightCRS;
            }

            else
            {
                resultFiCRS = 1;
            }

            return resultFiCRS;

        }
    }
}