using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternAssignment
{
    /// <summary>
    /// Changes the Trio Notes and makes a test song
    /// </summary>
    public class ChangeTrioCommand : ICommand
    {
        // the target that is required to execute the dependent sing methods.
        private Listener audience;

        public ChangeTrioCommand(Listener _l)
        {
            this.audience = _l;
        }

        /// <summary>
        /// Respecs the singers and tries out their new notes
        /// </summary>
        public void execute()
        {
            Singer[] singerGroup = this.audience.RespecializeTrio();
            for(int i = 0; i < new Random().Next(3,8); i++)
            {
                singerGroup[i % 3].Sing();
            }
            this.audience.AddNewline();
        }
    }
}
