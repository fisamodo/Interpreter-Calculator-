using System;
using System.Collections.Generic;
using AlgebraicExpressionInterpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestSubtractionExpression
    {
        [TestMethod]
        public void SubtractionExpressionEvaluatesDifferenceOf2Constants()
        {
            IExpression leftConstant = new Constant(4);
            IExpression rightConstant = new Constant(6);

            IExpression difference = new SubtractionExpression(leftConstant, rightConstant);
            Context context = new Context(0);
            var result = difference.Interpret(context);
            Assert.AreEqual(-2, result,1e-10);
            

        }
        [TestMethod]
        public void SubtractionExpressionEvaluatesDifferenceInComplexExpression()
        {
            Dictionary<string, MathFunction.Fun> functions = new Dictionary<string, MathFunction.Fun>
            {
                {"sin", Math.Sin },
                {"cos", Math.Cos }

            };
            //mnozenje djeljenje testovi, cos i sin sa metodom

            // 2 + x - 7 + x - 10 + cos(x)
            IExpression two = new Constant(2);
            IExpression x = new VariableX();
            IExpression seven = new Constant(7);
            IExpression ten = new Constant(10);

            IExpression result = new SumExpression(two, x);
            result = new SubtractionExpression(result, seven);
            result = new SumExpression(result, x);
            result = new SubtractionExpression(result, ten);
            Context c = new Context(5);
            List<IExpression> operand = new List<IExpression>();
            List<IExpression> operations = new List<IExpression>();

            var y = result.Interpret(c);

            Assert.AreEqual(-5, y, 1e-10);


            c = new Context(-3);
            y = result.Interpret(c);
            Assert.AreEqual(-21, y, 1e-10);




        }
    }
}
