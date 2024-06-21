using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrint2ndTry
{
    internal abstract class Vehicle
    {
        private string _licenseplate;
        private int _effect;

        public Vehicle(string licenseplate, int effect)
        {
            _licenseplate = licenseplate;
            _effect = effect;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"License Plate: {this._licenseplate}");
            Console.WriteLine($"Effect: {this._effect}kw");
        }

        public abstract void Run();
    }
}
