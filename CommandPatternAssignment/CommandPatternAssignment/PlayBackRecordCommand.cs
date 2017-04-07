using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternAssignment
{
    /// <summary>
    /// A macros command
    /// </summary>
    public class PlayBackRecordCommand : ICommand 
    {
        private List<ICommand> comHistory;

        public PlayBackRecordCommand()
        {
            this.comHistory = new List<ICommand>();
        }

        /// <summary>
        /// Adds the specified command to the collection
        /// </summary>
        /// <param name="c"></param>
        public void AddCommand(ICommand c)
        {
            this.comHistory.Add(c);
        }

        /// <summary>
        /// Used to clear the data collected
        /// </summary>
        public void ClearCollection()
        {
            this.comHistory.Clear();
        }

        public void execute()
        {
            // would be nice to schedule them one after another, but maybe that's for some better time
            foreach(ICommand c in this.comHistory)
            {
                c.execute();
            }
        }
    }
}
