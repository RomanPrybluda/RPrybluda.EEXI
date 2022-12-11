using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain.AttainedEEXI
{
    static class Pae
    {
        public static double resultPae;

        public static double CalcPae(double mcrME, double powerSM) // MRCme Ppti
        {
            if (mcrME + powerSM / 0.75 < 10000) // < 10000 kW
            {
                resultPae = 0.05 * (mcrME + powerSM / 0.75);
            }
            else // >= 10000 kW
            {
                resultPae = 0.025 * (mcrME + powerSM / 0.75) + 250;
            }

            return resultPae;
        }
    }
}
