using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RPrybluda.EEXI.Domain;


namespace RPrybluda.EEXI.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public static double sfcME;

        double sfcMEin75 = 231.86;
        double sfcMEin50 = 209.38;

        double mcrME = 5296;
        double mcrMElim = 3620;


        [Test]
        public void Test_sfcME ()
        {

            if (sfcME == 0)
            {
                sfcME = SFCapp.SFCmeApp;
            }

            if (sfcME > 0 & mcrMElim == 0)
            {
                sfcME = sfcMEin75;
            }

            if (sfcME > 0 & 0.83 * mcrMElim < 0.75 * mcrME)
            {
                sfcME = sfcMEin75 + (sfcMEin50 - sfcMEin75) * (0.83 * mcrMElim - 0.75 * mcrME) / (0.5 * mcrME - 0.75 * mcrME);
            }

            Assert.IsTrue(sfcME == 212.622);
        }
    }
}