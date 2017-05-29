using System;
using System.Reflection;

namespace Ses9Extensions
{
    public static class MyExtensions
    {
        //Define/add new method to the object class
        public static void DefiningDisplayAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here {1}", obj.GetType().Name,
                              Assembly.GetAssembly(obj.GetType())
                             );
        }
    }
}
