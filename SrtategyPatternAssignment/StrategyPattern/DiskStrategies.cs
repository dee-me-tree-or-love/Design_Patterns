using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class FCFSDiskStrategy : IDiskStrategy
    {
        public int FindIndex(List<int> tasks, int currentTask)
        {
            if (tasks.Count == 1 || tasks[0]!= currentTask) // if not the current task -return first, depended on the implementation
            {
                return 0;
            }

            return 1; // the index of the first item in the list
        }
    }

    public class SSTFDiskStrategy : IDiskStrategy
    {
        public int FindIndex(List<int> tasks, int currentTask)
        {
            if (tasks.Count == 1)
            {
                return 0;
            }

            int _minimalSize = Math.Abs(tasks[tasks.Count - 1] - currentTask); // the last element to start with -- why last -- well.. why not I guess
            int _dist = 0;
            int _headerIndex = 0;

            for (int i = 0; i < tasks.Count; i++)
            {
                _dist = Math.Abs(tasks[i] - currentTask);
                if (_dist < _minimalSize && tasks[i] != currentTask)
                {
                    _minimalSize = _dist;
                    _headerIndex = i; // set the header at the nearest element
                }
            }

            return _headerIndex;
        }
    }


    
    public class SCANDiskStrategy : IDiskStrategy
    {
        // to show to which direction it is going
        private bool isDecreasing = true;

        private int FindFirstLower(List<int> tasks, int currentTask)
        {
            int _maxSmaller = -1; // the largest smaller element than current task
            foreach(int t in tasks)
            {
                if(t<currentTask && t > _maxSmaller)
                {
                    _maxSmaller = t;
                }
            }
            return _maxSmaller;
        }

        private int FindFirstUpper(List<int> tasks, int currentTask)
        {
            int _minBigger = tasks.Max(); // first get the biggest - if the current is the biggest - than there's no larger and the process should switch to decreasing search
            foreach (int t in tasks)
            {
                if (t > currentTask && t < _minBigger)
                {
                    _minBigger = t;
                }
            }
            return _minBigger;

        }

        public int FindIndex(List<int> tasks, int currentTask)
        {
            if(tasks.Count == 1)
            {
                return 0;
            }

            int _nextTask = -1;
            int _nextTaskIndex = -1;
            if (this.isDecreasing) //looking for smaller tasks
            {
                _nextTask = this.FindFirstLower(tasks,currentTask);
                if(_nextTask == -1) // didn't find an appropriate task smaller than current - go look for the larger
                {
                    this.isDecreasing = false; // shouldn't look for the smaller next time
                    _nextTask = this.FindFirstUpper(tasks, currentTask);
                }
            }
            else // if looking for the first larger item
            {
                _nextTask = this.FindFirstUpper(tasks, currentTask);
                if (_nextTask == -1) // didn't find an appropriate task smaller than current - go look for the larger
                {
                    this.isDecreasing = true; // shouldn't look for the smaller next time
                    _nextTask = this.FindFirstLower(tasks, currentTask);
                }
            }
            _nextTaskIndex = tasks.IndexOf(_nextTask);
            return _nextTaskIndex;
        }
    }
}
