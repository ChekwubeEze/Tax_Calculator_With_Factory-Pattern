using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculatorWithFactoryPattern.Infrastructure.Calculator;
using TaxCalculatorWithFactoryPattern.Infrastructure.Interfaces;

namespace TaxCalculatorWithFactoryPattern.Infrastructure.Implimentation
{
    public class CalculatorFactory : ICalculatorFactory
    {
        public ICalculator GetCalculator(string type)
        {
            switch (type.ToLower())
            {
                case "individual":
                    return new IndividualTaxCalculator();
                case "company":
                    return new CompanyTaxCalculator();
                case "hybride":
                    return new HybrideTaxCalculator();
                default:
                    throw new NotImplementedException();

            }
        }
    }
}
