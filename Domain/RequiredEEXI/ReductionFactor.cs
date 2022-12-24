using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    public class ReductionFactor
    {

        static public double reductFactor;

        public static double CalcReductFactor(string shipType, double deadweight, double grossTonnage)
        {

            if (shipType == "Bulk carrier")
            {
                if (deadweight <= 10000)
                { reductFactor = 0; };

                if (deadweight > 10000 & deadweight < 20000)
                { reductFactor = 0 + (20 - 0) * (deadweight - 10000) / (20000 - 10000); };

                if (deadweight >= 20000 & deadweight < 200000)
                { reductFactor = 20; };

                if (deadweight >= 200000)
                { reductFactor = 15; };
            }

            if (shipType == "Gas carrier")
            {
                if (deadweight <= 2000)
                { reductFactor = 0; };

                if (deadweight > 10000 & deadweight < 15000)
                { reductFactor = 0 + (20 - 0) * (deadweight - 10000) / (15000 - 10000); };

                if (deadweight >= 10000 & deadweight < 15000)
                { reductFactor = 20; };

                if (deadweight >= 15000)
                { reductFactor = 30; };
            }

            if (shipType == "Tanker")
            {
                if (deadweight <= 4000)
                { reductFactor = 0; };

                if (deadweight > 4000 & deadweight < 20000)
                { reductFactor = 0 + (20 - 0) * (deadweight - 4000) / (20000 - 4000); };

                if (deadweight >= 20000 & deadweight < 200000)
                { reductFactor = 20; };

                if (deadweight >= 200000)
                { reductFactor = 15; };
            }

            if (shipType == "Containership") 
            {
                if (deadweight <= 10000)
                { reductFactor = 0; };

                if (deadweight > 10000 & deadweight < 15000)
                { reductFactor = 0 + (20 - 0) * (deadweight - 1000) / (15000 - 1000); };

                if (deadweight >= 15000 & deadweight < 40000)
                { reductFactor = 20; };

                if (deadweight >= 40000 & deadweight < 80000)
                { reductFactor = 30; };

                if (deadweight >= 80000 & deadweight < 120000)
                { reductFactor = 35; };

                if (deadweight >= 120000 & deadweight < 200000)
                { reductFactor = 45; };

                if (deadweight >= 200000)
                { reductFactor = 50; };
            }

            if (shipType == "General cargo ship") 
            {
                if (deadweight <= 3000)
                { reductFactor = 0; };

                if (deadweight > 3000 & deadweight < 15000)
                { reductFactor = 0 + (30 - 0) * (deadweight - 3000) / (15000 - 3000); };

                if (deadweight >= 15000)
                { reductFactor = 30; };
            }

            if (shipType == "Refrigerated cargo carrier")
            {
                if (deadweight <= 3000)
                { reductFactor = 0; };

                if (deadweight > 3000 & deadweight < 5000)
                { reductFactor = 0 + (15 - 0) * (deadweight - 3000) / (5000 - 3000); };

                if (deadweight >= 5000)
                { reductFactor = 15; };
            }

            if (shipType == "Combination carrier")
            {
                if (deadweight <= 4000)
                { reductFactor = 0; };

                if (deadweight > 4000 & deadweight < 20000)
                { reductFactor = 0 + (20 - 0) * (deadweight - 4000) / (20000 - 4000); };

                if (deadweight >= 20000)
                { reductFactor = 20; };
            }

            if (shipType == "LNG carrier") 
            {
                if (deadweight < 10000)
                { reductFactor = 0; };

                if (deadweight >= 10000)
                { reductFactor = 30; };
            }
            
            if (shipType == "Ro-ro cargo ship (vehicle carrier)") 
            {
                if (deadweight < 10000)
                { reductFactor = 0; };

                if (deadweight >= 10000)
                { reductFactor = 15; };
            }
                        
            if (shipType == "Ro-ro cargo ship") 
            {
                if (deadweight <= 1000)
                { reductFactor = 0; };

                if (deadweight > 1000 & deadweight < 2000)
                { reductFactor = 0 + (5 - 0) * (deadweight - 1000) / (2000 - 1000); };

                if (deadweight >= 2000)
                { reductFactor = 5; };
            }            
            
            if (shipType == "Ro-ro passenger ship") 
            {
                if (deadweight <= 250)
                { reductFactor = 0; };

                if (deadweight > 250 & deadweight < 1000)
                { reductFactor = 0 + (5 - 0) * (deadweight - 250) / (1000 - 250); };

                if (deadweight >= 1000)
                { reductFactor = 5; };
            }
            
            if (shipType == "Cruise passenger ship having non-conventional propulsion") 
            {
                if (grossTonnage <= 25000)
                { reductFactor = 0; };

                if (grossTonnage > 25000 & grossTonnage < 85000)
                { reductFactor = 0 + (30 - 0) * (grossTonnage - 25000) / (85000 - 25000); };

                if (grossTonnage >= 85000)
                { reductFactor = 30; };
            }


            return reductFactor;

        }

    }
}
