using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    public class RequiredEEXI
    {

        static public double reqEEXI;

        public static double CalcReqEEXI(double refLineValueEEDI, double reductFactor)

        {
            reqEEXI = (1 - reductFactor / 100) * refLineValueEEDI;

            return reqEEXI;
        }
 
    }
}
