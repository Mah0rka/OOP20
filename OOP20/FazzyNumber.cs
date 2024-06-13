using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP20
{
    public struct FuzzyNumber
    {
        //поля структури 
        public double X { get; }
        public double Y { get; }

        //конструктор
        public FuzzyNumber(double lowerBound, double upperBound)
        {
            if (lowerBound == 0 || upperBound == 0)
                throw new DivideByZeroException("Не може бути 0!");//первірка на 0

            X = lowerBound;
            Y = upperBound;
        }

        //обчислення оберненого
        public FuzzyNumber Inverse()
        {
            return new FuzzyNumber(1 / Y, 1 / X);
        }
    }
}
