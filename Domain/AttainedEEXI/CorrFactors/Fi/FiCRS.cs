
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.11.3  Ships under the Common Structural Rules (CSR) fIcsr

    public static class FiCRS
    {
        public static double fIcrs;

        public static double CalcFiCRS(double deadweightCRS, double lwtCSR)
        {
            if (deadweightCRS == 0 & lwtCSR == 0)
            {
                fIcrs = 1;
            }

            else
            {
                fIcrs = 1 + 0.08 * lwtCSR / deadweightCRS;
            }

            return fIcrs;

        }
    }
}
