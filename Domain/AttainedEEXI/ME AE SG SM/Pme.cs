using System;


namespace RPrybluda.EEXI.Domain
{
    public static class Pme
    {
        public static double resultPme;

        public static double CalcPme(double mcrME, double mcrMElim, double mcrPTO, double mcrPTI, double resultPae)
        {
            {
                if (mcrPTO == 0 & 0.75 * mcrME < 0.83 * mcrMElim) // clause 1.1
                {
                    resultPme = 0.75 * mcrME;
                }
                else
                {
                    resultPme = 0.83 * mcrMElim;
                }

                if (mcrPTO > 0 & 0.75 * mcrPTO <= resultPae) // clause 2.2.5.2 Option 1
                {
                    resultPme = 0.75 * mcrME - 0.75 * mcrPTO;
                }
                else
                {
                    resultPme = 0.75 * mcrME - resultPae;
                }

                return resultPme;

            }
        }
    }
}
