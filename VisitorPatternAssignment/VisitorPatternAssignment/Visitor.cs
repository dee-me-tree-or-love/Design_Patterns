using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternAssignment
{
    public abstract class Visitor
    {
        public const string IDLE = "hmmm....";

        public int nrSteps { get; private set; }
        public string buff; // empty by default
        /// <summary>
        /// What does the visitor think about the room - is set on the visit of the room
        /// </summary>
        public string impression
        {
            get; protected set;
        }


        public Visitor()
        {
            this.impression = Visitor.IDLE;
            this.buff = "";
        }

        /// <summary>
        /// Will be invoked by the room
        /// </summary>
        public void makeStep()
        {
            this.nrSteps++;
        }

        // feels like the methods VisitRoom could be just overloads of the same method with different parameter, but let's stick to the blueprint from the books
        
        /// <summary>
        /// Visit the entrance
        /// </summary>
        /// <param name="entr"></param>
        abstract public void VisitRoomE(RoomE entr);

        /// <summary>
        /// Visit the finish
        /// </summary>
        /// <param name="fin"></param>
        abstract public void VisitRoomF(RoomF fin);

        /// <summary>
        /// Visit the danger room
        /// </summary>
        /// <param name="fin"></param>
        abstract public void VisitRoomD(RoomD dan);

        /// <summary>
        /// Visit the shrine room
        /// </summary>
        /// <param name="fin"></param>
        abstract public void VisitRoomS(RoomS shr);
    }
}
