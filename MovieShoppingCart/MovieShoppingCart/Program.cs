using System;
using MovieShoppingCart.MyClasses;

namespace MovieShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Image beach = new Image();
            beach.ImageSize = "this is a small image";

            Console.WriteLine("The value of my property is: " + beach.ImageSize);
        }
    }
}
