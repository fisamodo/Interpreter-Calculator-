using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicExpressionInterpreter
{
    public class Context
    {
        public Context(double x)
        {
            X = x;
        }

        public double X { get; private set; }
    }
}
