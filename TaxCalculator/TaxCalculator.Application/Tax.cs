using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Implementation;
using TaxCalculator.Infrastructure;

namespace TaxCalculator.Application
{
    public class Tax
    {
        ProfileDTO _profile;
        ITaxCategory _taxCategroy;
        ITaxManager _taxManager;

        public Tax(ProfileDTO profle)
        {
            _profile = profle;
            _taxCategroy = new IndiaTaxCategory();
            _taxManager = new IndiaTaxManager();
        }

        public Tax(ProfileDTO profle, ITaxCategory taxCategory, ITaxManager taxManager)
        {
            _profile = profle;
            _taxCategroy = taxCategory;
            _taxManager = taxManager;
        }

        public TaxResultDTO Calculate()
        {
            // -- Business flow
            // 1. Get Tax Category
            // 2. Get Taxable Amount
            // 3. Get Tax Slab 
            // 4. Get Tax
            // 5. Return result

            var userTaxCategroy = _taxCategroy.GetCategory(_profile.Age, Constants.Gender.Male);

            double taxableIncome = _taxManager.GetTaxableIncome(_profile.Income, _profile.Bonus, _profile.Deduction);

            int taxPercentage = _taxManager.GetTaxPercentage(userTaxCategroy, taxableIncome);

            double calculatedTax = _taxManager.GetTax(taxableIncome, taxPercentage);

            return new TaxResultDTO(_profile.Age, _profile.Income, _profile.Bonus, _profile.Gender, _profile.Deduction)
            {
                Tax = calculatedTax,
                TaxableAmount = taxableIncome

            };
        }
    }
}
