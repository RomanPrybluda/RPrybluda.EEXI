using System;


namespace RPrybluda.EEXI.Domain
{
    public static class CfME
    {
        public static double factorCfME;

        public static double CalcFactorCfME(string fluelTypeME, double sfcMEin)
        {
            if ( sfcMEin == 0 )
            {
                factorCfME = Cf.HFO;
            }

            if (fluelTypeME == "Diesel / Gas oil") 
            {
                factorCfME = Cf.DO_GO;
            }

            if (fluelTypeME == "Light fuel oil") 
            {
                factorCfME = Cf.LFO;
            }

            if (fluelTypeME == "Heavy fuel oil") 
            {
                factorCfME = Cf.HFO;
            }

            if (fluelTypeME == "Liquefied petroleum Gas (Propane)") 
            {
                factorCfME = Cf.LPG_PROPANE;
            }

            if (fluelTypeME == "Liquefied petroleum Gas (Butane)") 
            {
                factorCfME = Cf.LPG_BUTANE;
            }

            if (fluelTypeME == "Liquefied natural gas") 
            {
                factorCfME = Cf.LNG;
            }

            if (fluelTypeME == "Methanol") 
            {
                factorCfME = Cf.METHANOL;
            }

            if (fluelTypeME == "Ethanol") 
            {
                factorCfME = Cf.ETHANOL;
            }

            return factorCfME;
        }
    }
}
