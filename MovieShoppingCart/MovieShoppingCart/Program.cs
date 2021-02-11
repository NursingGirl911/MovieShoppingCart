using System;
using System.Collections.Generic;
using MovieShoppingCart.DTOS;
using MovieShoppingCart.MyClasses;

namespace MovieShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myFirstDateVariable = new DateTime(1995, 04, 09);
            DateTime mySecondDateVariable = new DateTime(2019, 09, 25);

            int result = DateTime.Compare(myFirstDateVariable, mySecondDateVariable);

            //1 = First date is greater than the second
            //0 = Means the two dates are equal
            //-1 = First date is not greater than the second

            if(result==1)
            {
                Console.WriteLine("The second date is greater");
            }
            else
            {
                Console.WriteLine("The first date is greater"); 
            }
        }
    }
}
