using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{

    // 2.2.12 Cubic capacity correction factor fc


    // 2.2.12.1  fc for chemical tankers

    // fc = R^(-0.7) ─ 0.014, where R is less than 0.98
    // or 
    // fc = 1.000, where R is 0.98 and above;
    // where: R is the capacity ratio of the deadweight of the ship (tonnes) as determined by
    // paragraph 2.2.4 divided by the total cubic capacity of the cargo tanks of the ship (m3). 


    // 2.2.12.2  fc for gas carriers 

    // fcLNG = R^(-0.56) 


    // 2.2.12.3  fc for ro-ro passenger ships (fcRoPax)

    // 𝑓𝑐𝑅𝑜𝑃𝑎𝑥 = ( (DWT/GT) / 0.25 )^(-0.8)


    // 2.2.12.4  fc for bulk carriers having R of less than 0.55 (fc bulk carriers designed to carry light cargoes) 

    // For bulk carriers having R of less than 0.55 (e.g. wood chip carriers), the following cubic
    // capacity correction factor, fc bulk carriers designed to carry light cargoes, should apply: 
    // fc bulk carriers designed to carry light cargoes = R^(-0.15)  

    public static class Fc
    {
        public static double fC;

        public static double CalcFc()
        {
            double fC = 1;
            
            return fC;

        }
    }
}
