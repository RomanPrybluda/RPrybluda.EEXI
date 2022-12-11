using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain.AttainedEEXI
{
    static class Vrefapp
    {
        public static double resultVrefapp;
        public static double vREFavg;
        public static double mcravg;
        public static double mv;

        public static double CalcVrefapp(double shipType, double deadweight, double pME)
        {

            if (shipType == 1) // Bulk carrier
            {
                vREFavg = 10.6585 * Math.Pow(deadweight, 0.02706);
                mcravg = 23.751 * Math.Pow(deadweight, 0.54087);
            }

            if (shipType == 2) // Gas carrier
            {
                vREFavg = 7.4462 * Math.Pow(deadweight, 0.07604);
                mcravg = 21.4704 * Math.Pow(deadweight, 0.59522);
            }

            if (shipType == 3) // Tanker
            {
                vREFavg = 8.1358 * Math.Pow(deadweight, 0.05383);
                mcravg = 22.8415 * Math.Pow(deadweight, 0.55826);
            }

            if (shipType == 4) // Containership
            {
                vREFavg = 3.2395 * Math.Pow(deadweight, 0.18294);
                mcravg = 0.5042 * Math.Pow(deadweight, 1.03046);
            }

            if (shipType == 5) // General cargo ship
            {
                vREFavg = 2.4538 * Math.Pow(deadweight, 0.18832);
                mcravg = 0.8816 * Math.Pow(deadweight, 0.9205);
            }

            if (shipType == 6) // Refrigerated cargo carrier
            {
                vREFavg = 1.0600 * Math.Pow(deadweight, 0.31518);
                mcravg = 0.0272 * Math.Pow(deadweight, 1.38634);
            }

            if (shipType == 7) // Combination carrier
            {
                vREFavg = 8.1391 * Math.Pow(deadweight, 0.05378);
                mcravg = 22.8536 * Math.Pow(deadweight, 0.55820);
            }

            if (shipType == 8) // LNG carrier
            {
                vREFavg = 11.0536 * Math.Pow(deadweight, 0.0503);
                mcravg = 20.7096 * Math.Pow(deadweight, 0.63477);
            }

            if (vREFavg * 0.05 < 1)
            {
                mv = vREFavg * 0.05;
            }
            else
            {
                mv = 1;
            }

            resultVrefapp = (vREFavg - mv) * Math.Pow(pME / (0.75 * mcravg), 1 / 3);

            return resultVrefapp;
        }

    }
}