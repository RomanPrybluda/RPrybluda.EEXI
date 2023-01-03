using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.FileIO;
using RPrybluda.EEXI.Domain;

namespace RPrybluda.EEXI.EEXIconsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("|=============================================================================|");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("|                Required EEXI and Attained EEXI Calculation                  |");       
            Console.WriteLine("|                    23/25 Regulation Annex VI MARPOL                         |");
            Console.WriteLine("|                                                                             |");
            Console.WriteLine("|=============================================================================|");

            // Input Data

            Console.WriteLine("|");
            Console.WriteLine("| Input ship name:");
            string shipName = Console.ReadLine();
            Console.WriteLine("|");
            Console.WriteLine("| Input IMO No.:");
            uint imoNumber = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("|");
            Console.WriteLine("| Input ship type:");
            Console.WriteLine("|");
            Console.WriteLine("| 1 - Bulk carrier                |   7 - Combination carrier                 |");
            Console.WriteLine("| 2 - Gas carrier                 |   8 - LNG carrier                         |");
            Console.WriteLine("| 3 - Tanker                      |   9 - Ro-ro cargo ship (vehicle carrier)  |");
            Console.WriteLine("| 4 - Containership               |  10 - Ro-ro cargo ship                    |");
            Console.WriteLine("| 5 - General cargo ship          |  11 - Ro-ro passenger ship                |");
            Console.WriteLine("| 6 - Refrigerated cargo carrier  |  12 - Cruise passenger ship having        |");
            Console.WriteLine("|                                 |        non-conventional propulsion        |");
            string shipType = Console.ReadLine();
     
            Console.WriteLine("| Input ice class:");
            Console.WriteLine("| 0 - N/A  |  1 - IA Super  |  2 - IA   |  3 - IB  |  4 - IC  |");
            string iceClass = Console.ReadLine();

            Console.WriteLine("| Ships was builded under the CSR ?:");
            Console.WriteLine("| 0 - N/A  |  1 - Yes  |");
            string shipUnderCSR = Console.ReadLine();

            Console.WriteLine("| Input DWT enhanced design (if N/A input 0):");
            double deadweightEnhancedDesign = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("| Input DWT refernce design (if N/A input 0):");
            double deadweightRefDesign = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("| Input Length between perpendiculars, m:");
            double lPP = Convert.ToDouble(Console.ReadLine());
      
            Console.WriteLine("| Input Breadth, m:");
            double bS = Convert.ToDouble(Console.ReadLine());
  
            Console.WriteLine("| Input Summer load line draught, m:");
            double dS = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("| Input Deadweight, tons:");
            double deadweight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("| Input Light weight ship, tons:");
            double lwt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("| Input Volume displacement, m3:");
            double vDisplacement = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("| Input GROSS TONNAGES:");
            double grossTonnage = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\n| Input MRC of ME (s), kW:");
            double mcrME = double.Parse(Console.ReadLine());
            Console.WriteLine("| Input MRClim of ME (s), kW:");
            double mcrMElim = double.Parse(Console.ReadLine());
          
            Console.WriteLine("| Fluel type:");
            Console.WriteLine("|");
            Console.WriteLine("| 1 - Diesel / Gas oil | 4 - Liquefied petroleum Gas (Propane) | 7 - Methanol |");
            Console.WriteLine("| 2 - Light fuel oil   | 5 - Liquefied petroleum Gas (Butane)  | 8 - Ethanol  |");
            Console.WriteLine("| 3 - Heavy fuel oil   | 6 - Liquefied natural gas             |              |");
            Console.WriteLine("|");
            Console.WriteLine("| Input fluel type of ME:");
            string fuelTypeME = Console.ReadLine();
            Console.WriteLine("Input fluel type of AE:");
            string fuelTypeAE = Console.ReadLine();
   
            Console.WriteLine("| Input SFC ISO of ME (75% MRC), g/kWh (input 0 if no data):");
            double sfcMEin75 = double.Parse(Console.ReadLine());
            Console.WriteLine("| Input SFC ISO of ME (50% MRC), g/kWh (input 0 if MCRlim = N/A):");
            double sfcMEin50 = double.Parse(Console.ReadLine());

            Console.WriteLine("| Input SFC ISO of AE (50% MRC), g/kWh (input 0 if no data):");
            double sfcAEin = double.Parse(Console.ReadLine());
            Console.WriteLine("|");
            Console.WriteLine("| Input Vref: (input 0 if no data)");
            double vRefIn = double.Parse(Console.ReadLine());
            Console.WriteLine("|");
            Console.WriteLine("| Input power Shaft generator (s), MCRpto, kWh (if N/A input 0):");
            double mcrPTO = double.Parse(Console.ReadLine());
            
            Console.WriteLine("| Input power Shaft motor (s), MCRpti, kWh (if N/A input 0):");
            double mcrPTI = double.Parse(Console.ReadLine());

            Console.WriteLine("| Input crane data (if N/A cranes input 0):");
            Console.WriteLine("| Crane 01 SWL, tons:");
            double swl01 = double.Parse(Console.ReadLine());
            Console.WriteLine("| Crane 01 Reach, m:");
            double reach01 = double.Parse(Console.ReadLine());
            Console.WriteLine("| Crane 02 SWL, tons:");
            double swl02 = double.Parse(Console.ReadLine());
            Console.WriteLine("| Crane 02 Reach, m:");
            double reach02 = double.Parse(Console.ReadLine());
            Console.WriteLine("| Crane 03 SWL, tons:");
            double swl03 = double.Parse(Console.ReadLine());
            Console.WriteLine("| Crane 03 Reach, m:");
            double reach03 = double.Parse(Console.ReadLine());
            Console.WriteLine("| Crane 04 SWL, tons:");
            double swl04 = double.Parse(Console.ReadLine());
            Console.WriteLine("| Crane 04 Reach, m:");
            double reach04 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n|Input Side loaders weight, tons (if N/A input 0):");
            double sideLoaderWeight = double.Parse(Console.ReadLine());

            Console.WriteLine("\n|Input RoRo ramp weight, tons (if N/A input 0):");
            double rampRoRoWeight = double.Parse(Console.ReadLine());

            double rCT = 0;
            double rLNG = 0;
            double rBulkCarrier = 0;

            // New ship

            shipType = ShipType.ChooseShipType(shipType);
            iceClass = IceClass.ChooseIceClass(iceClass);
            fuelTypeME = FuelType.ChooseFuelTypeME(fuelTypeME);
            fuelTypeAE = FuelType.ChooseFuelTypeAE(fuelTypeAE);

            Ship ship = new Ship(shipName, imoNumber, shipType, deadweight, lwt, iceClass);

            // Calculation Required EEXI

            double reductFactor = ReductionFactor.CalcReductFactor(shipType, deadweight, grossTonnage);
            double refLineValueEEDI = RefLineValueEEDI.CalcRefLineValueEEDI(shipType, deadweight, grossTonnage);
            double reqEEXI = RequiredEEXI.CalcReqEEXI(refLineValueEEDI, reductFactor);

            // Calculation Attained EEXI
            
            double pAE = Pae.CalcPae(mcrME, mcrPTI);
            double pPTO = Ppto.CalcPpto(mcrPTO, pAE);
            double pME = Pme.CalcPme(mcrME, mcrMElim, mcrPTO, pPTO);

            double capacity = Capacity.CalcCapacity(deadweight, shipType,grossTonnage);
            double vRefApp = Vrefapp.CalcVrefapp(shipType, deadweight, pME, grossTonnage);
            double vRefF = VrefF.CalcVrefF(shipType, deadweight, mcrME, grossTonnage);
            double vRef = Vref.CalcVref(vRefIn, vRefApp);
            
            double sfcME = SFCme.CalcSFCme(sfcMEin75, sfcMEin50, mcrME, mcrMElim);
            double sfcAE = SFCae.CalcSFCae(sfcAEin, mcrPTO, sfcME);
            double factorCfME = CfME.CalcFactorCfME(fuelTypeME, sfcMEin75);
            double factorCfAE = CfAE.CalcFactorCfAE(fuelTypeAE, sfcAEin, mcrPTO, factorCfME);

            double cB = Cb.CalcCb(vDisplacement, lPP, bS, dS);

            double fJiceClass = FjIceClass.CalcFjICEclass(shipType, deadweight, iceClass, mcrME);
            double fJGeneralCargo = FjGeneralCargo.CalcFjGeneralCargo(shipType, vRef, vDisplacement, cB);
            double fJRoRo = FjRoRo.CalcFjRoRo(shipType, vDisplacement, lPP, bS, dS, vRefF);
            double fJ = Fj.CalcFj(fJiceClass,fJGeneralCargo,fJRoRo);

            double fIice = FiIce.CalcFiIce(shipType, deadweight, iceClass, cB);
            double fIcrs = FiCRS.CalcFiCRS(deadweight, lwt, shipUnderCSR);
            double fIvse = FiVSE.CalcFiVSE(deadweightRefDesign, deadweightEnhancedDesign);
            double fI = Fi.CalcFi(fIice, fIvse, fIcrs);

            double fCranes = Fcranes.CalcFcranes(swl01, swl02, swl03, swl04, reach01, reach02, reach03, reach04, capacity);
            double fSideLoader = Fsideloader.CalcFsideloader(sideLoaderWeight, capacity);
            double fRoRoRamp = FRoRoRamp.CalcFRoRoRamp(rampRoRoWeight, capacity);
            double fL = fCranes * fSideLoader * fRoRoRamp;
            
            double fM = Fm.CalcFm(iceClass);

            double fcCT = FcCT.CalcFcCT(shipType, rCT);
            double fcLNG = FcLNG.CalcFcLNG(shipType, rLNG);
            double fcRoPax = FcRoPax.CalcFcRoPax(shipType, deadweight, grossTonnage);
            double fcR = FcR.CalcFcR(shipType, rBulkCarrier);
            double fcVEHICLE = FcVEHICLE.CalcFcVEHICLE(shipType, deadweight, grossTonnage);
            double fC = Fc.CalcFc(fcCT, fcLNG, fcRoPax, fcR, fcVEHICLE);

            double fW = Fw.CalcFw();

            double attEEXI = AttainedEEXI.CalcAttEEXI (pME, factorCfME, sfcME, pAE, factorCfAE, sfcAE, capacity, vRef, fJ, fI, fC, fL, fW, fM);

            // Output Ship data  

            Console.WriteLine(" ");
            Console.WriteLine("|===============================================================================");
            Console.WriteLine("|");
            Console.WriteLine("|\t1.General information :");
            Console.WriteLine("|");
            Console.WriteLine("|\tShip name: mv " + ship.ShipName);
            Console.WriteLine("|\tIMO No.: " + ship.IMOnumber);
            Console.WriteLine("|\tShip type: " + ship.ShipType);
            Console.WriteLine("|\tIce class = " + ship.IceClass);
            Console.WriteLine("|");
            Console.WriteLine("|===============================================================================");
            Console.WriteLine("|");
            Console.WriteLine("|\t2.Principal particulars:");
            Console.WriteLine("|");
            Console.WriteLine("|\tLpp = " + lPP + " m");
            Console.WriteLine("|\tBs = " + bS + " m");
            Console.WriteLine("|\tds = " + dS + " m");
            Console.WriteLine("|\tVolumentic displacement = " + vDisplacement + " m");
            Console.WriteLine("|\tCb = " + (Math.Round(cB, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\tDWT = " + ship.Deadweight + " tonns");
            Console.WriteLine("|\tLWT = " + ship.LWT + " tonns");
            Console.WriteLine("|");
            Console.WriteLine("|===============================================================================");

            // Output Required EEXI calculation results
         
            Console.WriteLine("|");
            Console.WriteLine("|\t3.Calculation Required EEXI:");
            Console.WriteLine("|");
            Console.WriteLine("|\tEEDI Reference line value = " + (Math.Round(refLineValueEEDI, 2, MidpointRounding.AwayFromZero)) + " g-CO2/tonMile");
            Console.WriteLine("|\tReduction factor = " + (Math.Round(reductFactor, 1, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t------------------------------------------------------------------");
            Console.WriteLine("|");
            Console.WriteLine("|\tRequired EEXI = " + (Math.Round(reqEEXI, 2, MidpointRounding.AwayFromZero)) + " gCO2/t.NM");
            Console.WriteLine("|");
            Console.WriteLine("|===============================================================================");

            // Output Attained EEXI calculation results  

            Console.WriteLine("|");
            Console.WriteLine("|\t4.Calculation Attained EEXI:");
            
            // Output Main Engine (s) data

            Console.WriteLine("|");
            Console.WriteLine("|\tPower of ME (s) = " + (Math.Round(pME, 2, MidpointRounding.AwayFromZero)  + " kW"));
            Console.WriteLine("|\tCf of ME = " + (Math.Round(factorCfME, 2, MidpointRounding.AwayFromZero)) + " tC02/tFuel");
            Console.WriteLine("|\tSFC of ME = " + (Math.Round(sfcME, 2, MidpointRounding.AwayFromZero))  + " g/kWh");
            Console.WriteLine("|");
            Console.WriteLine("|\t------------------------------------------------------------------");

            // Output Auxiliry Engines data

            Console.WriteLine("|");
            Console.WriteLine("|\tPower of AEs = " + (Math.Round(pAE, 2, MidpointRounding.AwayFromZero)) + " kW");
            Console.WriteLine("|\tCf of AE = " + (Math.Round(factorCfAE, 2, MidpointRounding.AwayFromZero)) + " tC02/tFuel");
            Console.WriteLine("|\tSFC of AE = " + (Math.Round(sfcAE, 2, MidpointRounding.AwayFromZero)) + " g/kWh");
            Console.WriteLine("|");
            Console.WriteLine("|\t------------------------------------------------------------------");

            // Output Capacity

            Console.WriteLine("|");
            Console.WriteLine("|\tCapacity " + capacity + " tons");
            Console.WriteLine("|");
            Console.WriteLine("|\t------------------------------------------------------------------");

            // Output Vref

            if (vRefIn > 0) 
            {
                Console.WriteLine("|");
                Console.WriteLine("|\tVref = " + (Math.Round(vRef, 2, MidpointRounding.AwayFromZero)) + " knots");
                Console.WriteLine("|");
            }

            if (vRefIn == 0)
            {
                Console.WriteLine("|");
                Console.WriteLine("|\tVref = Vapp = " + (Math.Round(vRef, 2, MidpointRounding.AwayFromZero)) + " knots");
                Console.WriteLine("|\tVrefavg = " + (Math.Round(Vrefapp.vRefAvg, 2, MidpointRounding.AwayFromZero)) + " knots");
                Console.WriteLine("|\tMCRavg = " + (Math.Round(Vrefapp.mcrAvg, 2, MidpointRounding.AwayFromZero)) + " knots");
                Console.WriteLine("|\tmv = " + (Math.Round(Vrefapp.mv, 2, MidpointRounding.AwayFromZero)) + " knots");
                Console.WriteLine("|");
            }

            Console.WriteLine("|\t------------------------------------------------------------------");

            // Output correction factors

            Console.WriteLine("|");
            Console.WriteLine("|\tCorrection factors:");
            Console.WriteLine("|");
            Console.WriteLine("|");
            
            Console.WriteLine("|\tFj = " + (Math.Round(fJ, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t----------");
            Console.WriteLine("|\tFj ice class = " + (Math.Round(fJiceClass, 2, MidpointRounding.AwayFromZero)) + "  " +
                              "( Fj0 = " + (Math.Round(FjIceClass.fJ0, 2, MidpointRounding.AwayFromZero)) + "  " +
                              "Fjmin = " + (Math.Round(FjIceClass.fJmin, 2, MidpointRounding.AwayFromZero)) + " )");

            Console.WriteLine("|\tFj Ro-Ro = " + (Math.Round(fJRoRo, 2, MidpointRounding.AwayFromZero)) + "  " +
                               "( Fnl = " + (Math.Round(FjRoRo.fNl, 2, MidpointRounding.AwayFromZero)) + "  " +
                               "VrefF = " + (Math.Round(VrefF.vRefF, 2, MidpointRounding.AwayFromZero)) + " )");

            Console.WriteLine("|\tFj General Cargo = " + (Math.Round(fJGeneralCargo, 2, MidpointRounding.AwayFromZero)) + "  " +
                              "( Fnv = " + (Math.Round(FjGeneralCargo.fNv, 2, MidpointRounding.AwayFromZero)) + " )");
            Console.WriteLine("|\t-----------------------------------------------------------"); 
            
            Console.WriteLine("|\tFi = " + (Math.Round(fI, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t----------");
            Console.WriteLine("|\tFiIce = " + (Math.Round(fIice, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t( Fi(ice class) = " + (Math.Round(FiIce.fIiceClass, 2, MidpointRounding.AwayFromZero)) + "  " +
                  "FiCb = " + (Math.Round(FiIce.fIcB, 2, MidpointRounding.AwayFromZero)) + "  " +
                  "Cb ref design = " + (Math.Round(FiIce.cBrefdesign, 2, MidpointRounding.AwayFromZero)) + " )");
            Console.WriteLine("|\tFiVSE = " + (Math.Round(fIvse, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t( DWT ref Design = " + deadweightRefDesign + "  " + "DWT enhanced Design = "  + deadweightEnhancedDesign + " )");
            Console.WriteLine("|\tFiCRS = " + (Math.Round(fIcrs, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t-----------------------------------------------------------");
            
            Console.WriteLine("|\tFc = " + (Math.Round(fC, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t----------");
            Console.WriteLine("|\tFcCT = " + (Math.Round(fcCT, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\tFcLNG = " + (Math.Round(fcLNG, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\tFcRoPax = " + (Math.Round(fcRoPax, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\tFcR = " + (Math.Round(fcR, 3, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\tFcVIHICLE = " + (Math.Round(fcVEHICLE, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t-----------------------------------------------------------");
            
            Console.WriteLine("|\tFl = " + (Math.Round(fL, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t----------");
            Console.WriteLine("|\tF cranes = " + (Math.Round(fCranes, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\tF sideloader = " + (Math.Round(fSideLoader, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\tF Ro-Ro Ramp = " + (Math.Round(fRoRoRamp, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t-----------------------------------------------------------");

            Console.WriteLine("|\tFw = " + (Math.Round(fW, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t-----------------------------------------------------------");

            Console.WriteLine("|\tFm = " + (Math.Round(fM, 2, MidpointRounding.AwayFromZero)));
            Console.WriteLine("|\t-----------------------------------------------------------");

            Console.WriteLine("|");
            Console.WriteLine("|\tAttained EEXI = " + (Math.Round(attEEXI, 2, MidpointRounding.AwayFromZero)) + " gCO2/t.NM");
            Console.WriteLine("|");
            Console.WriteLine("|===============================================================================");

            // Output Conclusion  

            Console.WriteLine("|");
            Console.WriteLine("|\t5.Conclusion:");
            Console.WriteLine("|");

            if (attEEXI == reqEEXI)
            {
                Console.WriteLine("|\tAttained EEXI equal Required EEXI");
                Console.WriteLine("|");
                Console.WriteLine("|\tAttained EEXI = " + (Math.Round(attEEXI, 2, MidpointRounding.AwayFromZero)) + " gCO2/t.NM " + " = " + "Required EEXI = " + (Math.Round(reqEEXI, 2, MidpointRounding.AwayFromZero)) + " gCO2/t.NM ");
                Console.WriteLine("|");
                Console.WriteLine("|\tSince the attained EEXI is less than the required EEXI,");
                Console.WriteLine("|\tnthen the vessel complies with the energy efficiency requirements.");
                Console.WriteLine("|");
            }

            if (attEEXI <= reqEEXI)
            {
                Console.WriteLine("|\tAttained EEXI equal Required EEXI");
                Console.WriteLine("|");
                Console.WriteLine("|\tAttained EEXI = " + (Math.Round(attEEXI, 2, MidpointRounding.AwayFromZero)) + " gCO2/t.NM " + " < " + "Required EEXI = " + (Math.Round(reqEEXI, 2, MidpointRounding.AwayFromZero)) + " gCO2/t.NM ");
                Console.WriteLine("|");
                Console.WriteLine("|\tSince the attained EEXI is less than the required EEXI,");
                Console.WriteLine("|\tnthen the vessel complies with the energy efficiency requirements.");
                Console.WriteLine("|");
            }


            else
            {
                Console.WriteLine("|\tAttained EEXI equal Required EEXI");
                Console.WriteLine("|");
                Console.WriteLine("|\tAttained EEXI = " + (Math.Round(attEEXI, 2, MidpointRounding.AwayFromZero)) + " gCO2/t.NM " + " > " + "Required EEXI = " + (Math.Round(reqEEXI, 2, MidpointRounding.AwayFromZero)) + " gCO2/t.NM ");
                Console.WriteLine("|");
                Console.WriteLine("|\tSince the resulting EEXI more requires the EEXI,");
                Console.WriteLine("|\tis necessary to provide an action");
                Console.WriteLine("|\tto improve the energy efficiency of consumption.");
                Console.WriteLine("|");
            }

            Console.WriteLine("|===============================================================================");

            Console.ReadKey();

        }
    }
}