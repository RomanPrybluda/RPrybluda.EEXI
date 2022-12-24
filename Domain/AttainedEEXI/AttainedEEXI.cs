using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace RPrybluda.EEXI.Domain
{
    public class AttainedEEXI
    {
        public static double attEEXI;

        public static double CalcAttEEXI

        (double pME, double factorCfME, double sfcME,
         double pAE, double factorCfAE, double sfcAE,
         
         double capacity, double vRef,
         
         double fJ, double fI, double fC, 
         double fL, double fW, double fM)

        {
            double attEEXI = ( fJ * (pME * factorCfME * sfcME) + (pAE * factorCfAE * sfcAE) ) / ( fI * fC * fL * capacity * fW * vRef * fM);

            return attEEXI;
        }
        
    }
}
