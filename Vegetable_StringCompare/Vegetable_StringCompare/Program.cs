using System;
using System.Collections.Generic;
using System.Linq;

namespace Vegetable_StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> veg = new List<string>()
            {
                "Tomato","Potato","ToMato","Potato",
                "Red Tomato","Tomato Catchup", "Grapes",
                "grapes", "potato"
            };

            //-----------------------------------Q1a------------------------------------//
            var tomato_array = veg.FindAll(x => x.ToLower() == "tomato");
            Console.WriteLine("The number of tomato strings is: " + tomato_array.Count);
            Console.WriteLine("-----------------------------------------------------");

            //-----------------------------------Q1b------------------------------------//
            if (veg.Contains("Potato"))
            {
                for (var i = 0; i < veg.Count; i++)
                {
                    if (String.Equals(veg.ElementAt(i), "Potato", StringComparison.Ordinal))
                        Console.WriteLine("Potato present at index : " + i);
                }
            }

            else
            {
                Console.WriteLine("Potato not present");
            }
            Console.WriteLine("-----------------------------------------------------");

        }
    }
}
