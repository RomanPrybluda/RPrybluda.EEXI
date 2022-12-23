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

            Console.WriteLine("\nInput Deadweight, tons:");
            double deadweight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInput Vref:");
            double vRefS = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInput ice class:");
            Console.WriteLine("0 - N/A");
            Console.WriteLine("1 - IA Super | 2 - IA  | 3 - IB |  4 - IC");
            string iceClass = Console.ReadLine();

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
            double sfcME = double.Parse(Console.ReadLine());
            Console.WriteLine("Input SFC of AE (50% MRC), g/kWh:");
            double sfcAE = double.Parse(Console.ReadLine());

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

            double capacity = Capacity.CalcCapacity(deadweight, shipType);
            double pAE = Pae.CalcPae(mcrME, mcrPTI);
            double pME = Pme.CalcPme(mcrME, mcrMElim, mcrPTO, pAE);
            double vRefApp = Vrefapp.CalcVrefapp(shipType, deadweight, pME);
            double vRef = Vref.CalcVref(vRefS, vRefApp);




            // Output Ship data  

            Console.WriteLine("\n============================================================================");
            Console.WriteLine("\nGeneral data:\n");
            Console.WriteLine("Ship name: mv " + ship.ShipName);
            Console.WriteLine("IMO No." + ship.IMOnumber);
            Console.WriteLine("Ship type: " + ship.ShipType);
            Console.WriteLine("DWT = " + ship.Deadweight + " tonns");
            Console.WriteLine("Ice class = " + ship.IceClass);


            // Output Required EEXI calculation results  

            Console.WriteLine("\n============================================================================");
            Console.WriteLine("\nCalculation Required EEXI:\n");
            Console.WriteLine("EEDI Reference line value = " + (Math.Round(refLineValueEEDI, 3, MidpointRounding.AwayFromZero)) + " g-CO2/tonMile");
            Console.WriteLine("Reduction factor = " + (Math.Round(reductFactor, 1, MidpointRounding.AwayFromZero)));
            Console.WriteLine("Required EEXI = " + (Math.Round(reqEEXI, 3, MidpointRounding.AwayFromZero)) + " gCO2/t.NM");
            Console.WriteLine("\n============================================================================");

            // Output Attained EEXI calculation results  

            Console.WriteLine("\n============================================================================");
            Console.WriteLine("\nCalculation Attained EEXI:\n");
            
            Console.WriteLine("Power of ME (s) " + Pme.pME + " kW");
            Console.WriteLine("Cf of ME " + FactorCfME.resultFactorCfME + " tC02/tFuel");
            Console.WriteLine("SFC of ME " + SFCme.resultSFCme + " g/kWh");

            Console.WriteLine("\nPower of AEs " + Pae.pAE + " kW");
            Console.WriteLine("Cf of AE " + FactorCfAE.resultFactorCfAE + " tC02/tFuel");
            Console.WriteLine("SFC of AE " + SFCae.resultSFCae + " g/kWh");

            Console.WriteLine("\nCapacity " + capacity + " tons");
            Console.WriteLine("Vref " + vRef + " knots");
            
            Console.WriteLine("\nCorrection factors:");
            Console.WriteLine("Fj = " + FjICEclass.fJiceClass);
            Console.WriteLine("Fi = " + Fi.resultFi);
            Console.WriteLine("Fl = " + Fl.resultFl);
            Console.WriteLine("Fm = " + Fm.resultFm);
            Console.WriteLine("Fc = " + Fc.resultFc);
            Console.WriteLine("Fw = " + Fw.resultFm);

            Console.WriteLine("Attained EEXI = " + (Math.Round(AttainedEEXI.attEEXI, 3, MidpointRounding.AwayFromZero)) + " gCO2/t.NM");

            Console.WriteLine("\n============================================================================");

            Console.WriteLine("\nConclusion:\n");

            if (AttainedEEXI.attEEXI <= reqEEXI)
            {
                Console.WriteLine("Attained EEXI less or equal Required EEXI\n" +
                                  "Attained EEXI <= Required EEXI\n" +
                                  "Since the attained EEXI is less than the required EEXI,\n" +
                                  " then the vessel complies with the energy efficiency requirements.");
            }

            else
            {
                Console.WriteLine("Attained EEXI more than Required EEXI \n " +
                                  "Attained EEXI > Required EEXI\n" +
                                  "Since the resulting EEXI factor more requires the EEXI factor, \n" +
                                  "it is necessary to provide an action to improve the energy efficiency of consumption.");
            }

            Console.WriteLine("\n============================================================================");

            Console.ReadKey();

        }
    }
}