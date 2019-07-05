using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Infrastructure
{
    public class TaxResultDTO : ProfileDTO
    {
        public TaxResultDTO(int age, double income, double bonus, Constants.Gender gender, double deduction)
            : base(age, income, bonus, gender, deduction)
        {
        }

        public double TaxableAmount { get; set; }
        public double Tax { get; set; }
    }
}
