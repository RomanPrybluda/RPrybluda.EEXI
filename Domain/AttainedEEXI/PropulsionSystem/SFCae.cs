using System;


namespace RPrybluda.EEXI.Domain
{

    public static class SFCae
    {

        public static double resultSFCae;

        public static double CalcSFCae(double sfcAE)
        {
            if (sfcAE == 0) resultSFCae = 215;
                       else resultSFCae = sfcAE; 
            
            return resultSFCae;

        }    
     }       
}            

            
            
                   
       
        

    

