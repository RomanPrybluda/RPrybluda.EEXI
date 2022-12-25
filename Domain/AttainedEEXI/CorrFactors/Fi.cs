using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{


    // 2.2.11 Capacity factor for technical/regulatory limitation on capacity
    
    public static class Fi
    {
        public static double fI;

        public static double CalcFi()
        {
            fI = FiIce.fIice * FiVSE.fIvse * FiCRS.fIcrs;
            return fI;
        }
    }

    // 2.2.11.1 Capacity correction factor for ice-classed ships fIice

    public static class FiIce
    {
        public static double fIice;
        public static double fIiceClass = 1;
        public static double fIiCb = 1;

        public static double CalcFiIce(string shipType, double deadweight, string iceClass)
        {
            double fIice = fIiceClass * fIiCb;
            return fIice;
        }

    }


    // 2.2.11.2  Ship specific voluntary structural enhancement  fIvse
    
    public static class FiVSE
    {
        public static double fIvse;

        public static double CalcFiVSE()
        {
            double fIvse = 1;
            return fIvse;
        }
    }


    // 2.2.11.3  Ships under the Common Structural Rules (CSR) fIcsr

    public static class FiCRS
    {
        public static double fIcrs;

        public static double CalcFiCRS(double deadweightCRS, double lwtCSR)
        {
            if (deadweightCRS != 0 & lwtCSR != 0)
            {
                fIcrs = 1 + 0.08 * lwtCSR / deadweightCRS;
            }

            else
            {
                fIcrs = 1;
            }

            return fIcrs;

        }
    }
}
