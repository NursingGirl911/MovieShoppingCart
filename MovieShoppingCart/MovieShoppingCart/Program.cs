using System;
using MovieShoppingCart.DTOS;
using MovieShoppingCart.MyClasses;

namespace MovieShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDateTimeVariable = new DateTime(1995, 04, 09, 11, 41, 00);
            DateTime myDateTimeVariable2 = new DateTime(2019, 09, 25, 01, 11, 00);

            if (myDateTimeVariable < myDateTimeVariable2)
            {
                Console.WriteLine("Yes, the value is less");
            }
        }
    }
}
