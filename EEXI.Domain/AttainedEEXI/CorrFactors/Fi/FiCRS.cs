
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
        public static double deadweightCRS;
        public static double lwtCSR;

        public static double CalcFiCRS(double deadweight, double lwt, string shipUnderCSR)
        {
            if (shipUnderCSR == "1")
            {
                deadweightCRS = deadweight;
                lwtCSR = lwt;

                fIcrs = 1 + 0.08 * lwtCSR / deadweightCRS;
            }

            if (shipUnderCSR == "0")
            {
                fIcrs = 1;
            }

            return fIcrs;

        }
    }
}
