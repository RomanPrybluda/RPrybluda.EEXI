using System;


namespace RPrybluda.EEXI.Domain
{
    public static class Pme
    {
        public static double pME;

        public static double CalcPme(double mcrME, double mcrMElim, double mcrPTO, double pAE)
        {
            {
                if (mcrPTO == 0 & 0.75 * mcrME < 0.83 * mcrMElim) // clause 1.1
                {
                    pME = 0.75 * mcrME;
                }
                else
                {
                    pME = 0.83 * mcrMElim;
                }

                if (mcrPTO > 0 & 0.75 * mcrPTO <= pAE) // clause 2.2.5.2 Option 1
                {
                    pME = 0.75 * mcrME - 0.75 * mcrPTO;
                }
                else
                {
                    pME = 0.75 * mcrME - pAE;
                }

                return pME;

            }
        }
    }
}
