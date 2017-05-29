using System;
using System.Linq;
namespace ImmediateExecution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 10, 20, 5, 25 };
            int[] result = (from i in numbers
                           where i < 10
                            select i).ToArray();
            Console.WriteLine("Loop through it");
            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            //Change data
            numbers[3] = 4;
            Console.WriteLine("Evaluate again");
            //get the same result => coz of immediate execution
            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }
            Console.ReadLine();
        }
    }
}
