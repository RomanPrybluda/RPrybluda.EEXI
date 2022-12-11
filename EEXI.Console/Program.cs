using System;
using RPrybluda.EEXI.Domain;
using RPrybluda.EEXI.Domain.RequiredEEXI;
using RPrybluda.EEXI.Domain.AttainedEEXI;
using RPrybluda.EEXI.Domain.AttainedEEXI.Factors;
using RPrybluda.EEXI.Persistence;

namespace RPrybluda.EEXI.EEXIconsole
{

    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Calculation of the required EEXI and attained EEXI coefficients\n" +
                              "and their comparison.\n" +
                              "Расчет для судов кроме судов с дизель-элетрической установкой " +
                              "и нетрадицонной установкой \n\n");

            // Input Data

            Console.WriteLine("Input ship type:");
            Console.WriteLine("1 - Bulk carrier  |  5 - General cargo ship");
            Console.WriteLine("2 - Gas carrier   |  6 - Refrigerated cargo carrier");
            Console.WriteLine("3 - Tanker        |  7 - Combination carrier");
            Console.WriteLine("4 - Containership |  8 - LNG carrier");

            double shipType;
            shipType = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------------------------\n");

            double deadweight;
            Console.WriteLine("Input Deadweight, t:");
            deadweight = double.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------------------------------\n");

            double deadweightCRS;
            Console.WriteLine("Input Deadweight CSR:");
            deadweightCRS = double.Parse(Console.ReadLine());

            double lwtCSR;
            Console.WriteLine("\nInput LWT CSR:");
            lwtCSR = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------------------------\n");

            double iceClass;
            Console.WriteLine("Input ice class:");
            Console.WriteLine("0 - N/A");
            Console.WriteLine("1 - IA Super | 2 - IA  | 3 - IB |  4 - IC");
            iceClass = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------------------------\n");

            double mcrME; double mcrMElim;

            Console.WriteLine("Input MRC of ME (s), kW:");
            mcrME = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInput MRClim of ME (s), kW:");
            mcrMElim = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------------------------\n");

            Console.WriteLine("Fluel type:");
            Console.WriteLine("1 - Diesel / Gas oil | 4 - Liquefied petroleum Gas (Propane) | 7 - Methanol");
            Console.WriteLine("2 - Light fuel oil   | 5 - Liquefied petroleum Gas (Butane)  | 8 - Ethanol");
            Console.WriteLine("3 - Heavy fuel oil   | 6 - Liquefied natural gas             |\n");

            double fluelTypeME; double fluelTypeAE;

            Console.WriteLine("Input fluel type of ME:");
            fluelTypeME = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInput fluel type of AE:");
            fluelTypeAE = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------------------------\n");

            double sfcME; double sfcAE;

            Console.WriteLine("Input SFC of ME (75% MRC), g/kWh:");
            sfcME = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInput SFC of AE (50% MRC), g/kWh:");
            sfcAE = double.Parse(Console.ReadLine());


            Console.WriteLine("----------------------------------------------------------------------------\n");

            double powerSG; double powerSM;

            Console.WriteLine("Input power Shaft generator (s), PTO kWh:");
            powerSG = double.Parse(Console.ReadLine());

            Console.WriteLine("Input power Shaft motor (s), PTI kWh:");
            powerSM = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------------------------\n");

            double swl01; double swl02; double swl03; double swl04;
            double reach01; double reach02; double reach03; double reach04;

            Console.WriteLine("Input cranes data:\n");

            Console.WriteLine("Input swl01:");
            swl01 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input reach01:");
            reach01 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input swl02:");
            swl02 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input reach02:");
            reach02 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input swl03:");
            swl03 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input reach03:");
            reach03 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input swl04:");
            swl04 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input reach04:");
            reach04 = double.Parse(Console.ReadLine());


            Console.WriteLine("\n----------------------------------------------------------------------------\n");


            // Calculation Requred EEXI ----------------------------------------------------------------------------

            double refLineValueEEDI;
            double redFactor;

            refLineValueEEDI = RefLineValueEEDI.CalcRefLineValueEEDI(shipType, deadweight);
            redFactor = RedFactor.CalcRedFactor(shipType, deadweight);

            // Requred EEXI

            double reqEEXI = (1 - redFactor / 100) * refLineValueEEDI;


            // Calculation Attained EEXI  --------------------------------------------------------------------------

            // Pme Pae

            double pME; double pAE;
            pAE = Pae.CalcPae(mcrME, powerSM);
            pME = Pme.CalcPme(mcrME, mcrMElim, powerSG, pAE);

            // CfME CfAE

            double factorCfME; double factorCfAE;
            factorCfME = FactorCfME.CalcFactorCfME(fluelTypeME);
            factorCfAE = FactorCfAE.CalcFactorCfAE(fluelTypeAE);

            // Capacity

            double capacity;
            capacity = Capacity.CalcCapacity(deadweight, shipType);

            // Vref

            double vREF; double vREFapp;
            vREFapp = Vrefapp.CalcVrefapp(shipType, deadweight, pME);
            vREF = vREFapp;

            // fj Ship specific design elements

            double fJ;
            double fJiceClass; // Correction factor for ice-class ships
            fJiceClass = FjICEclass.CalcFjICEclass(shipType, deadweight, iceClass, mcrME);
            //double fJgenaralcargo; // Correction factor for ice-class ships
            //double fJroro; // Correction factor for ice-class ships
            fJ = fJiceClass;

            // fi Capacity factor for technical/regulatory limitation on capacity

            double fI;
            double fICRS; // Capacity correction factor for ships under Common Structural Rules (CSR)
            fICRS = FiCRS.CalcFiCRS(deadweightCRS, lwtCSR);
            //double fIVSE; // Ship specific voluntary structural enhancement
            fI = fICRS;

            // fc Cubic capacity correction factor

            /*
             fc(Chemical Tanker) Cubic capacity correction factor for chemical tankers
             fc(Gas carrier) Cubic capacity correction factor for gas carriers
             fcVEHICLE Cubic capacity correction factor for ro-ro cargo ships (vehicle carrier)
             fcRoPax Cubic capacity correction factor for ro-ro passenger ships
             fc bulk carriers designed to carry light cargoes 
                Cubic capacity correction factor for bulk carriers having R of less than 0.55
            */

            // fl Factor for general cargo ships equipped with cranes and cargo - related gear

            double fL;
            double fcranes;
            fcranes = Fcranes.CalcFcranes(capacity, swl01, swl02, swl03, swl04, reach01, reach02, reach03, reach04);
            fL = fcranes;

            // fw Factor for speed reduction at sea

            // fm Factor for ice-classed ships having IA Super and IA

            double fM;
            fM = Fm.CalcFm(iceClass);

            // Attained EEXI

            double attEEXI = fJ * (pME * factorCfME * sfcME + factorCfAE * sfcAE) / (fI * capacity * vREF * fM);


            // Output Calculation results  ----------------------------------------------------------------------

            Console.WriteLine("EEDI Reference line value " + refLineValueEEDI);
            Console.WriteLine("Reduction Factor " + redFactor);
            Console.WriteLine("\nRequired EEXI " + reqEEXI);

            Console.WriteLine("\n----------------------------------------------------------------------------\n");

            Console.WriteLine("Power of ME (s) " + pME + " kW");
            Console.WriteLine("Cf of ME " + factorCfME + " t*C02/t*Fuel");
            Console.WriteLine("SFC of ME " + sfcME + " g/kWh");
            Console.WriteLine("\n");

            Console.WriteLine("Power of AEs " + pAE + " kW");
            Console.WriteLine("Cf of AE " + factorCfAE + " t*C02/t*Fuel");
            Console.WriteLine("SFC of AE " + sfcAE + " g/kWh");
            Console.WriteLine("\n");

            Console.WriteLine("Capacity " + capacity + " tons");
            Console.WriteLine("\n");

            Console.WriteLine("Vref " + vREF + " knots");
            Console.WriteLine("\n");

            Console.WriteLine("Correction factors");
            Console.WriteLine("Fj " + fJ);
            Console.WriteLine("Fi " + fI);
            Console.WriteLine("Fl " + fL);
            Console.WriteLine("Fm " + fM);

            /*Console.WriteLine("Fc " + fC);
            Console.WriteLine("Fw " + fW);*/


            Console.WriteLine("\nAttained EEXI " + attEEXI);

            Console.WriteLine("\n----------------------------------------------------------------------------\n");


            // Conclusion ---------------------------------------------------------------------------------------


            Console.WriteLine("\nConclusion------------------------------------------------------------------\n");


            if (attEEXI <= reqEEXI)
            {
                Console.WriteLine("Attained EEXI less or equal Required EEXI \n " +
                                  "Since the attained EEXI is less than the required EEXI,\n" +
                                  " then the vessel complies with the energy efficiency requirements");
            }
            else
            {
                Console.WriteLine("Attained EEXI more than Required EEXI \n " +
                                  "Since the resulting EEXI factor more requires the EEXI factor, \n" +
                                  "it is necessary to provide an action to improve the energy efficiency of consumption. ");
            }

            Console.ReadKey();
        }
    }
}