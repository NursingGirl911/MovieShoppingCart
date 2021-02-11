using System;
using System.Collections.Generic;
using MovieShoppingCart.DTOS;
using MovieShoppingCart.MyClasses;
using System.Linq;

namespace MovieShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                List<User> userList = new List<User>();

                User newUser1 = new User();
                newUser1.Email = email1@somewhere.com;
                newUser1.Password = "Password1";
                newUser1.UserId = 1;
                newUser1.UserName = "Brit";
                userList.Add(newUser1);

                User newUser2 = new User();
                newUser2.Email = email2@somewhere.com;
                newUser2.Password = "Password2";
                newUser2.UserId = 2;
                newUser2.UserName = "Alyssa";
                userList.Add(newUser2);

                User newUser3 = new User();
                newUser3.Email = email3@somewhere.com;
                newUser3.Password = "Password3";
                newUser3.UserId = 3;
                newUser3.UserName = "Mike";
                userList.Add(newUser3);

                User newUser4 = new User();
                newUser4.Email = email4@somewhere.com;
                newUser4.Password = "Password4";
                newUser4.UserId = 4;
                newUser4.UserName = "Dave";
                userList.Add(newUser4);

                User newUser5 = new User();
                newUser5.Email = email5@somewhere.com;
                newUser5.Password = "Password5";
                newUser5.UserId = 5;
                newUser5.UserName = "John";
                userList.Add(newUser5);

                User newUser6 = new User();
                newUser6.Email = email6@somewhere.com;
                newUser6.Password = "Password6";
                newUser6.UserId = 6;
                newUser6.UserName = "Aaron";
                userList.Add(newUser6);

                User newUser7 = new User();
                newUser7.Email = email7@somewhere.com;
                newUser7.Password = "Password7";
                newUser7.UserId = 7;
                newUser7.UserName = "Charlie";
                userList.Add(newUser7);

                User newUser8 = new User();
                newUser8.Email = email8@somewhere.com;
                newUser8.Password = "Password8;
                newUser8.UserId = 8;
                newUser8.UserName = "Eric";
                userList.Add(newUser8);

                User newUser9 = new User();
                newUser9.Email = email9@somewhere.com;
                newUser9.Password = "Password9";
                newUser9.UserId = 9;
                newUser9.UserName = "Nick";
                userList.Add(newUser9);

                User newUser10 = new User();
                newUser10.Email = email10@somewhere.com;
                newUser10.Password = "Password10";
                newUser10.UserId = 10;
                newUser10.UserName = "Kyle";
                userList.Add(newUser10);


                userList = userList.Where(user => user.UserName == "Brit").ToList();

                if (userList.Count > 0)
                {
                    Console.WriteLine("Users found and they have the following properties:");
                    string format = "My user has these properties:" +
                                    "Email: {0}, UserId: {1}, Password: {2}," +
                                    "UserName: {3}";

                    foreach (var item in userList)
                    {
                        Console.WriteLine(format, user.Email, user.UserId,
                                          user.Password, user.UserName);
                    }
                }
                else
                {
                    throw new UserNotFound("No users found for the specified query");
                }
                }
                catch(UserNotFound exception)
                {
                Console.WriteLine(exception.Message);
                }
                finally
                {
                Console.WriteLine("Program has ended");
                }
            

        }
    }
}

public class UserNotFound : Exception
{
    public UserNotFound(string errorMessage) : base(errorMessage)
    {

    }
}