using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.12.1  fc for chemical tankers
    // fcCT = R^(-0.7) ─ 0.014, where R is less than 0.98
    // or 
    // fc = 1.000, where R is 0.98 and above;
    // where: R is the capacity ratio of the deadweight of the ship (tonnes) as determined by
    // paragraph 2.2.4 divided by the total cubic capacity of the cargo tanks of the ship (m3). 

    public static class FcCT
    {
        public static double fcCT;

        public static double CalcFcCT(string shipType, double rCT)
        {
            if (shipType != "Tanker")
            {
                fcCT = 1;
            }

            if (shipType == "Tanker" & rCT == 0)
            {
                fcCT = 1;
            }

            if (shipType == "Tanker" & rCT > 0.98)
            {
                fcCT = 1;
            }

            if (shipType == "Tanker" & 0 > rCT & rCT < 0.98 )
            {
                fcCT = (Math.Pow(rCT, -0.7)) - 0.014;
            }
            
            return fcCT;
        }
    }
}
