using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain.RequiredEEXI
{
    static class RefLineValueEEDI
    {
        public static double resultRefLineValueEEDI;

        public static double CalcRefLineValueEEDI(double shipType, double deadweight)
        {
            if (shipType == 1 & deadweight <= 279000) // Bulk carrier
            {
                resultRefLineValueEEDI = 961.79 * Math.Pow(deadweight, -0.477);
            }

            else if (shipType == 1 & deadweight > 279000) // Bulk carrier
            {
                resultRefLineValueEEDI = 961.79 * Math.Pow(279000, -0.477);
            }

            else if (shipType == 2) // Gas carrier
            {
                resultRefLineValueEEDI = 1120.00 * Math.Pow(deadweight, -0.456);
            }

            else if (shipType == 3) // Tanker
            {
                resultRefLineValueEEDI = 1218.80 * Math.Pow(deadweight, -0.488);
            }

            else if (shipType == 4)  // Containership
            {
                resultRefLineValueEEDI = 174.22 * Math.Pow(deadweight, -0.201);
            }

            else if (shipType == 5) // General cargo ship
            {
                resultRefLineValueEEDI = 107.48 * Math.Pow(deadweight, -0.216);
            }

            else if (shipType == 6)  // Refrigerated cargo carrier
            {
                resultRefLineValueEEDI = 227.01 * Math.Pow(deadweight, -0.244);
            }

            else if (shipType == 7) // Combination carrier
            {
                resultRefLineValueEEDI = 1219.00 * Math.Pow(deadweight, -0.488);
            }

            else if (shipType == 8) // LNG carrier
            {
                resultRefLineValueEEDI = 2253.7 * Math.Pow(deadweight, -0.474);
            }

            return resultRefLineValueEEDI;
        }

    }
}
