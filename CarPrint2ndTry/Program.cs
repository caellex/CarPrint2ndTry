namespace CarPrint2ndTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("NF123456", 147, 200, "green", "light vehicle", "km/t");
            car1.PrintInfo();

            var car2 = new Car("NF654321", 150, 195, "blue", "light vehicle", "km/t");
            car2.PrintInfo();

            var plane = new Plane("LN1234", 1000, 30, 2, 10, "jetplane");
            plane.PrintInfo();

            var boat = new Boat("ABC123", 100, 30, 500, "knop");
            boat.PrintInfo();

            car1.Run();
            car2.Run();

            plane.Run();    
        }
    }
}
