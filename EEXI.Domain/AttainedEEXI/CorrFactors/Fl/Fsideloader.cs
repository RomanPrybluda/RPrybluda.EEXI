using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // Factor for general cargo ships equipped with cranes and cargo-related gear

    public static class Fsideloader
    {
        public static double fSideLoader;
        public static double capacityNoSideLoaders;
        public static double capacitySideLoaders;

        public static double CalcFsideloader (double sideLoaderWeight, double capacity)
        {
            if (sideLoaderWeight == 0)
            {
                fSideLoader = 1;
            }

            else
            {
                double capacitySideLoaders = capacity;
                double capacityNoSideLoaders = capacity - sideLoaderWeight; 

                fSideLoader = capacityNoSideLoaders / capacitySideLoaders;
            }
          
            return fSideLoader;
        }

    }

}