using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {

        //Implement a method that accepts 3 integer values a, b, c. The method should return true if a triangle can be built with the sides of given length and false in any other case.
        //(In this case, all triangles must have surface greater than 0 to be accepted).

        static void Main(string[] args)
        {
            Console.WriteLine("Can you built triangle? - " + IsTriangle(-1,2,3));
            Console.WriteLine("Can you built triangle? - " + IsTriangle(3, 4, 3));
            Console.WriteLine("Can you built triangle? - " + IsTriangle(10, 2, 3));

        }

        public static bool IsTriangle(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
                return false;

            int TheLongestSide = 0;
            int OtherSide1 = 0;
            int OtherSide2 = 0;

            if (a > b && a > c)
            {
                TheLongestSide = a;
                OtherSide1 = b;
                OtherSide2 = c;
            }
            else if (b > a && b > c)
            {
                TheLongestSide = b;
                OtherSide1 = a;
                OtherSide2 = c;
            }
            else if (c > a && c > b)
            {
                TheLongestSide = c;
                OtherSide1 = a;
                OtherSide2 = b;
            }


            return TheLongestSide < OtherSide1 + OtherSide2? true : false;
        }
    }
}
