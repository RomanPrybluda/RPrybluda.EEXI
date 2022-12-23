using System;


namespace RPrybluda.EEXI.Domain
{
    public class AttainedEEXI
    {
        public static double attEEXI;

        public static double CalcAttEEXI

        (double resultPme, double resultFactorCfME, double sfcME,
         double resultPae, double resultFactorCfAE, double sfcAE,
         
         double сapacity, double resultVrefapp,
         
         double fJiceClass, double resultFiCRS, double resultFi, 
         double resultFc, double resultFl, double resultFw, double resultFm)

        {
            double attEEXI = fJiceClass * (resultPme * resultFactorCfME * sfcME + resultPae * resultFactorCfAE * sfcAE) 
                / (resultFiCRS * resultFi * resultFc * resultFl * сapacity * resultFw * resultVrefapp * resultFm);

            return attEEXI;
        }
        
    }
}
