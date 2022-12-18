using System;


namespace RPrybluda.EEXI.Domain
{
    public static class Pae
    {
        public static double resultPae;

        public static double CalcPae(double mcrME, double mcrPTI) // MRCme Ppti
        {
            if (mcrME + mcrPTI / 0.75 < 10000) // < 10000 kW
            {
                resultPae = 0.05 * (mcrME + mcrPTI / 0.75);
            }
            else // >= 10000 kW
            {
                resultPae = 0.025 * (mcrME + mcrPTI / 0.75) + 250;
            }

            return resultPae;
        }
    }
}
