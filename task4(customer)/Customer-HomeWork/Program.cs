


using DomainLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;

ICustomers customer = new Customers();


Customer customer1 = new Customer(1, "Eycahan", "Qurbanov", 19, "FullStack");
Customer customer2 = new Customer(2, "Konul", "Ibrahimova", 26, "FullStack");
Customer customer3 = new Customer(3, "Ali", "Talibov", 26, "FullStack");
Customer customer4 = new Customer(4, "Shaig", "Kazimov", 25, "FullStack");
Customer customer5 = new Customer(5, "Cavid", "Ismayilzadeh", 23, "FullStack");
Customer customer6 = new Customer(6, "Cahandar", "Velibeyli", 26, "FullStack");

Customer[] customers = { customer1, customer2, customer3, customer4, customer5, customer6 };


Console.WriteLine(customer.GetCustomersAges(customers));