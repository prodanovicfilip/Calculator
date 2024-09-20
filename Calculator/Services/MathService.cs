using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Infrastructure;

namespace Calculator.Services
{
    public class MathService : IMathService
    {
        public double AddNumbers(double n1, double n2)
        {
            return n1 + n2;
        }

        public double DivideNumbers(double n1, double n2)
        {
            if (n2 == 0) throw new Exception("Can't divide with 0");
            return n1 / n2;
        }

        public double MultiplyNumbers(double n1, double n2)
        {
            return n1 * n2;
        }

        public double SubstractNumbers(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}
