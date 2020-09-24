using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithDI
{
    class CalculatorConsumer
    {
        private ICalculator _calculator;

        public CalculatorConsumer(ICalculator calculatorIstance)
        {
            _calculator = calculatorIstance;
        }

        public int ConsumerAdd(int num1, int num2)
        {
            return _calculator.Add(num1, num2);
        }
    }
}
