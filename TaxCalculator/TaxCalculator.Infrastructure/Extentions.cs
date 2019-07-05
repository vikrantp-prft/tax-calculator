namespace TaxCalculator.Infrastructure
{
    public static class Extentions
    {

        #region Int Extentions
        public static bool IsWithinRangeIncludingLimits(this int value, int LowerLimit, int UpperLimit)
        {
            return (LowerLimit <= value && UpperLimit >= value);
        }

        public static bool IsWithinRangeIncludingLowerLimit(this int value, int LowerLimit, int UpperLimit)
        {
            return (LowerLimit <= value && UpperLimit > value);
        }

        public static bool IsWithinRangeIncludingUpperLimit(this int value, int LowerLimit, int UpperLimit)
        {
            return (LowerLimit < value && UpperLimit >= value);
        }

        public static bool IsWithinRangeExcludingLimits(this int value, int LowerLimit, int UpperLimit)
        {
            return (LowerLimit < value && UpperLimit > value);
        }
        #endregion

        #region Double Extentions
        public static bool IsWithinRangeIncludingLimits(this double value, double LowerLimit, double UpperLimit)
        {
            return (LowerLimit <= value && UpperLimit >= value);
        }

        public static bool IsWithinRangeIncludingLowerLimit(this double value, double LowerLimit, double UpperLimit)
        {
            return (LowerLimit <= value && UpperLimit > value);
        }

        public static bool IsWithinRangeIncludingUpperLimit(this double value, double LowerLimit, double UpperLimit)
        {
            return (LowerLimit < value && UpperLimit >= value);
        }

        public static bool IsWithinRangeExcludingLimits(this double value, double LowerLimit, double UpperLimit)
        {
            return (LowerLimit < value && UpperLimit > value);
        }
        #endregion

    }
}
