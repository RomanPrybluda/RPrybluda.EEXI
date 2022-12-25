using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.8 Ship specific design elements:

    public static class Fj
    {
        public static double fJ;

        public static double CalcFj()
        {

            fJ = FjIceClass.fJiceClass * FjRoRo.fJRoRo * FjGeneralCargo.fJGeneralCargo;

            return fJ;
        }

    }


    // 2.2.8.1 Power correction factor for ice-class ships fj

    public static class FjIceClass
    {
        public static double fJiceClass;
        public static double fJ0;
        public static double fJmin;
        public static double fJmax = 1;

        public static double CalcFjICEclass(string shipType, double deadweight, string iceClass, double mcrME)
        {
            if (shipType == "Bulk carrier")
            {
                fJ0 = 17.207 * Math.Pow(deadweight, 0.5705) / mcrME;

                if (iceClass == "IA Super")
                { fJmin = 0.2515 * Math.Pow(deadweight, 0.0851); };

                if (iceClass == "IA")
                { fJmin = 0.3918 * Math.Pow(deadweight, 0.0556); };

                if (iceClass == "IB")
                { fJmin = 0.8075 * Math.Pow(deadweight, 0.0071); };

                if (iceClass == "IC")
                { fJmin = 0.8573 * Math.Pow(deadweight, 0.0087); };

                if (fJ0 > fJmin & fJ0 < fJmax)
                { fJiceClass = fJ0; }

                if (fJ0 < fJmin & fJmin < fJmax)
                { fJiceClass = fJmin; }

                else
                { fJiceClass = fJmax; }

            }

            if (shipType == "Tanker")
            {
                fJ0 = 17.444 * Math.Pow(deadweight, 0.5766) / mcrME;

                if (iceClass == "IA Super")
                { fJmin = 0.2488 * Math.Pow(deadweight, 0.0903); };

                if (iceClass == "IA")
                { fJmin = 0.4541 * Math.Pow(deadweight, 0.0524); };

                if (iceClass == "IB")
                { fJmin = 0.7783 * Math.Pow(deadweight, 0.0145); };

                if (iceClass == "IC")
                { fJmin = 0.8741 * Math.Pow(deadweight, 0.0079); };

                if (fJ0 > fJmin & fJ0 < fJmax)
                { fJiceClass = fJ0; }

                if (fJ0 < fJmin & fJmin < fJmax)
                { fJiceClass = fJmin; }

                else
                { fJiceClass = fJmax; }

            }

            if (shipType == "General cargo ship")
            {
                fJ0 = 1.974 * Math.Pow(deadweight, 0.7987) / mcrME;

                if (iceClass == "IA Super")
                { fJmin = 0.1381 * Math.Pow(deadweight, 0.1435); };

                if (iceClass == "IA")
                { fJmin = 0.1574 * Math.Pow(deadweight, 0.144); };

                if (iceClass == "IB")
                { fJmin = 0.3256 * Math.Pow(deadweight, 0.0922); };

                if (iceClass == "IC")
                { fJmin = 0.4966 * Math.Pow(deadweight, 0.0583); };

                if (fJ0 > fJmin & fJ0 < fJmax)
                { fJiceClass = fJ0; }

                if (fJ0 < fJmin & fJmin < fJmax)
                { fJiceClass = fJmin; }

                else
                { fJiceClass = fJmax; }

            }

            if (shipType == "Refrigerated cargo carrier")
            {
                fJ0 = 5.598 * Math.Pow(deadweight, 0.696) / mcrME;

                if (iceClass == "IA Super")
                { fJmin = 0.5254 * Math.Pow(deadweight, 0.0357); };

                if (iceClass == "IA")
                { fJmin = 0.6325 * Math.Pow(deadweight, 0.0278); };

                if (iceClass == "IB")
                { fJmin = 0.7670 * Math.Pow(deadweight, 0.0159); };

                if (iceClass == "IC")
                { fJmin = 0.8918 * Math.Pow(deadweight, 0.0079); };

                if (fJ0 > fJmin & fJ0 < fJmax)
                { fJiceClass = fJ0; }

                if (fJ0 < fJmin & fJmin < fJmax)
                { fJiceClass = fJmin; }

                else
                { fJiceClass = fJmax; }

            }

            else
            {
                fJiceClass = 1;
            }

            return fJiceClass;

        }

    }


    // 2.2.8.3 Correction factor for ro-ro cargo and ro-ro passenger ships fjroro

    public static class FjRoRo
    {
        public static double fJRoRo;
        public static double maxfJRoRo = 1;
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

            fNl = 0.5144 * vRef / ( Math.Sqrt(9.81 * Math.Pow(vDisplacement, 0.333333))); 
            double vDisplacement033 = Math.Pow(vDisplacement, 0.333);


            if (shipType == "Ro-ro cargo ship")
            {
                fJRoRo = 1 / (Math.Pow(fNl, alphaCargo) * Math.Pow(lPP / bS, bettaCargo) * Math.Pow(bS / dS, gammaCargo) * Math.Pow(lPP / vDisplacement033, sigmaCargo));
            }

            if (shipType == "Ro-ro passenger ship")
            {
                fJRoRo = 1 / (Math.Pow(fNl, alphaPass) * Math.Pow(lPP / bS, bettaPass) * Math.Pow(bS / dS, gammaPass) * Math.Pow(lPP / vDisplacement033, sigmaPass)); ;
            }
            
            if (fJRoRo > maxfJRoRo)

            {
                fJRoRo = maxfJRoRo;
            }

            else
            {
                fJRoRo = 1;
            }

            return fJRoRo;

        }
    }


    // 2.2.8.4 Correction factor for general cargo ships fjgenaralcargo

    public static class FjGeneralCargo
    {
        public static double fJGeneralCargo;
        public static double maxfJGeneralCargo = 1;
        public static double cB;
        public static double maxfNv = 0.6;
        public static double fNv;

        public static double CalcFjGeneralCargo(string shipType, double vDisplacement, double lPP, double bS, double dS, double vRef)
        {

            if (shipType == "General cargo ship")
            {
                cB = vDisplacement / (lPP* bS * dS);
                fNv = 0.5144 * vRef / Math.Sqrt( 9.81 * Math.Pow(vDisplacement, 0.333333));
            
                if (fNv > maxfNv) 
                { 
                    fNv = maxfNv;
                }

                else 
                { 
                    fNv = 0.5144 * vRef / Math.Sqrt(9.81 * Math.Pow(vDisplacement, 0.333333));
                }

                fJGeneralCargo = 0.174 / (Math.Pow(fNv, 2.3) * Math.Pow( cB, 0.3));

                if (fJGeneralCargo > maxfJGeneralCargo)
                {

                    fJGeneralCargo = maxfJGeneralCargo; 
                }
           
            }
            

            else 
            { 
                fJGeneralCargo = 1;
            }

            return fJGeneralCargo;

        }
    }
}   