// See https://aka.ms/new-console-template for more information

using ConsoleApp;
using ConsoleApp.Events;
using ConsoleApp.HasAIsA;


Console.WriteLine("Hello, World!");

SuperCar c = new SuperCar();
c.Forward();

if(true)
{
    c.ChangeLeftOrRightBehavior(new Car50LeftOrRightBehavior());
}

c.Backward();
c.Right();
c.Left();
    


#region Events topic
//var product = new Product();

//product.Id = 1; product.Name = "Kalem 1";


//product.StockCheckEvent += (sender, arg) =>
//{

//    Console.WriteLine($"stock aşıldı. güncel stock miktar={arg.StockCount}");

//};



//Enumerable.Range(490, 20).ToList().ForEach(x =>
//{
//    Console.WriteLine($"Güncel stock={x}");
//    product.Stock = x;
//}); 
#endregion

#region Delegate Topic
// Action =>  
//Action<int> action = (a) => Console.WriteLine(a);

//Action<int> action2 = (a) => Console.WriteLine(a);
//Predicate<int> predicate = (a) => a > 5;

//Func<int, int, int> func = (a, b) => a + b;

////multicast delegate
//action += action2;
//action -= action2;
//action.Invoke(10);



//var myDelegate = new MyDelegate();
//Sum mySum = sum;
//Sum mySumInstance = (a, b) => a + b;
//Sum mySumInstance2 = delegate (int a, int b) { return a + b; };

//Console.WriteLine(mySumInstance(10, 10));

//int result = myDelegate.Calculate(5, 10, sum);

//Console.WriteLine(result);


//static int sum(int a, int b)
//{
//	return a + b;
//} 
#endregion

//var productFactory = new ProductRepositoryFactory();

//var productService = new ProductService(productFactory.CreateOracle());

//foreach (var productDto in productService.GetAll())
//    Console.WriteLine($"{productDto.Id} {productDto.Name} {productDto.Created}");

#region LSP
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
#endregion

#region OCP

//var salaryType = SalaryType.Manager;
//var salaryCalculator = new SalaryCalculator();
//Console.WriteLine($"High Salary :   {salaryCalculator.BadCalculate(1000, SalaryType.High)}");
//Console.WriteLine($"High Salary :   {salaryCalculator.GoodCalculate(1000, new HighSalaryCalculator())}");
//Console.WriteLine($"Manager Salary :   {salaryCalculator.GoodCalculate(1000, new ManagerSalaryCalculator())}");

//Console.WriteLine("------------------");





//Dictionary<SalaryType, Func<decimal, decimal>> calculate = new();
//calculate.Add(SalaryType.High, new HighSalaryCalculatorWithDelegate().Calculate);
//calculate.Add(SalaryType.Manager, new ManagerSalaryCalculatorWithDelegate().Calculate);
//Console.WriteLine($"High Salary :   {calculate[salaryType](1000)}");



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