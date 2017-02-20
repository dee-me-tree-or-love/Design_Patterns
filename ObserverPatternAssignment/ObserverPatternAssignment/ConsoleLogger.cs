using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternAssignment
{
    /// <summary>
    /// Not relevant to the task
    /// </summary>
    public static class ConsoleLogger
    {
        public static void Log(params string[] message)
        {
            if (message.Length >= 1)
            {
                Console.WriteLine(">> {0} \n New Message: ", System.DateTime.Now);
                foreach (string msg in message)
                {
                    Console.Write(">> {0} \n", msg);
                }
            }
        }
    }
}
