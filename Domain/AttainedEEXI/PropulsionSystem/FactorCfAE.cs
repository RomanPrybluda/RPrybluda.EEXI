using System;


namespace RPrybluda.EEXI.Domain
{
    public static class FactorCfAE
    {
        public static double resultFactorCfAE;

        public static double CalcFactorCfAE(double fluelTypeAE)
        {
            if (fluelTypeAE == 1) // Diesel / Gas oil
            {
                resultFactorCfAE = 3.203;
            }

            if (fluelTypeAE == 2) // Light fuel oil
            {
                resultFactorCfAE = 3.151;
            }

            if (fluelTypeAE == 3) // Heavy fuel oil
            {
                resultFactorCfAE = 3.114;
            }

            if (fluelTypeAE == 4) // Liquefied petroleum Gas (Propane)
            {
                resultFactorCfAE = 3.000;
            }

            if (fluelTypeAE == 5) // Liquefied petroleum Gas (Butane)
            {
                resultFactorCfAE = 3.030;
            }

            if (fluelTypeAE == 6) // Liquefied natural gas
            {
                resultFactorCfAE = 2.750;
            }

            if (fluelTypeAE == 7) // Methanol
            {
                resultFactorCfAE = 1.375;
            }

            if (fluelTypeAE == 8) // Ethanol
            {
                resultFactorCfAE = 1.913;
            }

            return resultFactorCfAE;
        }
    }
}
