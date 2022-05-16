using Microsoft.VisualStudio.TestTools.UnitTesting;
using tasksForm;

namespace FunctionPlotterUnitTest
{
    [TestClass]
    public class ValidityTestCases
    {
        //check valid equation True  5*x^3 + 2*x
        [TestMethod]
        public void CheckTrueEquation1()
        {
            string testString = "5*x^3 + 2*x";
            bool expectedOutput = false;
            Equation testEquation = new Equation();
            testEquation.addNewExpression(testString);
            bool output = testEquation.parseExpression();

            Assert.AreEqual(expectedOutput, output);
        }
        //check valid equation True  (5*x^3 + 2)+x
        [TestMethod]
        public void CheckTrueEquation2()
        {
            string testString = "(5*x^3 + 2)+x";
            bool expectedOutput = false;
            Equation testEquation = new Equation();
            testEquation.addNewExpression(testString);
            bool output = testEquation.parseExpression();

            Assert.AreEqual(expectedOutput, output);
        }
        //check no valid equation True  5*
        [TestMethod]
        public void CheckFalseEquation1()
        {
            string testString = "5*";
            bool expectedOutput = false;
            Equation testEquation = new Equation();
            testEquation.addNewExpression(testString);
            bool output = testEquation.parseExpression();

            Assert.AreEqual(expectedOutput, output);
        }
    }
}
