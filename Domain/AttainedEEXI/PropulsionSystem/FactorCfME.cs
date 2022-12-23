using System;


namespace RPrybluda.EEXI.Domain
{
    public static class FactorCfME
    {
        public static double resultFactorCfME;

        public static double CalcFactorCfME(double fluelTypeME)
        {
            if (fluelTypeME == 1) // Diesel / Gas oil
            {
                resultFactorCfME = 3.203;
            }

            if (fluelTypeME == 2) // Light fuel oil
            {
                resultFactorCfME = 3.151;
            }

            if (fluelTypeME == 3) // Heavy fuel oil
            {
                resultFactorCfME = 3.114;
            }

            if (fluelTypeME == 4) // Liquefied petroleum Gas (Propane)
            {
                resultFactorCfME = 3.000;
            }

            if (fluelTypeME == 5) // Liquefied petroleum Gas (Butane)
            {
                resultFactorCfME = 3.030;
            }

            if (fluelTypeME == 6) // Liquefied natural gas
            {
                resultFactorCfME = 2.750;
            }

            if (fluelTypeME == 7) // Methanol
            {
                resultFactorCfME = 1.375;
            }

            if (fluelTypeME == 8) // Ethanol
            {
                resultFactorCfME = 1.913;
            }

            return resultFactorCfME;
        }
    }
}
