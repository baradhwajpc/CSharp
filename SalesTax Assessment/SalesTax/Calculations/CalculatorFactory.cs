using System;
using System.Collections.Generic;

namespace PVM.Calculations
{
    public class  CalculatorFactory
    {
        private Dictionary<String, ITaxCalculator> taxCalculators;

        public CalculatorFactory()
        {
            taxCalculators = new Dictionary<String, ITaxCalculator>();
            AddtoFactory("Local", new LocalTaxCalculator());
        }

        public void AddtoFactory(string strategy, ITaxCalculator taxCalc)
        {
            taxCalculators.Add(strategy, taxCalc);
        }

        public ITaxCalculator GetTaxCalculator(String strategy)
        {
            ITaxCalculator taxCalc = (ITaxCalculator)taxCalculators[strategy];
            return taxCalc;
        }

        public int GetFactorySize()
        {
            return taxCalculators.Count;
        }
    }
}


