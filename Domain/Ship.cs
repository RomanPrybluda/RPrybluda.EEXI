using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPrybluda.EEXI.Domain
{
    public class Ship
    {
        public string ShipName { get; set; }
        public uint IMOnumber { get; set; }
        public string ShipType { get; set; }
        public double Deadweight { get; set; }
        public double IceClass { get; set; }

        public Ship (string shipName, uint imoNumber, string shipType, double deadweight, string iceClass)
        {
            ShipName = shipName;
            IMOnumber = imoNumber;
            ShipType = shipType;
            Deadweight = deadweight;
            IceClass = iceClass;
        }
    }
}
