using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrint2ndTry
{
    internal class VehicleWithMaxSpeed : Vehicle
    {
        private int _maxspeed;
        private string _speedType;

        public VehicleWithMaxSpeed(string licenseplate, int effect, int maxspeed, string speedType) : base(licenseplate, effect)
        {
            _maxspeed = maxspeed;
            _speedType = speedType;
        }

        public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Max Speed: {_maxspeed}{_speedType}");
        }

        public override void Run()
        {
        }
    }
}
