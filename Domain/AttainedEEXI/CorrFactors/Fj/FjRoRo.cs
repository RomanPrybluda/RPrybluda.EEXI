using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.8.3 Correction factor for ro-ro cargo and ro-ro passenger ships fjroro

    public static class FjRoRo
    {
        public static double fJRoRo;
        public static double fNl;

        public static double alphaCargo = 2.00;
        public static double bettaCargo = 0.50;
        public static double gammaCargo = 0.75;
        public static double sigmaCargo = 1.00;
        public static double alphaPass = 2.50;
        public static double bettaPass = 0.75;
        public static double gammaPass = 0.75;
        public static double sigmaPass = 1.00;
        
        public static double CalcFjRoRo(string shipType, double vDisplacement, double lPP, double bS, double dS, double vRef)
        {

            fNl = 0.5144 * vRef / ( Math.Sqrt(lPP * 9.81)); 
            double vDisplacement033 = Math.Pow(vDisplacement, 0.333);


            if (shipType == "Ro-ro cargo ship")
            {
                fJRoRo = 1 / ( Math.Pow(fNl, alphaCargo) * Math.Pow(lPP / bS, bettaCargo) * Math.Pow(bS / dS, gammaCargo) * Math.Pow(lPP / vDisplacement033, sigmaCargo) );
            }

            if (shipType == "Ro-ro passenger ship")
            {
                fJRoRo = 1 / ( Math.Pow(fNl, alphaPass) * Math.Pow(lPP / bS, bettaPass) * Math.Pow(bS / dS, gammaPass) * Math.Pow(lPP / vDisplacement033, sigmaPass) );
            }
            
            if (fJRoRo > 1)

            {
                fJRoRo = 1;
            }

            if (shipType != "Ro-ro cargo ship" & shipType != "Ro-ro passenger ship")
            {
                fJRoRo = 1;
            }

            return fJRoRo;

        }
    
    }
    
}   