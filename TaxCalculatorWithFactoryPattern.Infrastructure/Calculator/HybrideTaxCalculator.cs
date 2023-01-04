using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorWithFactoryPattern.Infrastructure.Interfaces;

namespace TaxCalculatorWithFactoryPattern.Infrastructure.Calculator
{
    public class HybrideTaxCalculator : ICalculator
    {
        public double CalculatetaxAmount(double amount)
        {
            return amount * 15 / 100;
        }
    }
}
