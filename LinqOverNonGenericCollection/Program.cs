using System;
using System.Collections;
using System.Linq;
namespace LinqOverNonGenericCollection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList cars = new ArrayList(){
                new Car{PetName = "Henry", Color="Silver", Speed = 100, Make="BMV"},
                new Car{PetName = "Daisy", Color="Tan", Speed = 90, Make="BMV"},
                new Car{PetName = "Mary", Color="Black", Speed = 55, Make="VW"},
                new Car{PetName = "Clunker", Color="Rust", Speed = 5, Make="Yugo"},
                new Car{PetName = "Melvin", Color="White", Speed = 43, Make="Ford"},
                10,
                "Car 1"
            };
            //Filter the list by the type
            var myCarsEnum = cars.OfType<Car>();
            //Apply Linq to generic data as normal
            var fastCars = from c in myCarsEnum
                           where c.Speed > 55
                           select c;
            foreach (var item in fastCars)
            {
                Console.WriteLine($"{item.PetName} is going too fast");
            }
            Console.ReadLine();
        }
    }
}
