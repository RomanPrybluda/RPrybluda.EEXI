using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.12.4  fc for bulk carriers having R of less than 0.55 (fc bulk carriers designed to carry light cargoes) 
    // For bulk carriers having R of less than 0.55 (e.g. wood chip carriers), the following cubic
    // capacity correction factor, fc bulk carriers designed to carry light cargoes, should apply: 
    // fcR bulk carriers designed to carry light cargoes = R^(-0.15)
    // 

    public static class FcR
    {
        public static double fcR;

        public static double CalcFcR(string shipType, double rBulkCarrier)
        {

            if (shipType != "LNG carrier")
            {
                fcR = 1;
            }

            if (shipType == "LNG carrier" & rBulkCarrier == 0)
            {
                fcR = 1;
            }

            if (shipType == "LNG carrier" & rBulkCarrier > 0.55)
            {
                fcR = 1;
            }

            if (shipType == "LNG carrier" & 0 > rBulkCarrier & rBulkCarrier < 0.55)
            {
                fcR = (Math.Pow(rBulkCarrier, -0.56));
            }

            return fcR;
        }
    }
}
