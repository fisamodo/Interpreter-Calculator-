using System;
using AlgebraicExpressionInterpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestDivideExpression
    {
        [TestMethod]
        public void MultiplicationExpressionEvaluatesDifferenceOf2Constants()
        {
            IExpression leftConstant = new Constant(10);
            IExpression rightConstant = new Constant(4);

            IExpression difference = new DivideExpression(leftConstant, rightConstant);
            Context context = new Context(0);
            var result = difference.Interpret(context);
            Assert.AreEqual(2.5, result, 1e-10);
        }
        [TestMethod]
        public void MultiplicationExpressionEvaluatesDifferenceOfComplexExpressions()
        {
            // 3 / x - 7 + x / 10 
            IExpression three = new Constant(3);
            IExpression x = new VariableX();
            IExpression seven = new Constant(7);
            IExpression ten = new Constant(10);

            IExpression result = new DivideExpression(three, x);
            result = new SubtractionExpression(result, seven);
            result = new SumExpression(result, x);
            result = new DivideExpression(result, ten);
            Context c = new Context(2);


            var y = result.Interpret(c);

            Assert.AreEqual(-0.35, y, 1e-10);


            c = new Context(-3);
            y = result.Interpret(c);
            Assert.AreEqual(-1.1, y, 1e-10);

        }
        [TestMethod]
        public void MultiplicationExpressionEvaluatesDifferenceOfComplexDecimalExpression()
        {
            // 3 / x - 7 + x / 2
            IExpression three = new Constant(3);
            IExpression x = new VariableX();
            IExpression seven = new Constant(7);
            IExpression two2 = new Constant(2);

            IExpression result = new DivideExpression(three, x);
            result = new SubtractionExpression(result, seven);
            result = new SumExpression(result, x);
            result = new DivideExpression(result, two2);
            Context c = new Context(0.5);


            var y = result.Interpret(c);

            Assert.AreEqual(-0.25, y, 1e-10);


            c = new Context(1.5);
            y = result.Interpret(c);
            Assert.AreEqual(-1.75, y, 1e-10);

        }
    }
}
