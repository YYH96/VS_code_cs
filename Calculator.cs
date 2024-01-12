using System;

namespace Calculator
{
    public class CalculatorSystem
    {
        //use Generic
        public string InfixToPostfix(string infix)
        {
            string postfix = string.Empty;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                char ch = infix[i];
                if (char.IsLetterOrDigit(ch))
                {
                    postfix += ch;
                }
                else if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    while (stack.Count != 0 && stack.Peek() != '(')
                    {
                        postfix += stack.Pop();
                    }
                    if (stack.Count != 0 && stack.Peek() != '(')
                        return "Invalid expression";
                    else
                        stack.Pop();
                }
                else
                {
                    while (stack.Count != 0 && Precedence(ch) <= Precedence(stack.Peek()))
                    {
                        postfix += stack.Pop();
                    }
                    stack.Push(ch);
                }
            }
            while (stack.Count != 0)
            {
                postfix += stack.Pop();
            }
            return postfix;
        }

        // 연산자 우선순위를 결정하는 메서드
        public static int Precedence(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
            }
            return -1;
        }

        public int EvaluatePostfix(string postfix)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < postfix.Length; i++)
            {
                char ch = postfix[i];
                if (char.IsDigit(ch))   //숫자인지 확인하는 방법
                {
                    stack.Push(ch - '0'); // 문자를 숫자로 변환
                }
                else
                {
                    int val1 = stack.Pop();
                    int val2 = stack.Pop();
                    switch (ch)
                    {
                        case '+':
                            stack.Push(val2 + val1);
                            break;
                        case '-':
                            stack.Push(val2 - val1);
                            break;
                        case '*':
                            stack.Push(val2 * val1);
                            break;
                        case '/':
                            stack.Push(val2 / val1);
                            break;
                    }
                }
            }
            return stack.Pop();
        }
    }




    public class CalculatorMachin
    {
        public void CalculatorMachinRun()
        {
            CalculatorSystem system = new CalculatorSystem();


            try
            {
                Console.Write("Input Formula : ");
                string? sFormula = Console.ReadLine();

                if (sFormula != null)
                {
                    string postFix = system.InfixToPostfix(sFormula);
                    Console.WriteLine("Reuslt : {0}", system.EvaluatePostfix(postFix));
                }
                else
                {
                     throw new Exception("input null");
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }


        }
    }


}