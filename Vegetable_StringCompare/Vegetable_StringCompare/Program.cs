using System;
using System.Collections.Generic;

namespace Vegetable_StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> veg = new List<string>()
            {
                "Tomato","Potato","ToMato","Potato","Red Tomato","Tomato Catchup", "Grapes","grapes", "potato"
            };

            //-----------------------------------Q1a------------------------------------//
            var tomato_list = veg.FindAll(x => x.ToLower() == "tomato");
            Console.WriteLine("The number of tomato strings is: " + tomato_list.Count);
            Console.WriteLine("-----------------------------------------------------");

            //-----------------------------------Q1b------------------------------------//
            if (veg.Contains("Potato"))
            {
                Console.WriteLine("Potato present at index : " + veg.IndexOf("Potato"));
            }
            else
            {
                Console.WriteLine("Potato not present");
            }
            Console.WriteLine("-----------------------------------------------------");

        }
    }
}
