using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.11 Capacity factor for technical/regulatory limitation on capacity
    
    public static class Fi
    {
        public static double fI;

        public static double CalcFi(double fIice, double fIvse, double fIcrs)
        {
            fI = fIice * fIvse * fIcrs;

            return fI;
        }
    }
   
}
