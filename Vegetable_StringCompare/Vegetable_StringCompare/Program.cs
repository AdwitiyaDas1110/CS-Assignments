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
                string index = "Potato present at index : ";
                for (var i = 0; i < veg.Count; i++)
                {
                    if (String.Equals(veg.ElementAt(i), "Potato", StringComparison.Ordinal))
                        index += i.ToString() + ",";  
                }
                Console.WriteLine(index.Substring(0,index.Length-1));
            }
            else
            {
                Console.WriteLine("Potato not present");
            }
            Console.WriteLine("-----------------------------------------------------");

        }
    }
}
