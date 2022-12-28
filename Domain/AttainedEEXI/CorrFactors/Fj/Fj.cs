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

        public static double CalcFj(double fJiceClass, double fJRoRo, double fJGeneralCargo)
        {

            fJ = fJiceClass * fJRoRo * fJGeneralCargo;

            return fJ;
        }

    }
        
}   