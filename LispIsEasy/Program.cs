using LispIsEasy.BusinessObjects;
using LispIsEasy.Services;
using System;

namespace LispIsEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = new LispExpression();
            expression.Body = "((1+3))()(4+(3-5))";

            var correctness = new LispCheckerService();
            string solution;

            if (correctness.CheckExpression(expression))
            {
                solution = "Correct Expression";
            }
            else
            {
                solution = "Wrong Expression";
            }

            var testExpressionTrue = new LispExpression();
            testExpressionTrue.Body = "((1+3))(())(4+(3-5))";
            var testExpressionWrong = new LispExpression();
            testExpressionWrong.Body = "((1+3))))(4+(3-5)))";

            if (correctness.AssertResults(correctness.CheckExpression(testExpressionTrue), correctness.CheckExpressionTest(testExpressionTrue)))
            {
                Console.WriteLine("Unit Test with ((1+3))(())(4+(3-5)) is successfull");
            }

            if (correctness.AssertResults(correctness.CheckExpression(testExpressionWrong), correctness.CheckExpressionTest(testExpressionWrong)))
            {
                Console.WriteLine("Unit Test with ((1+3))))(4+(3-5))) is successfull");
            }

           

            Console.Write("LispExpression: "); Console.Write(expression.Body); Console.Write(" is "); Console.Write(solution);


        }
    }
}
