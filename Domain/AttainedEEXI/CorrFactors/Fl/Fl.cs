using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{


    // Factor for general cargo ships equipped with cranes and cargo-related gear

    public static class Fl
    {
        public static double fL;

        public static double CalcFl(double fCranes, double fSideLoader, double fRoRoRamp)
        {

            fL = fCranes * fSideLoader * fRoRoRamp;

            return fL;
        }

    }

}