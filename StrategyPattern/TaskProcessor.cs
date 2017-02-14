using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// Not really a useful class, but just in case you need it - it's there
    /// </summary>
    public static class TaskProcessor
    {
        public static void Process(object task)
        {
            Console.WriteLine("~\n{0}\nprocessed the task {1}\n~", System.DateTime.Now, task);
        }
    }
}
