using EFUnderstanding.Contexts;
using EFUnderstanding.Models;
using EFUnderstanding;

internal class Program
{
    Program()
    {
        
    }
    private static void Main(string[] args)
    {
        ShoppingContext context = new ShoppingContext();
        //var customers = context.Customers;
        //foreach (var customer in customers)
        //    Console.WriteLine(customer);

        //User user1 = new User() { Username = "monu", Password = "1111" };
        //User user2 = new User() { Username = "lumu", Password = "2222" };
        //context.Users.Add(user1);
        //context.Users.Add(user2);
        ////You decide user1 need not be added due to a condition
        //context.Entry<User>(user1).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
        //Console.WriteLine(context.Entry<User>(user1).State);
        //context.SaveChanges();
        //Console.WriteLine(context.Entry<User>(user1).State);


        //var users = context.Users;
        //foreach (var user in users)
        //    Console.WriteLine(user.Username+"        "+user.Password);
        var usersList = from user in context.Users
                        where user.Username.Contains("r") select user;

        //var usersList = context.Users.Where(u => u.Username.Contains("r"));
        foreach (var user in usersList)
            Console.WriteLine(user.Username + "        " + user.Password);

        //string username = "admin username";
        //bool checkResult = username.CheckSub("username");
        //Console.WriteLine("Check sub string "+checkResult);
    }

    
}