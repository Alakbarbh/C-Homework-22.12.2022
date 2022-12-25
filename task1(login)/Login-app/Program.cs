
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;


IAccount account = new Account();




Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("emaili yazin");

Console.ResetColor();

string email = Console.ReadLine();


Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("passwordu yazin");

Console.ResetColor();

string password = Console.ReadLine();



Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("roles yazin");

Console.ResetColor();

int roles = int.Parse(Console.ReadLine());




Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine(account.Login(email,password,roles));

Console.ResetColor();


