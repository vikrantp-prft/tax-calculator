using TaxCalculator.Infrastructure;
using static TaxCalculator.Infrastructure.Constants;

namespace TaxCalculator.Implementation
{
    public class IndiaTaxCategory : ITaxCategory
    {
        TaxCategory ITaxCategory.GetCategory(int Age, Gender gender)
        {
            if (Age.IsWithinRangeIncludingLimits(18, 60))
            {                
                if (gender.Equals(Gender.Male))
                {
                    return TaxCategory.WorkingMaleCitizen;
                }
                else
                {
                    return TaxCategory.WorkingFemaleCitizen;
                }

            }
            else if (Age.IsWithinRangeIncludingUpperLimit(60, 80))
            {
                return TaxCategory.SeniorCitizen;
            }
            else if (Age >= 80)
            {
                return TaxCategory.SuperSeniorCitizen;
            }
            else
            {
                return TaxCategory.Minor;
            }
        }


    }
}
