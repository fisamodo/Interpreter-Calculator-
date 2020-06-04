using System;
using System.Collections.Generic;
using AlgebraicExpressionInterpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestMultiplyExpression
    {
        [TestMethod]
        public void MultiplicationExpressionEvaluatesDifferenceOf2Constants()
        {
            IExpression leftConstant = new Constant(4);
            IExpression rightConstant = new Constant(6);

            IExpression difference = new MultiplyExpression(leftConstant, rightConstant);
            Context context = new Context(0);
            var result = difference.Interpret(context);
            Assert.AreEqual(24, result, 1e-10);
        }
        [TestMethod]
        public void MultiplicationExpressionEvaluatesDifferenceOfComplexExpressions()
        {
            // 2 * x - 7 + x * 10 => x = 5 => 80
            IExpression two = new Constant(2);
            IExpression x = new VariableX();
            IExpression seven = new Constant(7);
            IExpression ten = new Constant(10);

            IExpression result = new MultiplyExpression(two, x);
            result = new SubtractionExpression(result, seven);
            result = new SumExpression(result, x);
            result = new MultiplyExpression(result, ten);
            Context c = new Context(5);


            var y = result.Interpret(c);

            Assert.AreEqual(80, y, 1e-10);


            c = new Context(-3);
            y = result.Interpret(c);
            Assert.AreEqual(-160, y, 1e-10);

        }
        [TestMethod]
        public void MultiplicationExpressionEvaluatesDifferenceOfComplexDecimalExpression()
        {
            // 2 * x - 7 + x * 10
            IExpression two = new Constant(2);
            IExpression x = new VariableX();
            IExpression seven = new Constant(7);
            IExpression ten = new Constant(10);

            IExpression result = new MultiplyExpression(two, x);
            result = new SubtractionExpression(result, seven);
            result = new SumExpression(result, x);
            result = new MultiplyExpression(result, ten);
            Context c = new Context(0.5);


            var y = result.Interpret(c);

            Assert.AreEqual(-55, y, 1e-10);


            c = new Context(1.5);
            y = result.Interpret(c);
            Assert.AreEqual(-25, y, 1e-10);

        }
    }
}
