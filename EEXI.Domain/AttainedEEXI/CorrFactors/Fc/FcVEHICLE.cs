using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    // 2.2.7 Cubic capacity correction factor for ro-ro cargo ships (vehicle carrier) (fcVEHICLE) (Resolution MEPC.350(78))
    // For ro-ro cargo ships (vehicle carrier) having a DWT/GT ratio of less than 0.35, the following cubic capacity correction factor, fcVEHICLE, should apply:
    // 𝑓𝑐𝑉𝐸𝐻𝐼𝐶𝐿𝐸 = ( (𝐷𝑊𝑇⁄𝐺𝑇)/0.35)^(-0.8)
    // Where DWT is the capacity and GT is the gross tonnage in accordance with the International Convention of Tonnage Measurement of Ships 1969, annex I, regulation 3.

    public static class FcVEHICLE
    {
        public static double fcVEHICLE;

        public static double CalcFcVEHICLE(string shipType, double deadweight, double grossTonnage)
        {
                        
            if (shipType == "Ro-ro passenger ship" & deadweight / grossTonnage < 0.35)
            {
                fcVEHICLE = Math.Pow(((deadweight / grossTonnage) / 0.35), -0.8);
            }

            if (shipType != "Ro-ro passenger ship")
            {
                fcVEHICLE = 1;
            }
            
            return fcVEHICLE;
        }
    }
}
