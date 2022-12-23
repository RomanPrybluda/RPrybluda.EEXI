using System;


namespace RPrybluda.EEXI.Domain
{

    public static class SFCae
    {

        public static double sfcAE;

        public static double CalcSFCae(double sfcAEin)
        {
            if (sfcAE == 0) sfcAE = SFCapp.SFCaeApp;
                       else sfcAE = sfcAEin; 
            
            return sfcAE;

        }    
     }       
}            

            
            
                   
       
        

    

