using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------Question 2a-------------------//
            string[] words_array = new string[5] {"Boat",
                                                  "house",
                                                  "cat",
                                                  "river",
                                                  "cupboard" };

            //----------------------Question 2bi-------------------//
            Console.WriteLine("Plural of all words:");
            for(int i = 0; i< 5; i++)
            {
                words_array[i] += "s";
                Console.WriteLine(words_array[i]);
            }
            Console.WriteLine("---------------------------------------------");


            //----------------------Question 2bii-------------------//
            words_array[1] = "Homes";
            Console.WriteLine("After replacing 2nd word with its synonym, 2nd word in array: " + words_array[1]);
            Console.WriteLine("---------------------------------------------");


            //---------------------Question 2biii--------------------//
            Array.Resize(ref words_array, 6);
            words_array[5] = "clan";
            Console.WriteLine("After adding a word in array, array length: " + words_array.Length);
            Console.WriteLine("----------------------------------------------");


            //--------------------Question 2biv----------------------//
            var word_length_7 = Array.FindAll(words_array, x => x.Length == 7);
            Console.WriteLine("Words in the array with length 7:");
            if (word_length_7.Length == 0)
                Console.WriteLine("None");
            else
            {
                foreach (var item in word_length_7)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("---------------------------------------------");


            //--------------------Question 2bv----------------------//
            Console.WriteLine("The word on the 3rd position of the array : " + words_array[3]);
            Console.WriteLine("---------------------------------------------");


        
            //--------------------Question 2biv----------------------//
            Console.WriteLine("The words in ascending order: ");
            var orderedWordList = words_array.OrderBy(x => x);
            foreach(string str in orderedWordList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("---------------------------------------------");


            //--------------------Question 2biv----------------------//
            Console.WriteLine("Reversed Word array");
            Array.Reverse(words_array);
            foreach (string str in words_array)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("---------------------------------------------");

        }
    }
}
