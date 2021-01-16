using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> myInsta = new List<User>();

            User UserName = new User();
            User TotalViews = new User();
            User Likes = new User();
            User Comments = new User();

            myInsta.Add(UserName);
            myInsta.Add(TotalViews);
            myInsta.Add(Likes);
            myInsta.Add(Comments);



            List<User> newList = myInsta.Where(User => User.Comments == "List of Comments").ToList();

            foreach (var item in newList)
            {
                Console.Write("Comments: ");

            }


        }
    }
}
public class User
{
    public string UserName { get; set; } = string.Empty;
    public string Comments { get; internal set; }
}
public class MyViews
{
    public string TotalViews { get; set; }
}
public class MyLikes
{
    public string Likes { get; set; }
}
public class ListOfComments
{
    public string Comments { get; set; } = string.Empty;
}

