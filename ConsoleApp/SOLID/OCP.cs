namespace ConsoleApp.SOLID.OCP
{

    public enum SalaryType
    {
        Low,
        Medium,
        High,
        Manager
    }

    public interface ISalaryCalculator
    {
        decimal Calculate(decimal baseSalary);
    }

    public class LowSalaryCalculator : ISalaryCalculator
    {
        public decimal Calculate(decimal baseSalary)
        {
            return baseSalary + 1000;
        }
    }

    public class MiddleSalaryCalculator : ISalaryCalculator
    {
        public decimal Calculate(decimal baseSalary)
        {
            return baseSalary + 2000;
        }
    }

    public class HighSalaryCalculator : ISalaryCalculator
    {
        public decimal Calculate(decimal baseSalary)
        {
            return baseSalary + 3000;
        }
    }

    public class ManagerSalaryCalculator : ISalaryCalculator
    {
        public decimal Calculate(decimal baseSalary)
        {
            return baseSalary + 4000;
        }
    }


    public class SalaryCalculator
    {

        public decimal GoodCalculate(decimal baseSalary, ISalaryCalculator salaryCalculator)
        {

          return  salaryCalculator.Calculate(baseSalary);
        }

        public decimal BadCalculate(decimal baseSalary,SalaryType salaryType)
        {
            decimal newSalary = 0;

            switch (salaryType)
            {
                case SalaryType.Low:
                    newSalary = baseSalary + 1000;
                    break;
                case SalaryType.Medium:
                    newSalary = baseSalary + 2000;
                    break;
                case SalaryType.High:
                    newSalary = baseSalary + 3000;
                    break;

            }

            return newSalary;



        }



    }


}
