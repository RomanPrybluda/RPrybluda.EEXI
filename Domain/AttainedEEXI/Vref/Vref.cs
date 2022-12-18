using System;


namespace RPrybluda.EEXI.Domain
{
    public static class Vref
    {
        public static double resultVref;

        public static double CalcVref(double vREF, double resultVrefapp)
        {
            if (vREF == 0) { resultVref = resultVrefapp; }
                      else { resultVref = vREF; };
            
            return resultVref;
        }
    }
}