using System;


namespace RPrybluda.EEXI.Domain
{
    public static class Vrefapp
    {
        public static double vRefApp;
        public static double vRefAvg;
        public static double mcrAvg;
        public static double mv;

        public static double CalcVrefapp(string shipType, double deadweight, double pME, double grossTonnage)
        {

            if (shipType == "Bulk carrier")  
            {
                vRefAvg = 10.6585 * Math.Pow(deadweight, 0.02706);
                mcrAvg = 23.751 * Math.Pow(deadweight, 0.54087);
            }

            if (shipType == "Gas carrier")
            {
                vRefAvg = 7.4462 * Math.Pow(deadweight, 0.07604);
                mcrAvg = 21.4704 * Math.Pow(deadweight, 0.59522);
            }

            if (shipType == "Tanker") 
            {
                vRefAvg = 8.1358 * Math.Pow(deadweight, 0.05383);
                mcrAvg = 22.8415 * Math.Pow(deadweight, 0.55826);
            }

            if (shipType == "Containership") 
            {
                vRefAvg = 3.2395 * Math.Pow(deadweight, 0.18294);
                mcrAvg = 0.5042 * Math.Pow(deadweight, 1.03046);
            }

            if (shipType == "General cargo ship") 
            {
                vRefAvg = 2.4538 * Math.Pow(deadweight, 0.18832);
                mcrAvg = 0.8816 * Math.Pow(deadweight, 0.9205);
            }

            if (shipType == "Refrigerated cargo carrier") 
            {
                vRefAvg = 1.0600 * Math.Pow(deadweight, 0.31518);
                mcrAvg = 0.0272 * Math.Pow(deadweight, 1.38634);
            }

            if (shipType == "Combination carrier") 
            {
                vRefAvg = 8.1391 * Math.Pow(deadweight, 0.05378);
                mcrAvg = 22.8536 * Math.Pow(deadweight, 0.55820);
            }
            
            if (shipType == "LNG carrier") 
            {
                vRefAvg = 11.0536 * Math.Pow(deadweight, 0.05030);
                mcrAvg = 20.7096 * Math.Pow(deadweight, 0.63477);
            }            
            
            if (shipType == "Ro-ro cargo ship (vehicle carrier)") 
            {
                vRefAvg = 16.6773 * Math.Pow(deadweight, 0.01802);
                mcrAvg = 262.7693 * Math.Pow(deadweight, 0.39973);
            }
                        
            if (shipType == "Ro-ro cargo ship") 
            {
                vRefAvg = 8.0793 * Math.Pow(deadweight, 0.09123);
                mcrAvg = 37.7708 * Math.Pow(deadweight, 0.63450);
            }
                                    
            if (shipType == "Ro-ro passenger ship") 
            {
                vRefAvg = 4.1140 * Math.Pow(deadweight, 0.19863);
                mcrAvg = 9.1338 * Math.Pow(deadweight, 0.91116);
            }
                                                
            if (shipType == "Cruise passenger ship having non-conventional propulsion") 
            {
                vRefAvg = 5.1240 * Math.Pow(grossTonnage, 0.12714);
                mcrAvg = 1.3550 * Math.Pow(grossTonnage, 0.88664);
            }

            if (vRefAvg * 0.05 < 1)
            {
                mv = vRefAvg * 0.05;
            }
            else
            {
                mv = 1;
            }

            vRefApp = (vRefAvg - mv) * Math.Pow (pME / (0.75 * mcrAvg ), 0.333333);

            return vRefApp;
        }

    }
}