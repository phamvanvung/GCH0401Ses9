using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqOverGenericCollection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>() { 
                new Car{PetName = "Henry", Color="Silver", Speed = 100, Make="BMV"},
                new Car{PetName = "Daisy", Color="Tan", Speed = 90, Make="BMV"},
                new Car{PetName = "Mary", Color="Black", Speed = 55, Make="VW"},
                new Car{PetName = "Clunker", Color="Rust", Speed = 5, Make="Yugo"},
                new Car{PetName = "Melvin", Color="White", Speed = 43, Make="Ford"},
            };
            GetFastCar(cars);
            GetFastBMVs(cars);
            Console.ReadLine();
        }
        public static void GetFastCar(List<Car> cars){
            var fastCars = from c in cars
                           where c.Speed > 55
                           select c;
            foreach (var item in fastCars)
            {
                Console.WriteLine($"{item.PetName} is going too fast");
            }

        }
        //Demonstrate => can use multiple conditions
        public static void GetFastBMVs(List<Car> cars){
            var fastBMVs = from c in cars
                           where c.Speed > 55 && c.Make.Equals("BMV")
                           select c;
            foreach (var item in fastBMVs)
            {
                Console.WriteLine($"The BMV {item.PetName} is going too fast");
            }
        }
    }
}
