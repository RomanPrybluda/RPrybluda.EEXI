using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    public static class Fc
    {
        public static double resultFc;

        // fc Cubic capacity correction factor

        /*
             fc(Chemical Tanker) Cubic capacity correction factor for chemical tankers
             fc(Gas carrier) Cubic capacity correction factor for gas carriers
             fcVEHICLE Cubic capacity correction factor for ro-ro cargo ships (vehicle carrier)
             fcRoPax Cubic capacity correction factor for ro-ro passenger ships
             fc bulk carriers designed to carry light cargoes 
                Cubic capacity correction factor for bulk carriers having R of less than 0.55
            */


        public static double CalcFc()
        {
            double resultFc = 1;
            
            return resultFc;

        }
    }
}
