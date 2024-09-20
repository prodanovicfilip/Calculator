using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Infrastructure
{
    public interface IMathService
    {
        public double AddNumbers(double n1, double n2);
        public double SubstractNumbers(double n1, double n2);
        public double MultiplyNumbers(double n1, double n2);
        public double DivideNumbers(double n1, double n2);
    }
}
