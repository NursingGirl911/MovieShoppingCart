using System;
using MovieShoppingCart.DTOS;
using MovieShoppingCart.MyClasses;

namespace MovieShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            CommentDTO comment = new CommentDTO();
            comment.CommentType = "this is a comment";

            Console.WriteLine("The value of my property is: " + comment.CommentType);
        }
    }
}
