using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrint2ndTry
{
    internal class Car : VehicleWithMaxSpeed
    {
        private string _color;
        private string _type;

        public Car(string licenseplate, int effect, int maxspeed, string color, string type, string speedType) : base(licenseplate, effect, maxspeed, speedType)
        {
            _color = color;
            _type = type;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Car -");
            base.PrintInfo();
            Console.WriteLine($"Color: {_color}");
            Console.WriteLine($"Type: {_type}\n");
        }

        public override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kjører bilen.\n");
            Console.ResetColor();
        }


    }
}
