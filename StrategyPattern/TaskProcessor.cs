using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public static class TaskProcessor
    {
        public static void Process(object task)
        {
            Console.WriteLine("~\n{0}\nprocessed the task {1}\n~", System.DateTime.Now, task);
        }
    }
}
