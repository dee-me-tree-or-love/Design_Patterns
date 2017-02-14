using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StrategyPattern
{
    public class DiskDrive
    {
        private Timer tmr = new Timer();
        private Random taskRandomizer;
        private List<int> tasks;
        private IDiskStrategy diskStrat;
        private int currentTask;

        public int GetCurrentTask()
        {
            return this.currentTask;
        }

        public DiskDrive()
        {
            this.taskRandomizer = new Random();
            this.tmr = new Timer();
            this.diskStrat = new FCFSDiskStrategy(); //be default
            
            this.PopulateTasks();

            // set the action to be executed per tick
            this.tmr.Elapsed += this.OnTimedAction;
            
           
        }

        private void PopulateTasks()
        {
            this.tasks = new List<int>();

            this.currentTask = 100;
            this.tasks.Add(this.currentTask);
            // just in case the randomizer is not initiated
            if (this.taskRandomizer == null)
            {
                this.taskRandomizer = new Random();
            }

            
            for (int i = 0; i < 15; i++)
            {
                this.AddTask();
            }
        }

        public void AddTask()
        {
            int _newTask = 0;
            do
            {
                _newTask = taskRandomizer.Next(1, 100);
            } while (this.tasks.Contains(_newTask));
            tasks.Add(_newTask);
        }

        public void Run()
        {
            this.tmr.Start();
            Console.WriteLine("~\nDisk Strategy started {0}\n~", this.diskStrat);
        }

        public void Stop()
        {
            this.tmr.Stop();
            Console.WriteLine("~\nDisk Strategy stopped {0}\n~", this.diskStrat);
        }

        public void SetStrategy(IDiskStrategy ds)
        {
            this.diskStrat = ds;
        }

        public delegate void gotNewTask(int _newTask);
        public event gotNewTask OnHeadChange;

        private void OnTimedAction(Object source, ElapsedEventArgs e)
        {
            int _nextHeaderIndex = this.diskStrat.FindIndex(this.tasks, this.currentTask); // if first time called - returns the first task to be processed, second time called - second task to 
            int _pendingRemove = this.currentTask;
            this.currentTask = this.tasks[_nextHeaderIndex]; // set the obtained task as current
            TaskProcessor.Process(this.currentTask); // process current
            this.tasks.Remove(_pendingRemove); // remove the previous task
            this.AddTask(); // adds an arbitrary task to the list

            if(this.OnHeadChange != null)
            {
                this.OnHeadChange(this.currentTask);
            }
        }

        public List<int> GetTasks()
        {
            return this.tasks;
        }

        public int GetTaskNumber()
        {
            return this.tasks.Count;
        }
    }
}
