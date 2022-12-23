using System;


namespace RPrybluda.EEXI.Domain
{
    public static class FactorCfAE
    {
        public static double factorCfAE;

        public static double CalcFactorCfAE(string fluelTypeAE)
        {
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
