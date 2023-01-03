using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.12 Cubic capacity correction factor fc

    // 2.2.12.1  fc for chemical tankers
    // 2.2.12.2  fc for gas carriers 
    // 2.2.12.3  fc for ro-ro passenger ships (fcRoPax)
    // 2.2.12.4  fc for bulk carriers having R of less than 0.55 (fc bulk carriers designed to carry light cargoes) 
    // 2.2.7 fcVEHICLE Cubic capacity correction factor for ro-ro cargo ships (vehicle carrier) (Resolution MEPC.350(78))

    public static class Fc
    {
        public static double fC;

        public static double CalcFc(double fcCT, double fcLNG, double fcRoPax, double fcR, double fcVEHICLE)
        {
            fC = fcCT * fcLNG * fcRoPax * fcR * fcVEHICLE;

            return fC;
        }
    }
}
