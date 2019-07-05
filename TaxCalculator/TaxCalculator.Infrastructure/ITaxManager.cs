using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Infrastructure
{
    public interface ITaxManager
    {
        double GetTaxableIncome(double Income, double Bonus, double Deduction);

        int GetTaxPercentage(Constants.TaxCategory taxCategory, double taxableIncome);

        double GetTax(double Amount, int taxPercentage);



    }
}
