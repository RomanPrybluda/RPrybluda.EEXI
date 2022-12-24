using System;


namespace RPrybluda.EEXI.Domain
{
    public static class CfAE
    {
        public static double factorCfAE;

        public static double CalcFactorCfAE(string fluelTypeAE, double sfcAEin, double mcrPTO, double factorCfME)
        {
            if (sfcAEin == 0)
            {
                factorCfAE = Cf.HFO;
            }

            if (mcrPTO > 0)
            {
                factorCfAE = factorCfME;
            }

            if (fluelTypeAE == "Diesel / Gas oil")
            {
                factorCfAE = Cf.DO_GO;
            }

            if (fluelTypeAE == "Light fuel oil") 
            {
                factorCfAE = Cf.LFO;
            }

            if (fluelTypeAE == "Heavy fuel oil") 
            {
                factorCfAE = Cf.HFO;
            }

            if (fluelTypeAE == "Liquefied petroleum Gas (Propane)")
            {
                factorCfAE = Cf.LPG_PROPANE;
            }

            if (fluelTypeAE == "Liquefied petroleum Gas (Butane)") 
            {
                factorCfAE = Cf.LPG_BUTANE;
            }

            if (fluelTypeAE == "Liquefied natural gas") 
            {
                factorCfAE = Cf.LNG;
            }

            if (fluelTypeAE == "Methanol") 
            {
                factorCfAE = Cf.METHANOL;
            }

            if (fluelTypeAE == "Ethanol") 
            {
                factorCfAE = Cf.ETHANOL;
            }

            return factorCfAE;
        }
    }
}
