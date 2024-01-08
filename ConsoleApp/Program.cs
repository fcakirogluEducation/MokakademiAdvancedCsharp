// See https://aka.ms/new-console-template for more information

using ConsoleApp.SOLID;
using ConsoleApp.SOLID.LSP;
using ConsoleApp.SOLID.OCP;

Console.WriteLine("Hello, World!");

var productFactory = new ProductRepositoryFactory();

var productService = new ProductService(productFactory.CreateOracle());

foreach (var productDto in productService.GetAll())
{
    Console.WriteLine($"{productDto.Id} {productDto.Name} {productDto.Created}");
}

// Phone phone = new IPhone12();
//
// phone.Call();
//
// if(phone is IPhone12 phone12)
// {
//     phone12.TakePhoto();
// }
//
//
//
//
// phone = new Nokia();
//
// phone.Call();




#region OCP
//var salaryType = SalaryType.High;
//var salaryCalculator = new SalaryCalculator();
//Console.WriteLine($"High Salary :   {salaryCalculator.BadCalculate(1000, SalaryType.High)}");
//Console.WriteLine($"High Salary :   {salaryCalculator.GoodCalculate(1000, new HighSalaryCalculator())}");
//Console.WriteLine($"Manager Salary :   {salaryCalculator.GoodCalculate(1000, new ManagerSalaryCalculator())}");

//Console.WriteLine("------------------");


//switch (salaryType)
//{
//	case SalaryType.Low:
//		break;
//	case SalaryType.Medium:
//		break;
//	case SalaryType.High:
//		Console.WriteLine($"High Salary :   {salaryCalculator.GoodCalculateByDelegate(1000, new HighSalaryCalculatorWithDelegate().Calculate)}");
//		break;
//	case SalaryType.Manager:
//		Console.WriteLine($"Manager Salary :   {salaryCalculator.GoodCalculateByDelegate(1000, new ManagerSalaryCalculatorWithDelegate().Calculate)}");
//		break;
//	default:
//		break;
//}

#endregion



