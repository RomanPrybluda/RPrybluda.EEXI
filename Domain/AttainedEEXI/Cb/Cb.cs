using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    public static class Cb
    {
        public static double cB;

        public static double CalcCb(double vDisplacement, double lPP, double bS, double dS)
        {

            cB = vDisplacement / (lPP * bS * dS);

            return cB;

        }
    }
}
