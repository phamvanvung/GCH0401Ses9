using System;

namespace AnonymousTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var purchaseItem = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new {Color = "Red", Make="Saab", CurrentSpeed=55}
            };
            //Access to the object.
            Console.WriteLine($"Color: {purchaseItem.ItemBought.Color}" +
                              $", Make: {purchaseItem.ItemBought.Make}" +
                              $", Current speed: {purchaseItem.ItemBought.CurrentSpeed}" +
                              $", Bought at: {purchaseItem.TimeBought}");
        }
    }
}
