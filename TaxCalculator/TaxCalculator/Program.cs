using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Application;
using TaxCalculator.Implementation;
using TaxCalculator.Infrastructure;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {          

            Console.Write("Enter Your Annual Salary: ");
            var enteredSalary = Console.ReadLine();
            double salary = double.Parse(enteredSalary);

            Console.Write("Enter Your Bonus : ");
            var enteredBonus = Console.ReadLine();
            double bonus = double.Parse(enteredBonus);

            Console.Write("Enter Your Gender (M/F) : ");
            var enteredGender = Console.ReadLine();
            Constants.Gender gender;
            if (enteredGender.Equals("M", StringComparison.OrdinalIgnoreCase))
            {
                gender = Constants.Gender.Male;
            }
            else
            {
                gender = Constants.Gender.Female;
            }

            Console.Write("Enter Your Age in Years : ");
            var enteredAge = Console.ReadLine();
            int age = int.Parse(enteredAge);

            Console.Write("Declare 80c Deduction Amount : ");
            var entered80cAmount = Console.ReadLine();
            double deduction = double.Parse(entered80cAmount);

            ProfileDTO profile = new ProfileDTO(age, salary,bonus, gender, deduction);

            Tax tax = new Tax(profile, new IndiaTaxCategory(), new IndiaTaxManager());
            TaxResultDTO result = tax.Calculate();

            Console.WriteLine("---------- Tax Calculations ----------");
            Console.WriteLine($"Gender : {result.Gender.ToString()}");
            Console.WriteLine($"Age : {result.Age.ToString()}");
            Console.WriteLine($"Annual Salary : {result.Income.ToString()}");
            Console.WriteLine($"Bonus : {result.Bonus.ToString()}");
            Console.WriteLine($"80C deductions : {result.Deduction.ToString()}");
            Console.WriteLine($"Total taxable income : {result.TaxableAmount.ToString()}");
            Console.WriteLine($"Total tax : {result.Tax.ToString()}");
            Console.ReadKey();
        }
    }
}
