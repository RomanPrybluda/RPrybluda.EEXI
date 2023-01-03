using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.11.2  Ship specific voluntary structural enhancement  fIvse
    
    public static class FiVSE
    {
        public static double fIvse;

        public static double CalcFiVSE(double deadweightRefDesign, double deadweightEnhancedDesign)
        {
            if (deadweightRefDesign == 0 & deadweightEnhancedDesign == 0)
            {
                fIvse = 1; 
            }

            if (deadweightRefDesign != 0 & deadweightEnhancedDesign != 0)
            {
                fIvse = deadweightRefDesign / deadweightEnhancedDesign;
            }
            
            return fIvse;
        }
    }
    
}
