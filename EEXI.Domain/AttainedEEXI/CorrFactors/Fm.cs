using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    //  fm (ice class IA Super and IA)

    public static class Fm
    {
        public static double fM;

        public static double CalcFm(string iceClass) 
        {
            if (iceClass == "IA Super" || iceClass == "IA")
            {
                fM = 1.05;
            }

            else
            {
                fM = 1;
            }

            return fM;

        }
    }
}
