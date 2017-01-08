using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Arithmetical_expression
{
    class Program
    {
        static char[] theOperators = new char[] { '+', '-', '*', '/', '^', '(', ')' };
        public static void Main()
        {
            double values = 0;
            int operators = 0;
            Console.Write("Enter expression: ");
            string arithmethical = Console.ReadLine();
            string expression = ShuntingYardAlgorithm(arithmethical); 
            Stack<double> stack = new Stack<double>();
            Stack<double> stackRPN = new Stack<double>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (IsValue(expression[i].ToString()))
                {
                    values = (double)Char.GetNumericValue(expression[i]);
                    stackRPN.Push(values);
                }
                else
                {
                    operators = GetArguments(expression[i]);
                    try
                    {
                        if (IsInputSufficient(stackRPN, operators))
                        {
                            for (int j = 0; j < operators; j++)
                            {
                                stack.Push(stackRPN.Pop());
                            }
                            double result = GetCalculation(expression[i], stack);
                            stackRPN.Push(result);
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("(Error) The input has not sufficient values in the expression.");
                        return;
                    }
                }
            }
            if (stackRPN.Count == 1)
            {
                Console.WriteLine("{0} = {1}", expression, stackRPN.Pop());
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("(Error) The input has too many values.");
                return;
            }
        }

        public static bool IsValue(string value)
        {
            double number = 0;
            bool isValue = double.TryParse(value, out number);
            if (isValue)
            {
                return true;
            }
            return false;
        }

        public static int GetArguments(char operators)
        {
            int neededOperators = 0;
            for (int i = 0; i < theOperators.Length; i++)
            {
                if (theOperators[i] == '+')
                {
                    neededOperators = 2;
                }
                else if (theOperators[i] == '-')
                {
                    neededOperators = 2;
                }
                else if (theOperators[i] == '/')
                {
                    neededOperators = 2;
                }
                else if (theOperators[i] == '*')
                {
                    neededOperators = 2;
                }
                else if (theOperators[i] == '*')
                {
                    neededOperators = 2;
                }
            }
            return neededOperators;
        }

        public static double GetCalculation(char operators, Stack<double> stack)
        {
            double result = 0;
            if (operators == '+')
            {
                while (stack.Count> 0)
                {
                    result += stack.Pop();
                }
            }
            else if (operators == '-')
            {
                result = stack.Pop();
                while (stack.Count > 0)
                {
                    result = result - stack.Pop();
                }
            }
            else if (operators == '*')
            {
                result = 1;
                while (stack.Count > 0)
                {
                    result *= stack.Pop();
                }
            }
            else if (operators == '/')
            {
                result = stack.Pop();
                while (stack.Count > 0)
                {
                    result = result / stack.Pop();
                }
            }
            else if (operators == '^')
            {
                result = stack.Pop();
                double pow = stack.Pop();
                double number = result;
                for (int j = 1; j < pow; j++)
                {
                    result *= number;
                }
            }
            return result;
        }

        public static bool IsInputSufficient(Stack<double> stackRPN, int operators)
        {
            if (stackRPN.Count < operators)
            {
                throw new ArgumentOutOfRangeException();
            }
            return true;
        }

        public static string ShuntingYardAlgorithm(string expression)
        {
            Queue<char> output = new Queue<char>();
            Stack<char> operatorStack = new Stack<char>();
            Stack<int> stackPrecedence = new Stack<int>();
            int expressionPrecedence = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (IsValue(expression[i].ToString()))
                {
                    output.Enqueue(expression[i]);
                }
                else
                {
                    if (operatorStack.Count == 0)
                    {
                        operatorStack.Push(expression[i]);
                        
                    }
                    else
                    {
                        for (int j = 0; j < theOperators.Length; j++)
                        {
                            if (expression[i] == theOperators[j])
                            {
                                expressionPrecedence = j;
                                for (int k = 0; k < theOperators.Length; k++)
                                {
                                    if (operatorStack.Peek() == theOperators[k])
                                    {
                                        stackPrecedence.Push(k);
                                        break;
                                    }
                                }
                                if (stackPrecedence.Peek() > expressionPrecedence)
                                {
                                    while (true)
                                    {
                                        if (stackPrecedence.Peek() > expressionPrecedence)
                                        {
                                            output.Enqueue(operatorStack.Pop());
                                            stackPrecedence.Pop();
                                            if(stackPrecedence.Count == 0)
                                            {
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    operatorStack.Push(expression[i]);
                                }
                                else
                                {
                                    operatorStack.Push(expression[i]);
                                    break;
                                }
                            }                         
                        }
                    }                       
                }
            }
            while (operatorStack.Count > 0)
            {
                output.Enqueue(operatorStack.Pop());
            }
            StringBuilder reversePolishNotation = new StringBuilder();
             while(output.Count > 0)
            {
                reversePolishNotation.Append(output.Dequeue());
            }
            return reversePolishNotation.ToString();
        }
    }

}