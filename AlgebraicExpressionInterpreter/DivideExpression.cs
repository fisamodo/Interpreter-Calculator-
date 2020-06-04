using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicExpressionInterpreter
{
    public class DivideExpression : IExpression
    {
        public DivideExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }
        public double Interpret(Context context)
        {
            return left.Interpret(context) / right.Interpret(context);
        }
        private readonly IExpression left;
        private readonly IExpression right;
    }
}
