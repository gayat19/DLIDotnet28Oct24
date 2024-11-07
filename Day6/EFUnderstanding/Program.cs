using EFUnderstanding.Contexts;
using EFUnderstanding.Models;

ShoppingContext context = new ShoppingContext();
//var customers = context.Customers;
//foreach (var customer in customers)
//    Console.WriteLine(customer);

User user1 = new User() { Username = "monu", Password = "1111" };
User user2 = new User() { Username = "lumu", Password = "2222" };
context.Users.Add(user1);
context.Users.Add(user2);
//You decide user1 need not be added due to a condition
context.Entry<User>(user1).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;
Console.WriteLine(context.Entry<User>(user1).State);
context.SaveChanges();
Console.WriteLine(context.Entry<User>(user1).State);


var users = context.Users;
foreach (var user in users)
    Console.WriteLine(user.Username+"        "+user.Password);
