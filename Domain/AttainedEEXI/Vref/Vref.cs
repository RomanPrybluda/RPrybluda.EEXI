using System;


namespace RPrybluda.EEXI.Domain
{
    public static class Vref
    {
        public static double vRef;

        public static double CalcVref(double vRefIn, double vRefApp)
        {
            if (vRefIn == 0) 
            { 
                vRef = vRefApp; 
            }

            if (vRefIn > 0)
            { 
                vRef = vRefIn; 
            };
            
            return vRef;
        }

    }
}