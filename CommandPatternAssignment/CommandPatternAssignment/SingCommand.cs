using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternAssignment
{
    /// <summary>
    /// A simple command to trigger the sing of a targeted singer
    /// </summary>
    public class SingCommand : ICommand
    {
        private Singer target;

        public SingCommand(Singer s)
        {
            this.target = s;
        }

        public void execute()
        {
            this.target.Sing();
        }
    }
}
