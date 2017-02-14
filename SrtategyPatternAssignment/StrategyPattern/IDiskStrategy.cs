using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IDiskStrategy
    {
        /// <summary>
        /// A method that returns the index of an element of the collection of tasks that has to be processed next. 
        /// Takes in a collcetion of tasks as a first parameter and the currentTask as the second parameter.
        /// The implementation varies according the the strategy
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="currentTask"></param>
        /// <returns></returns>
        int FindIndex(List<int> tasks, int currentTask);
    }
}
