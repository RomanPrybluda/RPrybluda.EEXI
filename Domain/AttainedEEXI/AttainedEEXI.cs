using System;


namespace RPrybluda.EEXI.Domain
{
    public class AttainedEEXI
    {
        public static double attEEXI;

        public static double CalcAttEEXI

        (double resultPme, double resultFactorCfME, double sfcME,
         double resultPae, double resultFactorCfAE, double sfcAE,
         
         double resultCapacity, double resultVrefapp,
         
         double resultFjICEclass, double resultFiCRS, double resultFi, 
         double resultFc, double resultFl, double resultFw, double resultFm)

        {
            double attEEXI = resultFjICEclass * (resultPme * resultFactorCfME * sfcME + resultPae * resultFactorCfAE * sfcAE) 
                / (resultFiCRS * resultFi * resultFc * resultFl * resultCapacity * resultFw * resultVrefapp * resultFm);

            return attEEXI;
        }
        
    }
}
