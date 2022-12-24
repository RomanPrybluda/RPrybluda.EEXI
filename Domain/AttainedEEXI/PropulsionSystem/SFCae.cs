using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace RPrybluda.EEXI.Domain
{

    public static class SFCae
    {

        public static double sfcAE;

        public static double CalcSFCae(double sfcAEin, double mcrPTO, double sfcME)
        {
            if (sfcAE == 0)
            { 
                sfcAE = SFCapp.SFCaeApp; 
            }

            if (sfcAE > 0)
            {
                sfcAE = sfcAEin;
            }

            if (mcrPTO > 0)
            {
                sfcAE = sfcME;
            }


            return sfcAE;

        }    
     }       
}            

            
            
                   
       
        

    

