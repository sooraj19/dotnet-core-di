using System;

namespace CalculatorWithDI
{
    class RealCalculator : ICalculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            throw new NotImplementedException();
        }
    }
}
