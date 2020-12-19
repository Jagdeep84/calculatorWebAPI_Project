using System;

namespace SimpleCalc
{
    public class SimpleCalc
    {
        public int add(int leftNumber, int rightNumber)
        {
            return leftNumber + rightNumber;
        }
        public int sub(int leftNumber, int rightNumber)
        {
            return leftNumber - rightNumber;
        }
        public int multi(int leftNumber, int rightNumber)
        {
            return leftNumber * rightNumber;
        }
        public int divide(int leftNumber, int rightNumber)
        {
            return leftNumber / rightNumber;
        }
        public string OperatorSwitch(int leftNumber, int rightNumber, string operation)
        {
            int result = 0;
            bool errorState = false;
            switch (operation)
            {
                case "+":
                    result = leftNumber + rightNumber;
                    break;
                case "-":
                    result = leftNumber - rightNumber;
                    break;
                case "*":
                    result = leftNumber * rightNumber;
                    break;
                case "/":
                    result = rightNumber != 0 ? leftNumber / rightNumber : 0;
                    errorState = rightNumber != 0 ? false : true;
                    break;
                default:
                    errorState = true;
                    break;
            }

            string resultStr = "";
            resultStr += result;
            if (errorState)
            {
                resultStr = "error!. divided by zero";
            }
            return resultStr;
        }
    }
}
