using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorWithFactoryPattern.Infrastructure.Interfaces;

namespace TaxCalculatorWithFactoryPattern.Infrastructure.Implimentation
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        private readonly ICalculatorFactory _calculatorFactory;

        public TaxCalculatorService(ICalculatorFactory calculatorFactory)
        {
            _calculatorFactory = calculatorFactory;
        }
        public double TaxCalculator(string type, double amount)
        {
            var calculator =  _calculatorFactory.GetCalculator(type);
            return calculator.CalculatetaxAmount(amount);
        }
    }
}
