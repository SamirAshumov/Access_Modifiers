using Core.Models;
namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gallery gallery = new Gallery();

            Car car1 = new Car("Toyota Camry", 225, "LE1001" );
            gallery.AddCar( car1 );
            Car car2 = new Car("Hyundai Sonata", 220, "LE1002");
            gallery.AddCar( car2 );
            Car car3 = new Car("Ford Fusion", 225, "LE1003");
            gallery.AddCar( car3 );
            Car car4 = new Car("Toyota RAV4", 180, "LE1004");
            gallery.AddCar( car4 );
            Car car5 = new Car("Hyundai Elantra", 200, "LE1005");
            gallery.AddCar( car5 );
            Car car6 = new Car("Kia Optima", 225, "LE1006");
            gallery.AddCar( car6 );
            Car car7 = new Car("Chevrolet Malibu", 225, "LE1007");
            gallery.AddCar( car7 );



            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Butun masinlarin siyahisi");
            gallery.ShowAllCars();


            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Find Car By ID : ");
            gallery.FindCarById( 7 );


            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Find Car By Code : ");
            gallery.FindCarByCode("LE1008");



            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Find Car By Speed Interval : ");
            gallery.ShowAllCars(gallery.FindCarBySpeedInterval(200, 220));



        }
    }
}
