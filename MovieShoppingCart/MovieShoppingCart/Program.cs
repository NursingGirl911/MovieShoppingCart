using System;
using MovieShoppingCart.DTOS;
using MovieShoppingCart.MyClasses;

namespace MovieShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            for(int x=1;x<21;x++) //3
            {
                result = result + x; //6
            }

            Console.WriteLine(result); 
        }
    }
}
