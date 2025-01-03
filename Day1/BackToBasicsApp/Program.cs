﻿////int num1 = 0;
////num1 = null;//Not possible because int is primitive value type
//int? num1 =10;
////num1 = null;//possible because its a nullable type

//int num2 = (num1??0) + 100;//num1 is null it will take 0 as the value- we have acheived this usinga  null collasing operator
//Console.WriteLine($"The value of num2 is {num2}");//interpllation- feature of C#8 and above

using BackToBasicsApp.Interfaces;
using BackToBasicsApp.Models;
using BackToBasicsApp.Repositories;

//Product product = new Product() { Id = 101, Name = "Pencil", Price = 5, Quantity = 10, BasicImgae = "" };
//Media pencilMedia = new UpdatedMedia { Id = 1, ProductId = 101, MediaType = ProductMediaType.Video };
////Console.WriteLine(product);
////Console.WriteLine(pencilMedia);
//ProductRepository repository = new ProductRepository();
//try
//{
//    repository.Add(product);
//}
//catch (Exception e)
//{
//    Console.WriteLine(product+" - "+e.Message);
//}

IRepository<int,Customer> customerRepository = new CustomerRepository();
customerRepository.Add(new Customer { Id = 1, Name = "ramu", Phone = 1234567890, Email = "ramu@gmail.com" });
customerRepository.Add(new Customer { Id = 2, Name = "somu", Phone = 9876543210, Email = "somu@gmail.com" });
Console.WriteLine(customerRepository.Get(2));
customerRepository.Update(2, new Customer { Id = 2, Name = "bimu", Phone = 9876543210, Email = "bimu@gmail.com" });
var customers = customerRepository.GetAll();
foreach (var customer in customers)
    Console.WriteLine(customer);