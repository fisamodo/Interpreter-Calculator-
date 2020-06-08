using System;
using System.Collections.Generic;
using System.IO;
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
                {"log", Math.Log },
                {"log10", Math.Log10 }


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
                case "log10":
                    return functions[functionName];

                default:
                    throw new NotImplementedException();
            }

        }
        public string getFunctionName(string s)
        {
            int leftP, rightP, signCheck;
            leftP = s.IndexOf("(");
            signCheck = s.IndexOf("-");
            string fun = "-1";
            if(signCheck==0)
            {
                 fun = s.Substring(1, leftP);
                 return fun;


            }
            else if(signCheck != 0)
            {
                 fun = s.Substring(0, leftP);
                 return fun;
            }
            return fun;

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
            int leftP, rightP;
            leftP = s.IndexOf("(");

            string temp = s;
            var aStringBuilder = new StringBuilder(s);
            aStringBuilder.Remove(0, leftP+1);
            temp = aStringBuilder.ToString();
            rightP = temp.IndexOf(")");
            temp = aStringBuilder.ToString();
            aStringBuilder.Remove(rightP, 1);
            s = aStringBuilder.ToString();
            return s;
        }
 
    }
   
}
