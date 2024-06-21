using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrint2ndTry
{
    internal class Boat : VehicleWithMax
    {
        private int _tonnage;
        public Boat(string licenseplate, int effect, int maxspeed, int tonnage, string speedType) : base(licenseplate, effect, maxspeed, speedType)
        {
            _tonnage = tonnage;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Boat -");
            base.PrintInfo();
            Console.WriteLine($"Tonnage: {_tonnage}t\n");
        }

        public override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kjører båten.\n");
            Console.ResetColor();
        }
    }
}
