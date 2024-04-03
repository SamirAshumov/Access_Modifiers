using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Car[] cars = new Car[] { };

        public Car[] filteredCars = new Car[] { };

        
    public void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;            
        }

        public void ShowAllCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"ID: {car.Id} Name: {car.Name} Speed: {car.Speed} Code: {car.CarCode}");
            }
        }


        public void ShowAllCars(Car[] cars) 
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"ID: {car.Id} Name: {car.Name} Speed: {car.Speed} Code: {car.CarCode}");
            }
        }

        public Car[] GetAllCars()
        {
            return cars;
        }

        public void FindCarById(int id)
        {
            bool isIdFound = false;

            foreach (Car car in cars)
            {               

                if (car.Id == id)
                {
                    isIdFound = true;   
                    Console.WriteLine($"ID: {car.Id} Name: {car.Name} Speed: {car.Speed} Code: {car.CarCode}");
                }                                            
            }

           if (isIdFound == false)
            {
                Console.WriteLine("Verilen ID ile uygun masin yoxdur");
            }



        }

        public void FindCarByCode(string code)
        {
            bool IsCodeFound = false;

            foreach (Car car in cars)
            {                
                if (car.CarCode == code)
                {
                    IsCodeFound = true;
                    Console.WriteLine($"ID: {car.Id} Name: {car.Name} Speed: {car.Speed} Code: {car.CarCode}");
                }

               
            }

            if (IsCodeFound == false)
            {
                Console.WriteLine("Verilen Code uygun masin yoxdur");
            }
        }



        public Car[] FindCarBySpeedInterval(int min, int max)
        {
            foreach(Car car in cars)
            {
                if (car.Speed >= min &&  car.Speed <= max)
                {
                    Array.Resize(ref filteredCars, filteredCars.Length + 1);
                    filteredCars[filteredCars.Length - 1] = car;
                }               
            }

            return filteredCars;
        }


    }
}


