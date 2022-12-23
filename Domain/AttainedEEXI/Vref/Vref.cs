using System;


namespace RPrybluda.EEXI.Domain
{
    public static class Vref
    {
        public static double vRef;

        public static double CalcVref(double vRefS, double vRefApp)
        {
            if (vRef == 0) { vRef = vRefApp; }
                      else { vRef = vRefS; };
            
            return vRef;
        }

    }
}