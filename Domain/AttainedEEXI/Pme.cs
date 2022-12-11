using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain.AttainedEEXI
{
    static class Pme
    {
        public static double resultPme;

        public static double CalcPme(double mcrME, double mcrMElim, double powerSG, double pAE)
        {
            {
                if (powerSG == 0 & 0.75 * mcrME < 0.83 * mcrMElim) // clause 1.1
                {
                    resultPme = 0.75 * mcrME;
                }
                else
                {
                    resultPme = 0.83 * mcrMElim;
                }

                if (powerSG > 0 & 0.75 * powerSG <= pAE) // clause 2.2.5.2 Option 1
                {
                    resultPme = 0.75 * mcrME - 0.75 * powerSG;
                }
                else
                {
                    resultPme = 0.75 * mcrME - pAE;
                }

                return resultPme;

            }
        }
    }
}
