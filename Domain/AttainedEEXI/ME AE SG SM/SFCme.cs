using System;


namespace RPrybluda.EEXI.Domain
{

    public static class SFCme
    {

        public static double resultSFCme;

        public static double CalcSFCme(double sfcME)
        {
            if (sfcME == 0) resultSFCme = 190;
                       else resultSFCme = sfcME; 
            
            return resultSFCme;

        }    
     }       
}            

            
            
                   
       
        

    

