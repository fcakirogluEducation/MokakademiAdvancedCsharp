// See https://aka.ms/new-console-template for more information
using ConsoleApp.SOLID.OCP;

Console.WriteLine("Hello, World!");

var salaryCalculator = new SalaryCalculator();

Console.WriteLine($"High Salary :   {salaryCalculator.BadCalculate(1000, SalaryType.High)}");
Console.WriteLine($"High Salary :   {salaryCalculator.GoodCalculate(1000, new HighSalaryCalculator())}");
Console.WriteLine($"Manager Salary :   {salaryCalculator.GoodCalculate(1000, new ManagerSalaryCalculator())}");