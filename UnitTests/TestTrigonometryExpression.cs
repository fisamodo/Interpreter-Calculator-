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
            string function = "cos(-1)";
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
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentenceWithUnknown1()
        {

            // 2 + sin(-1) + x
            IExpression two = new Constant(2);
            string function = "sin(-1)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new Constant(f.getValue(function));
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(5);

            var y = result.Interpret(c);

            Assert.AreEqual(6.15, y, 2);
        }
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentenceWithUnknown2()
        {

            // 2 + tan(x) + x
            IExpression two = new Constant(2);
            string function = "tan(x)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new VariableX();
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(123);

            var y = result.Interpret(c);

            Assert.AreEqual(123.46, y, 4);
        }
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentenceWithUnknown3()
        {

            // 2 + atan(x) + x
            IExpression two = new Constant(2);
            string function = "ata(x)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new VariableX();
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(1);

            var y = result.Interpret(c);

            Assert.AreEqual(3.785, y, 4);
        }
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentenceWithUnknown4()
        {

            // 2 + log(x) + x
            IExpression two = new Constant(2);
            string function = "log(x)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new VariableX();
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(1);

            var y = result.Interpret(c);

            Assert.AreEqual(3, y, 2);
        }
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentenceWithValueGreaterThen10()
        {

            // 2 + log(123) + x log base e
            IExpression two = new Constant(2);
            string function = "log(123)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new Constant(f.getValue(function));
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(123);

            var y = result.Interpret(c);

            Assert.AreEqual(129.81, y, 2);
        }
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentenceWithFunSizeMoreThen3()
        {

            // 2 + log10(123) + x 
            IExpression two = new Constant(2);
            string function = "log10(123)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new Constant(f.getValue(function));
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(123);

            var y = result.Interpret(c);

            Assert.AreEqual(127.08, y, 2);
        }
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentenceWithFunValueNegative()
        {

            // 2 + cos(-123) + x 
            IExpression two = new Constant(2);
            string function = "cos(-123)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new Constant(f.getValue(function));
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(123);

            var y = result.Interpret(c);

            Assert.AreEqual(124.45, y, 2);
        }
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentenceWithFunValueNegativeX()
        {

            // 2 + log10(x) + x 
            IExpression two = new Constant(2);
            string function = "log10(x)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new VariableX();
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(123);

            var y = result.Interpret(c);

            Assert.AreEqual(127.08, y, 2);
        }
        [TestMethod]
        public void MathFunctionReturnsValueAndCalculatesTheSentenceWithFunLog2()
        {

            // 2 + cos(-123) + x 
            IExpression two = new Constant(2);
            string function = "cos(-123)";
            FunctionConverter f = new FunctionConverter();
            IExpression value = new Constant(f.getValue(function));
            IExpression mathFun = new MathFunction(f.Translator(function), value);
            IExpression x = new VariableX();

            IExpression result = new SumExpression(two, mathFun);
            result = new SumExpression(result, x);
            Context c = new Context(123);

            var y = result.Interpret(c);

            Assert.AreEqual(124.45, y, 2);
        }
    }
}
