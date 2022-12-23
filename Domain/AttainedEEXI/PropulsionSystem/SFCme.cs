using System;


namespace RPrybluda.EEXI.Domain
{

    public static class SFCme
    {

        public static double sfcME;

        public static double CalcSFCme(double sfcMEin)
        {
            if (sfcME == 0) sfcME = SFCapp.SFCmeApp;
                       else sfcME = sfcMEin; 
            
            return sfcME;

        }    
     }       
}            

            
            
                   
       
        

    

