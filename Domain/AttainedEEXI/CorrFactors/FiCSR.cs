using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    // fi Capacity factor for technical/regulatory limitation on capacity
    // Capacity correction factor fiCRSf or ships under Common Structural Rules (CSR)

    public static class FiCRS
    {
        public static double fICRS;

        public static double CalcFiCRS(double deadweightCRS, double lwtCSR) 
        {
            if (deadweightCRS != 0 & lwtCSR != 0)
            {
                fICRS = 1 + 0.08 * lwtCSR / deadweightCRS;
            }

            else
            {
                fICRS = 1;
            }

            return fICRS;

        }
    }
}