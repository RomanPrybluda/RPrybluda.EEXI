using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace RPrybluda.EEXI.Domain
{

    public static class SFCme
    {

        public static double sfcME;

        public static double CalcSFCme(double sfcMEin75, double sfcMEin50, double mcrME, double mcrMElim)
        {
            if (sfcME == 0) 
            {
               sfcME = SFCapp.SFCmeApp;
            }

            if (sfcME > 0 & mcrMElim == 0)
            {
                sfcME = sfcMEin75;
            }

            if (sfcME > 0 & 0.83 * mcrMElim < 0.75 * mcrME)
            {
                sfcME = sfcMEin75 + (sfcMEin50 - sfcMEin75) * (0.83 * mcrMElim - 0.75 * mcrME) / (0.5 * mcrME - 0.75 * mcrME);
            }

            return sfcME;

        }    
     }       
}            

            
            
                   
       
        

    

