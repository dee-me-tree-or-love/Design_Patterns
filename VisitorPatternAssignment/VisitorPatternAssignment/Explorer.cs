using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternAssignment
{

    public class Explorer : Visitor
    {
        public const string IMPRESSIONENT = "I hope there will be something to explore along the path";
        public const string IMPRESSIONFIN = "Finaalyyyyyyyyy! ...I will write a book about it....";

        public override void VisitRoomD(RoomD dan)
        {
            this.impression = "Oh, what a peculiar group of " + dan.getAttacker() + "! I wish they weren't so angry...";
        }

        public override void VisitRoomE(RoomE entr)
        {
            this.impression = Explorer.IMPRESSIONENT;
        }

        public override void VisitRoomF(RoomF fin)
        {
            this.makeStep();
            this.impression = IMPRESSIONFIN;
        }

        public override void VisitRoomS(RoomS shr)
        {
            this.impression = "Hmmm, that was weird... " + shr.getBlesser() +", huh? I should research it later...";
        }
    }
}
