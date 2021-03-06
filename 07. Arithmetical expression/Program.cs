﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Arithmetical_expression
{
    class Program
    {
        static string[] theOperators = new string[] { "+", "-", "*", "/", "^", "#", "$", "(", ")" };

        public static void Main()
        {
            double values = 0;
            int operators = 0;
            Console.Write("Enter expression: ");
            string arithmetical = Console.ReadLine();
            string[] arithmeticalExpression = arithmetical.Split(' ');
            for (int i = 0; i < arithmeticalExpression.Length; i++)
            {
                if (arithmeticalExpression[i] == "sqrt")
                {
                    arithmeticalExpression[i] = "#";
                }
                else if (arithmeticalExpression[i] == "ln")
                {
                    arithmeticalExpression[i] = "$";
                }
                else if (arithmeticalExpression[i] == "pow")
                {
                    arithmeticalExpression[i] = "^";
                    string temp = arithmeticalExpression[i];
                    arithmeticalExpression[i] = arithmeticalExpression[i + 1];
                    arithmeticalExpression[i + 1] = temp;
                    i++;
                }
            }
            string expression = ShuntingYardAlgorithm(arithmeticalExpression);
            string[] reversePolishNotation = expression.Split(' ');
            Console.Write("Reverse Polish Notation: ");
            for (int i = 0; i < reversePolishNotation.Length; i++)
            {
                Console.Write(reversePolishNotation[i]);
            }
            Console.WriteLine();
            Stack<double> stack = new Stack<double>();
            Stack<double> stackRPN = new Stack<double>();
            for (int i = 0; i < reversePolishNotation.Length; i++)
            {
                if (IsValue(reversePolishNotation[i]))
                {
                    values = Convert.ToDouble(reversePolishNotation[i]);
                    stackRPN.Push(values);
                }
                else
                {
                    operators = GetArguments(reversePolishNotation[i]);
                    try
                    {
                        if (IsInputSufficient(stackRPN, operators))
                        {
                            for (int j = 0; j < operators; j++)
                            {
                                stack.Push(stackRPN.Pop());
                            }
                            double result = GetCalculation(reversePolishNotation[i], stack);
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
                Console.Write("{0} = {1}", arithmetical, stackRPN.Pop());
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

        public static int GetArguments(string operators)
        {

            for (int i = 0; i < theOperators.Length; i++)
            {
                if ((operators == theOperators[i] && operators == "#") || (operators == theOperators[i] && operators == "$"))
                {
                    return 1;
                }
            }
            return 2;
        }

        public static double GetCalculation(string operators, Stack<double> stack)
        {
            double result = 0;
            if (operators == "+")
            {
                while (stack.Count > 0)
                {
                    result += stack.Pop();
                }
            }
            else if (operators == "-")
            {
                result = stack.Pop();
                while (stack.Count > 0)
                {
                    result = result - stack.Pop();
                }
            }
            else if (operators == "*")
            {
                result = 1;
                while (stack.Count > 0)
                {
                    result *= stack.Pop();
                }
            }
            else if (operators == "/")
            {
                result = stack.Pop();
                while (stack.Count > 0)
                {
                    result = result / stack.Pop();
                }
            }
            else if (operators == "^")
            {
                result = stack.Pop();
                double pow = stack.Pop();
                if (pow == 0)
                {
                    return 1;
                }
                if (result == 0)
                {
                    return 0;
                }

                result = Math.Pow(result, pow);
            }
            else if (operators == "#")
            {
                result = Math.Sqrt(stack.Pop());
            }
            else if (operators == "$")
            {
                result = Math.Log(stack.Pop());
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

        public static string ShuntingYardAlgorithm(string[] expression)
        {
            StringBuilder output = new StringBuilder();
            Stack<string> operatorStack = new Stack<string>();
            Stack<int> stackPrecedence = new Stack<int>();
            int expressionPrecedence = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (IsValue(expression[i].ToString()))
                {
                    output.Append(expression[i]);
                    output.Append(" ");
                }
                else
                {
                    if (operatorStack.Count == 0)
                    {
                        operatorStack.Push(expression[i]);
                    }
                    else if (expression[i] == "(" || operatorStack.Peek() == "(")
                    {
                        operatorStack.Push(expression[i]);
                    }
                    else if (expression[i] == ")")
                    {
                        while (true)
                        {
                            if (operatorStack.Peek() == "(")
                            {
                                operatorStack.Pop();
                                break;
                            }
                            output.Append(operatorStack.Pop());
                            if (operatorStack.Count == 1 && i == expression.Length - 1)
                            {
                                operatorStack.Pop();
                                break;
                            }
                            else
                            {
                                output.Append(" ");
                            }
                        }
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
                                if ((stackPrecedence.Peek() <= 1 && expressionPrecedence <= 1) ||
                                (stackPrecedence.Peek() <= 3 && expressionPrecedence <= 3 &&
                                stackPrecedence.Peek() > 1 && expressionPrecedence > 1))
                                {
                                    output.Append(operatorStack.Pop());
                                    output.Append(" ");
                                    stackPrecedence.Pop();
                                    operatorStack.Push(expression[i]);
                                }
                                else if (stackPrecedence.Peek() > expressionPrecedence)
                                {
                                    while (true)
                                    {
                                        if (stackPrecedence.Peek() > expressionPrecedence)
                                        {
                                            output.Append(operatorStack.Pop());
                                            output.Append(" ");
                                            stackPrecedence.Pop();
                                            if (stackPrecedence.Count == 0)
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
                if (operatorStack.Count == 1)
                {
                    output.Append(operatorStack.Pop());
                }
                else
                {
                    output.Append(operatorStack.Pop());
                    output.Append(" ");
                }
            }
            return output.ToString();
        }
    }
}