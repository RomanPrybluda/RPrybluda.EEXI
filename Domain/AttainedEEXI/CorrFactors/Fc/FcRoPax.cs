using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.12.3  fc for ro-ro passenger ships (fcRoPax)
    // 𝑓𝑐𝑅𝑜𝑃𝑎𝑥 = ( (DWT/GT) / 0.25 )^(-0.8)

    public static class FcRoPax
    {
        public static double fcRoPax;

        public static double CalcFcRoPax(string shipType, double deadweight, double grossTonnage)
        {

            if ( shipType == "Ro-ro passenger ship" & deadweight / grossTonnage < 0.25)
            {
                fcRoPax = Math.Pow(((deadweight / grossTonnage) / 0.25), -0.8);
            }

            if (shipType != "Ro-ro passenger ship")
            {
                fcRoPax = 1;
            }

            return fcRoPax;
        }
    }
}
