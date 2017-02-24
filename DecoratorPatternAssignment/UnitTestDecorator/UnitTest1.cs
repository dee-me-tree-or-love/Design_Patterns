using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecoratorPatternAssignment;

namespace UnitTestDecorator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDecoratorEvaluation()
        {
            BaseApp myApp = new BaseApp();
            Decorator myAppWithDecorator = new Decorator(myApp);
            double expectedScore = 13;
            Assert.AreEqual(expectedScore, myAppWithDecorator.EvaluateSelf());
        }

        [TestMethod]
        public void TestDecoratorAdapterEvaluation()
        {
            BaseApp myApp = new BaseApp();
            Decorator myAppWithDecorator = new Decorator(myApp);
            Adapter myAppWithAdapter = new Adapter(myAppWithDecorator);
            double expectedScore = 15;
            Assert.AreEqual(expectedScore, myAppWithAdapter.EvaluateSelf());
        }

        [TestMethod]
        public void TestTwoDecoratorsEvaluation()
        {
            BaseApp myApp = new BaseApp();
            Decorator myAppWithDecorator = new Decorator(myApp);
            Decorator myAppWithTwoDecorators = new Decorator(myAppWithDecorator);
            double expectedScore = 16;
            Assert.AreEqual(expectedScore, myAppWithTwoDecorators.EvaluateSelf());
        }

        [TestMethod]
        public void TestDecoratorAndWeb()
        {
            BaseApp myApp = new BaseApp();
            Decorator myAppWithDecorator = new Decorator(myApp);
            myAppWithDecorator.SetTechnology(new WebTechnology());
            double expectedScore = 15;
            Assert.AreEqual(expectedScore, myAppWithDecorator.EvaluateSelf());
        }
    }
}
