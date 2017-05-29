using System;
using System.Linq;
namespace DifferedExecution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 10, 20, 5, 25 };
            //Select all numbers which are < 10
            var subset = from i in numbers
                         where i < 10
                         select i;
            Console.WriteLine("Evaluate for the first time");
            //Evaluate it for the first time
            foreach (var item in subset)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine("Change the data");
            numbers[3] = 4;
            Console.WriteLine("Evaluate it again, after changing data");
            foreach (var item in subset)
            {
                Console.Write($"{item}\t");
            }
            Console.ReadLine();
        }
    }
}
