using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPatternAssignment;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the basic functioanlity of subscribing an observer to a subject and notifying
        /// </summary>
        [TestMethod]
        public void TestBasicObserverSubject()
        {
            TestObserver _o1 = new TestObserver();
            TestObserver _o2 = new TestObserver();

            Subject _S = new Subject();

            _S.Attach(_o1);
            _S.Attach(_o2);
            _S.Notify();

            Assert.AreEqual(_S.ToString(), _o1.GetSubjectString());
            Assert.AreEqual(_S.ToString(), _o2.GetSubjectString());
        }
    }
}
