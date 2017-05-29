using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqOverArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            string[] currentVideoGames = {"Morrowind", "Uncharted 2", 
                "Fallout 3", "Daxter", "System Shock 2" };
            //Write a Linq query to seelct games with name contains space
            IEnumerable<string> result = from g in currentVideoGames
                                         where g.Contains(" ")
                                         orderby g
                                         select g;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
