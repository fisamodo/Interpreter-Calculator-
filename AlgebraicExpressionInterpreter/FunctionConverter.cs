using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicExpressionInterpreter
{
    public class FunctionConverter
    {
        Dictionary<string, MathFunction.Fun> functions = new Dictionary<string, MathFunction.Fun>
            {
                {"sin", Math.Sin },
                {"cos", Math.Cos },
                {"tan", Math.Tan },
                {"ata", Math.Atan },
                {"log", Math.Log }
            };
        public MathFunction.Fun Translator(string s)
        {
            string functionName;
            functionName = getFunctionName(s);
            switch(functionName)
            {
                case "sin":
                    return functions[functionName];
                case "cos":
                    return functions[functionName];
                case "tan":
                    return functions[functionName];
                case "ata":
                    return functions[functionName];
                case "log":
                    return functions[functionName];
                default:
                    throw new NotImplementedException();
            }

        }
        public string getFunctionName(string s)
        {
            var aStringBuilder = new StringBuilder(s);
            if(s.Length==7)
            {
                aStringBuilder.Remove(3, 4);

            }
            else
            {
                aStringBuilder.Remove(3, 3);

            }
            s = aStringBuilder.ToString();
            return s;
        }

        public double getValue(string s)
        {
            string value = s;
            value = getFunctionValue(value);
            double numValue = Convert.ToDouble(value);
            return numValue;
        }
        public string getFunctionValue(string s)
        {
            string temp = s;
            var aStringBuilder = new StringBuilder(s);
            int index = temp.IndexOf("(");
            aStringBuilder.Remove(0, index+1);
            temp = aStringBuilder.ToString();
            index = temp.IndexOf(")");
            aStringBuilder.Remove(index, 1);
            s = aStringBuilder.ToString();
            return s;
        }
 
    }
   
}
