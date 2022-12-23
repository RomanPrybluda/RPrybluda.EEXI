using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    public class IceClass
    {
        
        public static string ChooseIceClass(string iceClass)
        {
            if (iceClass == "0") { iceClass = "N/A"; }

            if (iceClass == "1") { iceClass = "IA Super"; }

            if (iceClass == "2") { iceClass = "IA"; }

            if (iceClass == "3") { iceClass = "IB"; }

            if (iceClass == "4") { iceClass = "IC"; }

            return iceClass;
        }
    }

}