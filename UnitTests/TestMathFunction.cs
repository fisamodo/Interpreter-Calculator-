using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AlgebraicExpressionInterpreter;

namespace UnitTests
{
    [TestClass]
    public class TestMathFunction
    {
        [TestMethod]
        public void MathFunctionOfSinReturns1ForPiHalfConstant()
        {
            IExpression piHalf = new Constant(Math.PI / 2.0);
            IExpression mathFun = new MathFunction(Math.Sin, piHalf);
            Assert.AreEqual(1.0, mathFun.Interpret(new Context(3)), 1e-5);
        }

        [TestMethod]
        public void MathFunctionOfSqrtReturnsCorrectValueFor2()
        {
            IExpression argument = new VariableX();
            IExpression mathFun = new MathFunction(Math.Sqrt, argument);
            Assert.AreEqual(Math.Sqrt(2.0), mathFun.Interpret(new Context(2)));
        }
    }
}
