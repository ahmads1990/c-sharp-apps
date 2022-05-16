using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tasksForm;
namespace FunctionPlotterUnitTest
{
    [TestClass]
    public class OutputTestCases
    {
        //check valid output 5*x^3 + 2*x At x=2  Answer = 44
        [TestMethod]
        public void CheckOuputPositive1()
        {
            int x = 2;
            string testString = "5*x^3+2*x";
            float expectedOutput = 44;
            float actualOutput;

            Equation testEquation = new Equation();
            testEquation.addNewExpression(testString);
            testEquation.parseExpression();
            actualOutput = testEquation.evaluateExpression(x);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        //check valid output (5*x^3 + 2)+x At x=2 Answer = 44
        [TestMethod]
        public void CheckOuputPositive2()
        {
            int x = 2;
            string testString = "(5*x^3+2)+x";
            float expectedOutput = 44;
            float actualOutput;

            Equation testEquation = new Equation();
            testEquation.addNewExpression(testString);
            testEquation.parseExpression();
            actualOutput = testEquation.evaluateExpression(x);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        //check valid output (5*x^3 + 2)*x At x= 2  Answer = 84
        [TestMethod]
        public void CheckOuputPositive3()
        {
            int x = 2;
            string testString = "(5*x^3+2)*x";
            float expectedOutput = 84;
            float actualOutput;

            Equation testEquation = new Equation();
            testEquation.addNewExpression(testString);
            testEquation.parseExpression();
            actualOutput = testEquation.evaluateExpression(x);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        //check valid output 5*x^3 + 2*x At x=-10 Answer = −5020
        [TestMethod]
        public void CheckOuputNegative1()
        {
            int x = -10;
            string testString = "5*x^3+2*x";
            float expectedOutput = -5020;
            float actualOutput;

            Equation testEquation = new Equation();
            testEquation.addNewExpression(testString);
            testEquation.parseExpression();
            actualOutput = testEquation.evaluateExpression(x);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        //check valid output (5*x^3 + 2)+x At x=-10 Answer = −5008
        [TestMethod]
        public void CheckOuputNegative2()
        {
            int x = -10;
            string testString = "(5*x^3+2)+x";
            float expectedOutput = -5008;
            float actualOutput;

            Equation testEquation = new Equation();
            testEquation.addNewExpression(testString);
            testEquation.parseExpression();
            actualOutput = testEquation.evaluateExpression(x);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        //check valid output (5*x^3 + 2)*x At x= -10  Answer = 49980
        [TestMethod]
        public void CheckOuputNegative3()
        {
            int x = -10;
            string testString = "(5*x^3+2)*x";
            float expectedOutput = 49980;
            float actualOutput;

            Equation testEquation = new Equation();
            testEquation.addNewExpression(testString);
            testEquation.parseExpression();
            actualOutput = testEquation.evaluateExpression(x);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
