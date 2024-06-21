using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrint2ndTry
{
    internal class Plane : Vehicle
    {
        private int _wingspan;
        private int _loadcap;
        private int _weight;
        private string _type;

        public Plane(string licenseplate, int effect, int wingspan, int loadcap, int weight, string type) : base(licenseplate, effect)
        {
            _wingspan = wingspan;
            _loadcap = loadcap;
            _weight = weight;
            _type = type;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Plane -");
            base.PrintInfo();
            Console.WriteLine($"Wingspan: {_wingspan}m");
            Console.WriteLine($"Loadcap: {_loadcap}t");
            Console.WriteLine($"Weight: {_weight}t");
            Console.WriteLine($"Type: {_type}\n");
        }

        public override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Flyr flyet.\n");
            Console.ResetColor();
        }
    }
}
