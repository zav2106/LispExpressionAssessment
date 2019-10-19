using LispIsEasy.BusinessObjects;
using LispIsEasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LispIsEasy.Services
{
    class LispCheckerService : ILispChecker
    {
        public bool CheckExpression(LispExpression expression)
        {
            int rightParenthesesCounter = 0;
            int leftparenPhesesCounter = 0;
            string expressionBody;
            expressionBody = expression.Body;

            for (int i = 0; i < expressionBody.Length; i++)
            {
                if (expressionBody[i] == '(')
                {
                    rightParenthesesCounter++;
                }

                if (expressionBody[i] == ')')
                {
                    leftparenPhesesCounter++;
                }

                if (leftparenPhesesCounter > rightParenthesesCounter)
                {
                    return false;
                }

            }

            if (leftparenPhesesCounter == rightParenthesesCounter)
            {
                return true;
            }

            return false;
        }

        public bool AssertResults(bool realMethod, bool testMethod)
        {
            if ((realMethod == true && testMethod == true) || (realMethod == false && testMethod == false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckExpressionTest(LispExpression expression)
        {
            switch (expression.Body)
            {
                case "((1+3))()(4+(3-5)))":
                    return true;
                case "((1+3))(())(4+(3-5))":
                    return true;
                case "((1+3))))(4+(3-5)))":
                    return false;
            }
            return false;
        }
    }
}
