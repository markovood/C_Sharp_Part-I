using System;
using System.Globalization;
using System.Threading;

namespace Problem3.XExpression
{
    class XExpression
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string expression = Console.ReadLine();
            decimal result = 0m;
            decimal resultInBrackets = 0m;
            char currentOperator = '+';
            int currentOperand = 0;
            char currentOperatorInBrackets = '+';
            int currentOperandInBrackets = 0;
            int index = 0;

            while (true)
            {
                if (Char.IsDigit(expression[index]))
                {
                    currentOperand = expression[index] - '0';
                    switch (currentOperator)
                    {
                        case '+':
                            result += currentOperand;
                            break;
                        case '-':
                            result -= currentOperand;
                            break;
                        case '*':
                            result *= currentOperand;
                            break;
                        case '/':
                            result /= currentOperand;
                            break;
                    }
                }
                else if (expression[index] == '(')
                {
                    index++;
                    while (expression[index] != ')')
                    {
                        if (Char.IsDigit(expression[index]))
                        {
                            currentOperandInBrackets = expression[index] - '0';
                            switch (currentOperatorInBrackets)
                            {
                                case '+':
                                    resultInBrackets += currentOperandInBrackets;
                                    break;
                                case '-':
                                    resultInBrackets -= currentOperandInBrackets;
                                    break;
                                case '*':
                                    resultInBrackets *= currentOperandInBrackets;
                                    break;
                                case '/':
                                    resultInBrackets /= currentOperandInBrackets;
                                    break;
                            }

                        }
                        else
                        {
                            currentOperatorInBrackets = expression[index];
                        }

                        index++;
                    }

                    switch (currentOperator)
                    {
                        case '+':
                            result += resultInBrackets;
                            break;
                        case '-':
                            result -= resultInBrackets;
                            break;
                        case '*':
                            result *= resultInBrackets;
                            break;
                        case '/':
                            result /= resultInBrackets;
                            break;
                    }

                    currentOperatorInBrackets = '+';
                    resultInBrackets = 0;
                }
                else if (expression[index] == '=')
                {
                    Console.WriteLine("{0:F2}", result);
                    return;
                }
                else
                {
                    currentOperator = expression[index];
                }

                index++;
            }
        }
    }
}
