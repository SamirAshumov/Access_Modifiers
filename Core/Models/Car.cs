using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Car
    {

        private string _carCode;
        private string _name;
        private int _speed;
        private static int _id { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }

        public int Speed { get; set; }


        public Car() { }

        public Car(string name, int speed, string carcode)
        {
            Name = name;
            Speed = speed;
            CarCode = carcode;
            _id++;
            Id = _id;
        }



        public string CarCode
        {
            get { return _carCode; }
            set
            {
                if (value == null || value.Length > 6)
                {
                    Console.WriteLine("Kodun yazilis standarti duzgun deyil");
                }

            

                if (Regex.IsMatch(value, @"^[A-Z]{2}\d{4,}$"))
                {
                    _carCode = value;
                }
                else
                {
                    Console.WriteLine("Kodun yazilis standarti duzgun deyil");
                }
            }
        }
    }



}

