using System;


namespace RPrybluda.EEXI.Domain
{
    public static class Pae
    {
        public static double pAE;

        public static double CalcPae(double mcrME, double mcrPTI)
        {
            if (mcrME + mcrPTI / 0.75 < 10000) // < 10000 kW
            {
                pAE = 0.05 * (mcrME + mcrPTI / 0.75);
            }
            else // >= 10000 kW
            {
                pAE = 0.025 * (mcrME + mcrPTI / 0.75) + 250;
            }

            return pAE;
        }
    }
}
