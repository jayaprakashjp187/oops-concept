using Oops_concept.inheritance;

namespace Oops_concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the object oriented programs");
            Console.WriteLine("1.inheritance program");
            int choose =Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:

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




            }

        }
    }
}