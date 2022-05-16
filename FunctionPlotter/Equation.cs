using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasksForm
{
    public class Equation
    {
        //data
        private string inFixExpression;
        public string postFixExpression { get; set;}
        bool isValidEquation;
        //constructors
        public Equation()
        {
            isValidEquation = false;
        }
        public Equation(string inFixEquation)
        {
            this.inFixExpression = inFixEquation;
            isValidEquation = false;
        }
        //methods
        //change the infix equation
        public void addNewExpression(string expression) { inFixExpression = expression;isValidEquation = false; }
        //takes infix expression and change it to post fix to be easy evaluated later
        public bool parseExpression()
        {
            //check infix string
            if (inFixExpression == null){ return false; }
            if (inFixExpression.Length < 3) { return false; }
            postFixExpression = "";
            Stack<char> stack = new Stack<char>();

            //go throw each character
            for (int i = 0; i < inFixExpression.Length; i++)
            {
                char c = inFixExpression[i];
                //check if current char is number or digit just add to postFix string
                if (char.IsLetterOrDigit(c))
                {
                    postFixExpression += (c); 
                }
                else
                {
                    if (!checkme(i)) { return false; }
                    int currentCharOrder = getOrder(c);
                    //check if its a symbol and get its order
                    //order 0 means character isnt a valid operator
                    if (currentCharOrder == 0) { return false; }
                    else
                    {
                        //if stack empty just add it
                        if (stack.Count == 0) { stack.Push(c); }
                        else if (c == ')')
                        {
                            //go throw stack and pop operators til find opening brackets
                            while (stack.Count != 0 && stack.Peek() != '(') { postFixExpression += stack.Pop(); }
                            //pop ( bracket
                            stack.Pop();
                        }
                        //if current char c order higher than operator in stack
                        else if (currentCharOrder > getOrder(stack.Peek())) { stack.Push(c); }
                        //else current char c order lower or equal than operator in stack
                        else
                        {
                            //pop from stack til the current char has the highest order in the stack
                            while (stack.Count != 0 && getOrder(stack.Peek()) >= currentCharOrder)
                            {
                                postFixExpression += (stack.Pop());
                            }
                            //finally push the char in stack
                            stack.Push(c);
                        }
                    }
                }
            }
            //at the end of string pop the remaning char in stack to postfix
            while (stack.Count != 0){postFixExpression += (stack.Pop());}
            return true;
        }
        private bool checkme(int i)
        {
            try
            {
                if (char.IsLetterOrDigit(inFixExpression[i - 1]) && char.IsLetterOrDigit(inFixExpression[i + 1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        //
        public float evaluateExpression(float xValue)
        {
            Stack<float> stack = new Stack<float>();
            int postFixLen = postFixExpression.Length;
            for (int i = 0; i < postFixLen; i++)
            {
                char c = postFixExpression[i];
                //if char is a digit add it in stack
                if (char.IsDigit(c))
                {
                    stack.Push(c - '0');
                }
                //if letter x add its value 
                else if (char.IsLetter(c)){stack.Push(xValue);}
                else
                {
                    float operand1 = stack.Pop();
                    float operand2 = stack.Pop();

                    switch (c)
                    {
                        case '+':
                            stack.Push(operand1 + operand2);
                            break;
                        case '-':
                            stack.Push(operand1 - operand2);
                            break;
                        case '*':
                            stack.Push(operand1 * operand2);
                            break;
                        case '/':
                            stack.Push(operand1 / operand2);
                            break;
                        case '^':
                            stack.Push((float)Math.Pow(operand2, operand1));
                            break;
                        default:
                            break;
                    }
                }
            }
            //at the end the remaning value in the stack will be the final result return it
            return stack.Pop();
        }
        //
        public float[] evaluateArray(float[] xInputs)
        { 
            //
            int size = xInputs.Length;
            float[] Output = new float[size];
            for (int i = 0; i < size; i++)
            {
                Output[i] = evaluateExpression(xInputs[i]);
            }
            return Output;
        }
        //takes char and returns 0=>wrong char or op order
        private int getOrder(char symbol)
        {
            switch (symbol)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                case '(':
                    return 4;
                default:
                    return 0;
            }
        }
    }
}
