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
            string response = "";
            List<User> userList = new List<User>();
            List<Comment> commentList = new List<Comment>();


            while (response!="5")
            {
                Console.WriteLine("1. Create a User");
                Console.WriteLine("2. Creat a Comment");
                Console.WriteLine("3. Print the List of Users");
                Console.WriteLine("4. Print the List of Comments");
                Console.WriteLine("5. Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option")
                response = Console.ReadLine();

                switch(response)
                {
                    case "1":
                        User user = new User();
                        user.Email = "myemail@somewhere.com";
                        user.Password = "password";

                        userList.Add(user);

                        Console.WriteLine("You have created a user");
                        break;
                    case "2":
                        Comment myComment = new Comment();
                        myComment.CommentType = "Happy";

                        commentList.Add(myComment);

                        Console.WriteLine("You have created a comment");
                        break;
                    case "3":
                        Console.WriteLine("This is the list of the users created:");

                        foreach (var insideUser in userList)
                        {
                            Console.WriteLine("The user email is:" + insideUser.Email);
                            Console.WriteLine("The user password is:" + insideUser.Password);
                        }
                        break;
                    case "4":
                        Console.WriteLine("This is the list of the comments created:");

                        foreach (var insideComment in commentList)
                        {
                            Console.WriteLine("The comment type is:" + insideComment.CommentType);
                        }
                        break;
                }
            }
        }
    }
}
