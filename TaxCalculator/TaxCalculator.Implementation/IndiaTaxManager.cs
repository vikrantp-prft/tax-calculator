using TaxCalculator.Infrastructure;

namespace TaxCalculator.Implementation
{
    public class IndiaTaxManager : ITaxManager
    {
        double ITaxManager.GetTax(double Amount, int taxPercentage)
        {
            return Amount * taxPercentage / 100;
        }

        double ITaxManager.GetTaxableIncome(double Income, double Bonus, double Deduction)
        {
            return (Income + Bonus) - Deduction;
        }

        int ITaxManager.GetTaxPercentage(Constants.TaxCategory taxCategory, double taxableIncome)
        {
            int percentage = 0;

            switch (taxCategory)
            {
                case Constants.TaxCategory.SuperSeniorCitizen:
                    percentage = GetTaxPercentageForSuperSeniorCitizen(taxableIncome);
                    break;
                case Constants.TaxCategory.SeniorCitizen:
                    percentage = GetTaxPercentageForSeniorCitizen(taxableIncome);
                    break;
                case Constants.TaxCategory.WorkingMaleCitizen:
                    percentage = GetTaxPercentageForWorkingFemaleCitizen(taxableIncome);
                    break;
                case Constants.TaxCategory.WorkingFemaleCitizen:
                    percentage = GetTaxPercentaegForWorkingMaleCitizen(taxableIncome);
                    break;
                case Constants.TaxCategory.Minor:
                    break;
                default:
                    break;
            }

            return percentage;

        }

        private static int GetTaxPercentaegForWorkingMaleCitizen(double taxableIncome)
        {
            int percentage;

            if (taxableIncome.IsWithinRangeIncludingUpperLimit(0, 250000))
            {
                percentage = 0;
            }
            else if (taxableIncome.IsWithinRangeIncludingUpperLimit(250000, 500000))
            {
                percentage = 10;
            }
            else if (taxableIncome.IsWithinRangeIncludingUpperLimit(500000, 800000))
            {
                percentage = 20;
            }
            else
            {
                percentage = 30;
            }
                       
            return percentage;
        }

        private static int GetTaxPercentageForWorkingFemaleCitizen(double taxableIncome)
        {
            int percentage;
            if (taxableIncome.IsWithinRangeIncludingUpperLimit(0, 180000))
            {
                percentage = 0;
            }
            else if (taxableIncome.IsWithinRangeIncludingUpperLimit(180000, 500000))
            {
                percentage = 10;
            }
            else if (taxableIncome.IsWithinRangeIncludingUpperLimit(500000, 800000))
            {
                percentage = 20;
            }
            else
            {
                percentage = 30;
            }

            return percentage;
        }

        private static int GetTaxPercentageForSeniorCitizen(double taxableIncome)
        {
            int percentage;

            if (taxableIncome.IsWithinRangeIncludingUpperLimit(0, 250000))
            {
                percentage = 0;
            }
            else if (taxableIncome.IsWithinRangeIncludingUpperLimit(250000, 500000))
            {
                percentage = 10;
            }
            else if (taxableIncome.IsWithinRangeIncludingUpperLimit(500000, 800000))
            {
                percentage = 20;
            }
            else
            {
                percentage = 30;
            }

            return percentage;
        }

        private static int GetTaxPercentageForSuperSeniorCitizen(double taxableIncome)
        {
            int percentage;

            if (taxableIncome.IsWithinRangeIncludingUpperLimit(0, 500000))
            {
                percentage = 0;
            }
            else if (taxableIncome.IsWithinRangeIncludingUpperLimit(500000, 800000))
            {
                percentage = 10;
            }
            else
            {
                percentage = 20;
            }
            
            return percentage;
        }
    }
}
