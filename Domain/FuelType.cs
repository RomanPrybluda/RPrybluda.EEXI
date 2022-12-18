using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    public class FuelType
    {
        
        public static string ChooseFuelTypeME(string fuelTypeME)
        {
            if (fuelTypeME == "1") { fuelTypeME = "Diesel / Gas oil"; }

            if (fuelTypeME == "2") { fuelTypeME = "Light fuel oil"; }

            if (fuelTypeME == "3") { fuelTypeME = "Heavy fuel oil"; }

            if (fuelTypeME == "4") { fuelTypeME = "Liquefied petroleum Gas (Propane)"; }

            if (fuelTypeME == "5") { fuelTypeME = "Liquefied petroleum Gas (Butane)"; }

            if (fuelTypeME == "6") { fuelTypeME = "Liquefied natural gas"; }

            if (fuelTypeME == "7") { fuelTypeME = "Methanol"; }

            if (fuelTypeME == "8") { fuelTypeME = "Ethanol"; }

            return fuelTypeME;
    
        }

        public static string ChooseFuelTypeAE(string fuelTypeAE)
        {
            if (fuelTypeAE == "1") { fuelTypeAE = "Diesel / Gas oil"; }

            if (fuelTypeAE == "2") { fuelTypeAE = "Light fuel oil"; }

            if (fuelTypeAE == "3") { fuelTypeAE = "Heavy fuel oil"; }

            if (fuelTypeAE == "4") { fuelTypeAE = "Liquefied petroleum Gas (Propane)"; }

            if (fuelTypeAE == "5") { fuelTypeAE = "Liquefied petroleum Gas (Butane)"; }

            if (fuelTypeAE == "6") { fuelTypeAE = "Liquefied natural gas"; }

            if (fuelTypeAE == "7") { fuelTypeAE = "Methanol"; }

            if (fuelTypeAE == "8") { fuelTypeAE = "Ethanol"; }

            return fuelTypeAE;
        }


    }


}