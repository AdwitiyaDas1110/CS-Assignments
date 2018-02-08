using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------Question 3a------------------------------//
            var pm_list = new Dictionary<double, string>
            {
                {1998, "Atal Bihari Bajpai"},
                {2014, "Narendra Modi"},
                {2004, "Manmohan Singh"},
            };

            //----------------------------Question 3bi----------------------------//
            if (pm_list.ContainsKey(2004))
            {
                Console.WriteLine("Prime Minister for 2004 is " + pm_list[2004]);
            }
            Console.WriteLine("----------------------------------------------------");

            //----------------------------Question 3bii----------------------------//
            pm_list.Add(2018, "Narendra Modi");
            Console.WriteLine("After adding current prime minister of India to the Dictionary:");
            foreach (var pm in pm_list)
            {
                Console.WriteLine(pm.Key + " " + pm.Value);
            }
            Console.WriteLine("----------------------------------------------------");


            //----------------------------Question 3biii-----------------------------//
            var readOnlyDictionary = new ReadOnlyDictionary<double, string>(pm_list);
            Console.WriteLine("After making a read-only dictionary:");
            foreach (var pm in readOnlyDictionary)
            {
                Console.WriteLine(pm.Key + " " + pm.Value);
            }
            Console.WriteLine("------------------------------------------------------");


            //----------------------------Question 3biv-----------------------------//
            Console.WriteLine("After sorting the dictionary by keys");
            var ordered_pm_list = pm_list.OrderBy(k => k.Key);
            foreach (var pm in ordered_pm_list)
            {
                Console.WriteLine(pm.Key + " " + pm.Value);
            }
            Console.WriteLine("------------------------------------------------------");


        }

    }
}
