using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorWithFactoryPattern.Infrastructure.Interfaces;

namespace TaxCalculatorWithFactoryPattern.Infrastructure.Calculator
{
    public class CompanyTaxCalculator : ICalculator
    {
        public double CalculatetaxAmount(double amount)
        {
            var tax =  amount * 20 / 100;
            return tax;
        }
    }
}
