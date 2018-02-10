using System;

namespace XY_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            float X = 0.06f, Y = 5.94f;
            float sum = X + Y;
            //-------------------------------Q2a--------------------------//
            Console.WriteLine("X + Y = " + sum);
            Console.WriteLine("---------------------------------------------");


            //-------------------------------Q2a--------------------------//
            Console.WriteLine("(X+Y) == 6 ? :" + (sum == 6));
            Console.WriteLine("---------------------------------------------");


            //-------------------------------Q2a--------------------------//
            Console.WriteLine(((X > Y) ? "X" : "Y") + " has greater value");
            Console.WriteLine("---------------------------------------------");

        }
    }
}
