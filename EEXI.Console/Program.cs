using System;
using Microsoft.VisualBasic.FileIO;
using RPrybluda.EEXI.Domain;

namespace RPrybluda.EEXI.EEXIconsole
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Calculation of the Required EEXI\n");

            // Input Data
            
            Console.WriteLine("\nInput ship name:");
            string shipName = Console.ReadLine();

            Console.WriteLine("\nInput IMO No.");
            uint imoNumber = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("\nInput ship type:");
            Console.WriteLine("| 1 - Bulk carrier  |  5 - General cargo ship         |");
            Console.WriteLine("| 2 - Gas carrier   |  6 - Refrigerated cargo carrier |");
            Console.WriteLine("| 3 - Tanker        |  7 - Combination carrier        |");
            Console.WriteLine("| 4 - Containership |  8 - LNG carrier                |");
            string shipType = Console.ReadLine();

            Console.WriteLine("\nInput ice class:");
            Console.WriteLine("0 - N/A");
            Console.WriteLine("1 - IA Super | 2 - IA  | 3 - IB |  4 - IC");
            string iceClass = Console.ReadLine();

            Console.WriteLine("\n--------------------------------------------------------------------------");

            Console.WriteLine("\nInput Deadweight, tons:");
            double deadweight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInput Vref:");
            double vRefIn = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--------------------------------------------------------------------------");

            Console.WriteLine("\nInput MRC of ME (s), kW:");
            double mcrME = double.Parse(Console.ReadLine());
            Console.WriteLine("Input MRClim of ME (s), kW:");
            double mcrMElim = double.Parse(Console.ReadLine());

            Console.WriteLine("\nFluel type:");
            Console.WriteLine("| 1 - Diesel / Gas oil | 4 - Liquefied petroleum Gas (Propane) | 7 - Methanol |");
            Console.WriteLine("| 2 - Light fuel oil   | 5 - Liquefied petroleum Gas (Butane)  | 8 - Ethanol  |");
            Console.WriteLine("| 3 - Heavy fuel oil   | 6 - Liquefied natural gas             |              |");

            Console.WriteLine("\nInput fluel type of ME:");
            string fuelTypeME = Console.ReadLine();
            Console.WriteLine("Input fluel type of AE:");
            string fuelTypeAE = Console.ReadLine();

            Console.WriteLine("\nInput SFC of ME (75% MRC), g/kWh:");
            double sfcMEin = double.Parse(Console.ReadLine());
            Console.WriteLine("Input SFC of AE (50% MRC), g/kWh:");
            double sfcAEin = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--------------------------------------------------------------------------");

            Console.WriteLine("Input power Shaft generator (s), MCRpto kWh:");
            double mcrPTO = double.Parse(Console.ReadLine());

            Console.WriteLine("Input power Shaft motor (s), MCRpti kWh:");
            double mcrPTI = double.Parse(Console.ReadLine());


            // New ship

            shipType = ShipType.ChooseShipType(shipType);
            iceClass = IceClass.ChooseIceClass(iceClass);
            fuelTypeME = FuelType.ChooseFuelTypeME(fuelTypeME);
            fuelTypeAE = FuelType.ChooseFuelTypeAE(fuelTypeAE);

            Ship ship = new Ship(shipName, imoNumber, shipType, deadweight, iceClass);

            // Calculation Required EEXI

            double reductFactor = ReductionFactor.CalcReductFactor(shipType, deadweight);
            double refLineValueEEDI = RefLineValueEEDI.CalcRefLineValueEEDI(shipType, deadweight);
            double reqEEXI = RequiredEEXI.CalcReqEEXI(refLineValueEEDI, reductFactor);

            // Calculation Attained EEXI

            
            double pAE = Pae.CalcPae(mcrME, mcrPTI);
            double pPTO = Ppto.CalcPpto(mcrPTO, pAE);
            double pME = Pme.CalcPme(mcrME, mcrMElim, mcrPTO, pPTO);

            double capacity = Capacity.CalcCapacity(deadweight, shipType);
            double vRefApp = Vrefapp.CalcVrefapp(shipType, deadweight, pME);
            double vRef = Vref.CalcVref(vRefIn, vRefApp);
            
            double sfcME = SFCme.CalcSFCme(sfcMEin);
            double sfcAE = SFCae.CalcSFCae(sfcAEin);
            double factorCfME = CfME.CalcFactorCfME(fuelTypeME, sfcMEin);
            double factorCfAE = CfAE.CalcFactorCfAE(fuelTypeAE, sfcAEin);

            double fJ = 1.0;   double fI = 1.0;   double fL = 1.0;
            double fM = 1.0;   double fC = 1.0;   double fW = 1.0;

            double attEEXI = AttainedEEXI.CalcAttEEXI (pME, factorCfME, sfcME, pAE, factorCfAE, sfcAE, capacity, vRef, fJ, fI, fC, fL, fW, fM);

            // Output Ship data  

            Console.WriteLine("\n============================================================================");
            Console.WriteLine("\nGeneral data:\n");
            Console.WriteLine("Ship name: mv " + ship.ShipName + "  " + "IMO No." + ship.IMOnumber);
            Console.WriteLine("Ship type: " + ship.ShipType);
            Console.WriteLine("DWT = " + ship.Deadweight + " tonns");
            Console.WriteLine("Ice class = " + ship.IceClass);

            // Output Required EEXI calculation results  

            Console.WriteLine("\n============================================================================");
            Console.WriteLine("\nCalculation Required EEXI:\n");
            Console.WriteLine("EEDI Reference line value = " + (Math.Round(refLineValueEEDI, 3, MidpointRounding.AwayFromZero)) + " g-CO2/tonMile");
            Console.WriteLine("Reduction factor = " + (Math.Round(reductFactor, 1, MidpointRounding.AwayFromZero)));
            Console.WriteLine("\nRequired EEXI = " + (Math.Round(reqEEXI, 3, MidpointRounding.AwayFromZero)) + " gCO2/t.NM");
            
            // Output Attained EEXI calculation results  

            Console.WriteLine("\n============================================================================");
            Console.WriteLine("\nCalculation Attained EEXI:\n");
            
            Console.WriteLine("Power of ME (s) = " + pME + " kW" + "        " + "Power of AEs = " + pAE + " kW");
            Console.WriteLine("Cf of ME = " + factorCfME + " tC02/tFuel" + "      " + "Cf of AE = " + factorCfAE + " tC02/tFuel");
            Console.WriteLine("SFC of ME = " + sfcME + " g/kWh" + "          " + "SFC of AE = " + sfcAE + " g/kWh");

            Console.WriteLine("\nCapacity " + capacity + " tons");
           
            
            if (vRefIn > 0) 
            {
            Console.WriteLine("\nVref = " + (Math.Round(vRef, 2, MidpointRounding.AwayFromZero)) + " knots");
            }

            if (vRefIn == 0)
            {
            Console.WriteLine("\nVref = Vapp = " + (Math.Round(vRef, 2, MidpointRounding.AwayFromZero)) + " knots");
            Console.WriteLine("Vrefavg = " + (Math.Round(Vrefapp.vRefAvg, 2, MidpointRounding.AwayFromZero)) + " knots");
            Console.WriteLine("MCRavg = " + (Math.Round(Vrefapp.mcrAvg, 2, MidpointRounding.AwayFromZero)) + " knots");
            Console.WriteLine("mv = " + (Math.Round(Vrefapp.mv, 2, MidpointRounding.AwayFromZero)) + " knots");
            }

            Console.WriteLine("\nCorrection factors:");
            Console.WriteLine("Fj = " + fJ + "   " + "Fi = " + fI + "   " + "Fl = " + fL);
            Console.WriteLine("Fm = " + fM + "   " + "Fc = " + fC + "   " + "Fw = " + fW);

            Console.WriteLine("\nAttained EEXI = " + (Math.Round(attEEXI, 3, MidpointRounding.AwayFromZero)) + " gCO2/t.NM");

            Console.WriteLine("\n============================================================================");

            // Output Conclusion  

            Console.WriteLine("\nConclusion:");

            if (attEEXI == reqEEXI)
            {
                Console.WriteLine("\nAttained EEXI equal Required EEXI" +
                                  "\n\nAttained EEXI = " + (Math.Round(attEEXI, 3, MidpointRounding.AwayFromZero)) + " gCO2 / t.NM " + " = " + "Required EEXI = " + (Math.Round(reqEEXI, 3, MidpointRounding.AwayFromZero)) + " gCO2 / t.NM " +
                                  "\n\nSince the attained EEXI is less than the required EEXI," +
                                  "\nthen the vessel complies with the energy efficiency requirements.");
            }

            if (attEEXI <= reqEEXI)
            {
                Console.WriteLine("\nAttained EEXI less Required EEXI" +
                                  "\n\nAttained EEXI = " + (Math.Round(attEEXI, 3, MidpointRounding.AwayFromZero)) + " gCO2 / t.NM " + " < " + "Required EEXI = " + (Math.Round(reqEEXI, 3, MidpointRounding.AwayFromZero)) + " gCO2 / t.NM " +
                                  "\n\nSince the attained EEXI is less than the required EEXI," +
                                  "\nthen the vessel complies with the energy efficiency requirements.");
            }


            else
            {
                Console.WriteLine("\nAttained EEXI more than Required EEXI " +
                                  "\n\nAttained EEXI = " + (Math.Round(attEEXI, 3, MidpointRounding.AwayFromZero)) + " gCO2 / t.NM " + " > " + "Required EEXI = " + (Math.Round(reqEEXI, 3, MidpointRounding.AwayFromZero)) + " gCO2 / t.NM " +
                                  "\n\nSince the resulting EEXI factor more requires the EEXI factor," +
                                  "\nit is necessary to provide an action to improve the energy efficiency of consumption.");
            }

            Console.WriteLine("\n============================================================================");

            Console.ReadKey();

        }
    }
}