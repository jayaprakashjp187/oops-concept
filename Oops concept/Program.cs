using Oops_concept.inheritance;
using System.Security.Cryptography.X509Certificates;

namespace Oops_concept
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("welcome to the object oriented programs");
            Console.WriteLine("1.inheritance program\n2.polymorphism program");
            int choose =Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("welcome to the inheritance program");
                    Car j = new Car();
                    j.carName = "kia sonet";
                    j.carModel = 2021;
                    j.vehicleType = "car";
                    j.VehicleDetails();
                    Console.WriteLine("vehicle type is " + j.vehicleType);

                    j.CarDetails();
                    Console.WriteLine("car name is " + j.carName);
                    Console.WriteLine("car model is " + j.carModel);
                    //using static method practice
                    //Car.carName = "kia";
                    //Car.carModel = 2011;
                    //Car.CarDetails();
                    //Console.WriteLine("car name is " + Car.carName);
                    //Vehicle.vehicleType = "car";
                    //Vehicle.VehicleDetails();
                    break;
                 case 2:
                    Console.WriteLine("welcome to the polymorphism program");
                    
                    Calculator cal = new Calculator();
                    cal.Add(5,4.5);
                    cal.Add(5, 4);

                    break;




            }

        }
    }
}