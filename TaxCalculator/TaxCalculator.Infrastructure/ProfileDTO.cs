using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Infrastructure
{
    public class ProfileDTO
    {
        public int Age { get; private set; }
        public double Income { get; private set; }
        public double Bonus { get; private set; }
        public Constants.Gender Gender { get; private set; }
        public double Deduction { get; private set; }

        public ProfileDTO(int age, double income, double bonus, Constants.Gender gender, double deduction)
        {
            Age = age;
            Income = income;
            Bonus = bonus;
            Gender = gender;
            Deduction = deduction;
        }
    }
}
