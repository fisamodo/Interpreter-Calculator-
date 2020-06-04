using System;
using AlgebraicExpressionInterpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestTrigonometryExpression
    {
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentence()
        {

            // 2 + cos(1) + x
            IExpression two = new Constant(2);
            string function = "cos(1)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new Constant(f.getValue(function));
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(5);
            
            var y = result.Interpret(c);

            Assert.AreEqual(7.54, y, 2);
        }
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentenceWithUnknown()
        {

            // 2 + cos(x) + x
            IExpression two = new Constant(2);
            string function = "cos(x)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new VariableX();
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(1);

            var y = result.Interpret(c);

            Assert.AreEqual(3.54, y, 2);
        }
    }
}
