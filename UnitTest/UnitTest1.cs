using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using StrategyPattern;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private int _expectedDefaultNumberOfTasks = 16;

        [TestMethod]
        public void TestDrive()
        {
            StrategyPattern.DiskDrive _DD = new DiskDrive();
            int _tasksNr = _DD.GetTaskNumber();
            Assert.AreEqual(_expectedDefaultNumberOfTasks, _tasksNr);
        }

        [TestMethod]
        public void TestFCFS()
        {
            List<int> _tasks = new List<int>() { 100, 3, 55, 23, 53, 12, 54, 22, 9, 85, 2 };
            int _currentTask = 100;
            FCFSDiskStrategy _FCFSStrat = new FCFSDiskStrategy();
            int _nextNumberIndex = 0;

            // processing the first task schedule
            _nextNumberIndex = _FCFSStrat.FindIndex(_tasks, _currentTask);
            Assert.AreEqual(1, _nextNumberIndex);
            _tasks.Remove(_currentTask);
            _currentTask = _tasks[_nextNumberIndex];
            // first iteration done
            for (int i = 0; i < _tasks.Count; i++)
            {
                Console.WriteLine(_tasks[i]);
            }
            // second iteration
            _nextNumberIndex = _FCFSStrat.FindIndex(_tasks, _currentTask);
            Assert.AreEqual(1, _nextNumberIndex);
            //done
        }

        [TestMethod]
        public void TestSST()
        {
            List<int> _tasks = new List<int>() { 100, 3, 55, 23, 53, 12, 54, 22, 9, 85, 2 };
            int _currentTask = 100;
            SSTFDiskStrategy _SSTFStrat = new SSTFDiskStrategy();
            int _nextNumberIndex = 0;

            // processing the first task schedule
            _nextNumberIndex = _SSTFStrat.FindIndex(_tasks, _currentTask);
            Assert.AreEqual(_tasks.IndexOf(85), _nextNumberIndex); // 100 - 85 -...
            int _cleanPending = _currentTask; // temporary placeholder
            _currentTask = _tasks[_nextNumberIndex];
            _tasks.Remove(_cleanPending);
            // first iteration done
            for (int i = 0; i < _tasks.Count; i++)
            {
                Console.WriteLine(_tasks[i]);
            }
            // second iteration
            _nextNumberIndex = _SSTFStrat.FindIndex(_tasks, _currentTask);
            Assert.AreEqual(_tasks.IndexOf(55), _nextNumberIndex); // .. - 85 - 55 -...
            //done
        }

        [TestMethod]
        public void TestSCAN()
        {
            List<int> _tasks = new List<int>()
                {
                    100,    //0
                    80,     //1
                    55,     //2
                    154,    //3
                    132     //4
                };
            int _currentTask = 100;
            SCANDiskStrategy _SCANStrat = new SCANDiskStrategy();
            int _nextNumberIndex = 0;

            // processing the first task schedule
            _nextNumberIndex = _SCANStrat.FindIndex(_tasks, _currentTask);
            Assert.AreEqual(_tasks.IndexOf(80), _nextNumberIndex); // 100 - 80 -...
            int _cleanPending = _currentTask; // temporary placeholder
            _currentTask = _tasks[_nextNumberIndex];
            _tasks.Remove(_cleanPending);
            // first iteration done

            this.LogList(_tasks);

            // second iteration
            _nextNumberIndex = _SCANStrat.FindIndex(_tasks, _currentTask);
            Assert.AreEqual(_tasks.IndexOf(55), _nextNumberIndex); // .. - 80 - 55 -...
            _cleanPending = _currentTask; // temporary placeholder
            _currentTask = _tasks[_nextNumberIndex];
            _tasks.Remove(_cleanPending);
            // second iteration done

            this.LogList(_tasks);

            // third iteration
            _nextNumberIndex = _SCANStrat.FindIndex(_tasks, _currentTask);
            Assert.AreEqual(_tasks.IndexOf(132), _nextNumberIndex); // .. - 55 - 132 -...
            _cleanPending = _currentTask; // temporary placeholder
            _currentTask = _tasks[_nextNumberIndex];
            _tasks.Remove(_cleanPending);
            // third iteration done

            this.LogList(_tasks);

            // fourth iteration
            _nextNumberIndex = _SCANStrat.FindIndex(_tasks, _currentTask);
            Assert.AreEqual(_tasks.IndexOf(154), _nextNumberIndex); // .. - 132 - 154...
            _cleanPending = _currentTask; // temporary placeholder
            _currentTask = _tasks[_nextNumberIndex];
            _tasks.Remove(_cleanPending);
            // fourth iteration done

            this.LogList(_tasks);
        }

        private void LogList(IList<int> li)
        {
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
        }

    }
}
