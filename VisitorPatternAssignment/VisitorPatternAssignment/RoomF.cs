using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternAssignment
{
    /// <summary>
    /// Finish
    /// </summary>
    public class RoomF : Room
    {
        public delegate void gameFinishedHandler(int nrSteps);
        public event gameFinishedHandler gameFinished;
        private int nrStepsBeforeMe;

        private void ReportFinished(int nrSteps)
        {
            System.Console.WriteLine(DateTime.Now+">> The player has finished the game in " + nrSteps + " steps!");
        }

        public RoomF(int _k) : base(_k) {
            this.nrStepsBeforeMe = 0;
            this.gameFinished += this.ReportFinished;
        }

        public override void accept(Visitor v)
        {
            // TODO: should get the number of steps taken
            v.VisitRoomF(this);
            this.nrStepsBeforeMe = v.nrSteps;
            this.Finish();
        }

        

        /// <summary>
        /// Finishes the game
        /// </summary>
        /// <param name="v"></param>
        public void Finish()
        {
            this.gameFinished(this.nrStepsBeforeMe);
        }
    }
}
