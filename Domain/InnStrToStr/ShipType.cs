using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    public class ShipType
    {
        
        public static string ChooseShipType(string shipType)
        {
            if (shipType == "1") { shipType = "Bulk carrier"; }

            if (shipType == "2") { shipType = "Gas carrier"; }

            if (shipType == "3") { shipType = "Tanker"; }

            if (shipType == "4") { shipType = "Containership"; }

            if (shipType == "5") { shipType = "General cargo ship"; }

            if (shipType == "6") { shipType = "Refrigerated cargo carrier"; }

            if (shipType == "7") { shipType = "Combination carrier"; }

            if (shipType == "8") { shipType = "LNG carrier"; }

            return shipType;
        }
    }

}