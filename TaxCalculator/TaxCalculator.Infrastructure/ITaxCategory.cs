using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaxCalculator.Infrastructure.Constants;

namespace TaxCalculator.Infrastructure
{
    public interface ITaxCategory
    {
        TaxCategory GetCategory(int Age, Gender gender);

    }
    
}
