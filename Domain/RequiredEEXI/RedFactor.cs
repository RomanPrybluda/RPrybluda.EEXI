using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain.RequiredEEXI
{
    static class RedFactor
    {
        public static double resultRedFactor;

        public static double CalcRedFactor(double shipType, double deadweight)
        {
            if (shipType == 1) // Bulk carrier
            {
                if (deadweight <= 10000)
                { resultRedFactor = 0; };

                if (deadweight > 10000 & deadweight < 20000)
                { resultRedFactor = 0 + (20 - 0) * (deadweight - 10000) / (20000 - 10000); };

                if (deadweight >= 20000 & deadweight < 200000)
                { resultRedFactor = 20; };

                if (deadweight >= 200000)
                { resultRedFactor = 15; };
            }

            if (shipType == 2) // Gas carrier
            {
                if (deadweight <= 2000)
                { resultRedFactor = 0; };

                if (deadweight > 10000 & deadweight < 15000)
                { resultRedFactor = 0 + (20 - 0) * (deadweight - 10000) / (15000 - 10000); };

                if (deadweight >= 10000 & deadweight < 15000)
                { resultRedFactor = 20; };

                if (deadweight >= 15000)
                { resultRedFactor = 30; };
            }

            if (shipType == 3) // Tanker
            {
                if (deadweight <= 4000)
                { resultRedFactor = 0; };

                if (deadweight > 4000 & deadweight < 20000)
                { resultRedFactor = 0 + (20 - 0) * (deadweight - 4000) / (20000 - 4000); };

                if (deadweight >= 20000 & deadweight < 200000)
                { resultRedFactor = 20; };

                if (deadweight >= 200000)
                { resultRedFactor = 15; };
            }

            if (shipType == 4) // Containership
            {
                if (deadweight <= 10000)
                { resultRedFactor = 0; };

                if (deadweight > 10000 & deadweight < 15000)
                { resultRedFactor = 0 + (20 - 0) * (deadweight - 1000) / (15000 - 1000); };

                if (deadweight >= 15000 & deadweight < 40000)
                { resultRedFactor = 20; };

                if (deadweight >= 40000 & deadweight < 80000)
                { resultRedFactor = 30; };

                if (deadweight >= 80000 & deadweight < 120000)
                { resultRedFactor = 35; };

                if (deadweight >= 120000 & deadweight < 200000)
                { resultRedFactor = 45; };

                if (deadweight >= 200000)
                { resultRedFactor = 50; };
            }

            if (shipType == 5) // General cargo ship
            {
                if (deadweight <= 3000)
                { resultRedFactor = 0; };

                if (deadweight > 3000 & deadweight < 15000)
                { resultRedFactor = 0 + (30 - 0) * (deadweight - 3000) / (15000 - 3000); };

                if (deadweight >= 15000)
                { resultRedFactor = 30; };
            }

            if (shipType == 6) // Refrigerated cargo carrier
            {
                if (deadweight <= 3000)
                { resultRedFactor = 0; };

                if (deadweight > 3000 & deadweight < 5000)
                { resultRedFactor = 0 + (15 - 0) * (deadweight - 3000) / (5000 - 3000); };

                if (deadweight >= 5000)
                { resultRedFactor = 15; };
            }

            if (shipType == 7) // Combination carrier
            {
                if (deadweight <= 4000)
                { resultRedFactor = 0; };

                if (deadweight > 4000 & deadweight < 20000)
                { resultRedFactor = 0 + (20 - 0) * (deadweight - 4000) / (20000 - 4000); };

                if (deadweight >= 20000)
                { resultRedFactor = 20; };
            }

            if (shipType == 8) // LNG carrier
            {
                if (deadweight < 10000)
                { resultRedFactor = 0; };

                if (deadweight >= 10000)
                { resultRedFactor = 30; };
            }

            return resultRedFactor;
        }

    }
}
