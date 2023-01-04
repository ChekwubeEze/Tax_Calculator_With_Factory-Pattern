using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculatorWithFactoryPattern.Infrastructure.Interfaces
{
    public interface ITaxCalculatorService
    {
        public double TaxCalculator(string type, double amount);
    }
}
