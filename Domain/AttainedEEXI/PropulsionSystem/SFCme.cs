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

        public static double CalcSFCme(double sfcMEin)
        {
            if (sfcME == 0) 
            {
               sfcME = SFCapp.SFCmeApp;
            }

            if (sfcME > 0)
            {
                sfcME = sfcMEin;
            }

            return sfcME;

        }    
     }       
}            

            
            
                   
       
        

    

