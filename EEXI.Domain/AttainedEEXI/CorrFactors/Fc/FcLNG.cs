using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    // 2.2.12.2  fc for gas carriers 
    // fcLNG = R^(-0.56) 

    public static class FcLNG
    {
        public static double fcLNG;

        public static double CalcFcLNG(string shipType, double rLNG)
        {
            if (shipType != "LNG carrier")
            {
                fcLNG = 1;
            }

            if (shipType == "LNG carrier" & rLNG == 0)
            {
                fcLNG = 1;
            }

            if (shipType == "LNG carrier" & rLNG != 0)
            {
                fcLNG = (Math.Pow(rLNG, -0.56));
            }

            return fcLNG;
        }
    }
}
