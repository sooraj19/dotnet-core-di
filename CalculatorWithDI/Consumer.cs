using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithDI
{
    public class Consumer
    {
        private ICalculator _calculator;

        public Consumer(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int ConsumerAdd(int num1, int num2)
        {
            return _calculator.Add(num1, num2);
        }
    }
}
