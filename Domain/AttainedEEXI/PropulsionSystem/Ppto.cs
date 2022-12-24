using System;


namespace RPrybluda.EEXI.Domain
{
    public static class Ppto
    {
        public static double pPTO;

        public static double CalcPpto(double mcrPTO, double pAE)
        {
            
            if (0.75 * mcrPTO <= pAE )
            {
                pPTO = 0.75 * mcrPTO;
            }
            
            else
            {
                pPTO = pAE / 0.75;
            }

            return pPTO;
            
        }
    }
}
