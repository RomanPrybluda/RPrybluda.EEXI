using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    public class RefLineValueEEDI
    {

        static public double refLineValueEEDI;
        
        public static double CalcRefLineValueEEDI(string shipType, double deadweight)
        {

            if (shipType == "Bulk carrier" & deadweight <= 279000) 
            {
                refLineValueEEDI = 961.79 * Math.Pow(deadweight, -0.477);
            }

            else if (shipType == "Bulk carrier" & deadweight > 279000) 
            {
                refLineValueEEDI = 961.79 * Math.Pow(279000, -0.477);
            }

            else if (shipType == "Gas carrier") 
            {
                refLineValueEEDI = 1120.00 * Math.Pow(deadweight, -0.456);
            }

            else if (shipType == "Tanker") 
            {
                refLineValueEEDI = 1218.80 * Math.Pow(deadweight, -0.488);
            }

            else if (shipType == "Containership") 
            {
                refLineValueEEDI = 174.22 * Math.Pow(deadweight, -0.201);
            }

            else if (shipType == "General cargo ship") 
            {
                refLineValueEEDI = 107.48 * Math.Pow(deadweight, -0.216);
            }

            else if (shipType == "Refrigerated cargo carrier") 
            {
                refLineValueEEDI = 227.01 * Math.Pow(deadweight, -0.244);
            }

            else if (shipType == "Combination carrier") // 
            {
                refLineValueEEDI = 1219.00 * Math.Pow(deadweight, -0.488);
            }

            else if (shipType == "LNG carrier") // 
            {
                refLineValueEEDI = 2253.7 * Math.Pow(deadweight, -0.474);
            }

            return refLineValueEEDI;
        }
    }
}
