using System;


namespace RPrybluda.EEXI.Domain
{
    public static class Pme
    {
        public static double pME;

        public static double CalcPme(double mcrME, double mcrMElim, double mcrPTO, double pPTO)
        {
            {
                if (mcrPTO == 0 & mcrMElim == 0) // clause 1.1
                {
                    pME = 0.75 * mcrME;
                }

                if (mcrPTO == 0 & mcrMElim != 0 & 0.83 * mcrMElim <= 0.75 * mcrME)
                {
                    pME = 0.83 * mcrMElim;
                }

                if (mcrPTO > 0 ) // clause 2.2.5.2 Option 1
                {
                    pME = 0.75 * ( mcrME - pPTO);
                }
                
                return pME;

            }
        }
    }
}
